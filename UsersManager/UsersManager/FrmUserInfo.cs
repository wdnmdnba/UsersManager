using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersManager.BLL;
using UsersManager.Model;

namespace UsersManager
{
    public delegate bool DelIsNullLoginId(string Loginid);
    public partial class FrmUserInfo : Form
    {
        public FrmUserInfo()
        {
            InitializeComponent();
        }
        private List<UserInfoModel> userInfoModels = new List<UserInfoModel>();
        private void FrmUserInfo_Load(object sender, EventArgs e)
        {
            BindDGV();
        }

        private void BindDGV()
        {
            UserInfoBLL userInfoBLL = new UserInfoBLL();
            userInfoModels = userInfoBLL.GetUserAll();
            dgvInfo.DataSource = userInfoModels;
        }

        private void dgvInfo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                smtUpdata.Visible = false;
                smtAdd.Visible = true;
                smtDel.Visible = false;
            }
        }

        private void dgvInfo_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                if (e.RowIndex > -1)
                {
                    dgvInfo.Rows[e.RowIndex].Selected = true;
                    smtUpdata.Visible = true;
                    smtAdd.Visible = true;
                    smtDel.Visible = true;
                }
               
            }
        }

        private void smtUpdata_Click(object sender, EventArgs e)
        {
            FrmSaveUser  frmSaveUser = new FrmSaveUser(IsNullLoginId);
            frmSaveUser.IsAdd = false;
            frmSaveUser.Tag = dgvInfo.CurrentRow.DataBoundItem;
            frmSaveUser.ShowDialog();
            BindDGV();
        }

        private void smtAdd_Click(object sender, EventArgs e)
        {
            FrmSaveUser frmSaveUser = new FrmSaveUser(IsNullLoginId);
            frmSaveUser.Tag = dgvInfo.CurrentRow.DataBoundItem;
            frmSaveUser.ShowDialog();
            BindDGV();
        }

        private void plTop_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// 查询dgv中是否有这个账号
        /// </summary>
        /// <param name="Loginid"></param>
        /// <returns></returns>
        public bool IsNullLoginId(string Loginid)
        {
            UserInfoModel model = userInfoModels.Find(u=>u.LoginID==Loginid);
            if (model == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void smtDel_Click(object sender, EventArgs e)
        {
            UserInfoBLL userInfoBLL = new UserInfoBLL();
            bool l = userInfoBLL.DelUserInfo((int)dgvInfo.CurrentRow.Cells["UserId"].Value);
            if (l)
            {
                MessageBox.Show("删除成功");
                BindDGV();
                return;
            }
            else
            {
                MessageBox.Show("删除失败");
                return ;
            }
        }
    }
}
