using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersManager.BLL;
using UsersManager.Model;

namespace UsersManager
{
    public partial class FrmSaveUser : Form
    {
        private DelIsNullLoginId DelIsNull;
        public FrmSaveUser(DelIsNullLoginId del)
        {
            InitializeComponent();
            DelIsNull = del;
        }
        private bool isAdd = true;

        public bool IsAdd { get => isAdd; set => isAdd = value; }

        private void tbSave_Click(object sender, EventArgs e)
        {
            string name = tbUserName.Text.Trim();
            string age = tbAge.Text.Trim();
            string loginID = tbLoginID.Text.Trim();
            string loginPwd = tbLoginPwd.Text.Trim();
            string checkPwd = tbCheckPwd.Text.Trim();
            string loginIp = IPAddress.Any.ToString();
            string checkTime = DateTime.Now.ToString();
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(loginID) || string.IsNullOrEmpty(loginPwd) || string.IsNullOrEmpty(checkPwd))
            {
                MessageBox.Show("输入完整内容");
                return;
            }
            if (loginPwd != checkPwd)
            {
                MessageBox.Show("两次输入的密码不一样");
                return;
            }
            if (DelIsNull(loginID) && loginID!=_userInfo.LoginID)
            {
                MessageBox.Show("此昵称已被人使用");
                return ;
            }
            if (IsAdd)
            {
               
                UserInfoModel model = new UserInfoModel();
                model.Name = name;
                model.Age = age;
                model.LoginID = loginID;
                model.LoginPwd = loginPwd;
                model.RoleId = 1;
                model.LoginIP = loginIp;
                model.CheckTime = checkTime;
                UserInfoBLL userInfoBLL = new UserInfoBLL();
                bool r = userInfoBLL.AddUserInfo(model);
                if (r)
                {
                    MessageBox.Show("添加成功");
                    this.Close();
                }
            }
            else
            {
                _userInfo.Name = name;
                _userInfo.Age = age;
                _userInfo.LoginID = loginID;
                _userInfo.LoginPwd = loginPwd;
                _userInfo.LoginIP = loginIp;
                _userInfo.CheckTime = checkTime;
                UserInfoBLL userInfoBLL = new UserInfoBLL();
                bool r = userInfoBLL.UpdataUserInfo(_userInfo);
                if (r)
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
            }
        }
        private UserInfoModel _userInfo;
        private void FrmSaveUser_Load(object sender, EventArgs e)
        {
            if (!IsAdd && this.Tag!=null)
            {
                _userInfo = (UserInfoModel)this.Tag;
                tbUserName.Text = _userInfo.Name;
                tbAge.Text = _userInfo.Age;
                tbLoginID.Text = _userInfo.LoginID;
                tbLoginPwd.Text = _userInfo.LoginPwd;
            }
        }
    }
}
