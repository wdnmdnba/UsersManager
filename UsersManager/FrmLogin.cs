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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserID = tbUserID.Text.Trim();
            string UserPwd = tbPwd.Text.Trim();
            if (string.IsNullOrEmpty(UserID))
            {
                MessageBox.Show("请输入完整的用户名");
                return;
            }
            if (string.IsNullOrEmpty(UserPwd))
            {
                MessageBox.Show("请输入密码");
                return ;
            }
            UserInfoBLL usersBLL = new UserInfoBLL();
            UserInfoModel usersModel = usersBLL.GetUserByLoginIdAndPwd(UserID, UserPwd);
            if (usersModel != null && usersModel.RoleId==9)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("用户名或密码错误 ");
            }

        }
    }
}
