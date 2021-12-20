using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersManager.Model
{
    public class UserInfoModel
    {
        #region 字段
        int _id;
        string _name;
        string _age;
        string _loginID;
        string _loginPwd;
        string _loginIP;
        string _checkTime;
        int _roleId;

        #region 构造函数
        public UserInfoModel()
        {
        }

        public UserInfoModel(int id, string name, string age, string loginID, string loginPwd, string loginIP, string checkTime,int role)
        {
            Id = id;
            Name = name;
            Age = age;
            LoginID = loginID;
            LoginPwd = loginPwd;
            LoginIP = loginIP;
            CheckTime = checkTime;
            RoleId = role;
        }
        #endregion
        #endregion
        #region 属性
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Age { get => _age; set => _age = value; }
        public string LoginID { get => _loginID; set => _loginID = value; }
        public string LoginPwd { get => _loginPwd; set => _loginPwd = value; }
        public string LoginIP { get => _loginIP; set => _loginIP = value; }
        public string CheckTime { get => _checkTime; set => _checkTime = value; }
        public int RoleId { get => _roleId; set => _roleId = value; }
        #endregion

    }
}
