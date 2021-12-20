using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersManager.DAL;
using UsersManager.Model;

namespace UsersManager.BLL
{
    public class UserInfoBLL
    {
        /// <summary>
        /// 根据登录名称和密码查询
        /// </summary>
        /// <param name="loginId"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
         public UserInfoModel GetUserByLoginIdAndPwd(string loginId,string pwd)
        {
            string sqlWhere = $" loginID = '{loginId}'  and LoginPwd = '{pwd}'";
            UserInfoDAL usersDAL = new UserInfoDAL();
            List<UserInfoModel> users  = new List<UserInfoModel>();
            users = usersDAL.GetUsers(sqlWhere);
            if (users.Count > 0)
            {
                return users[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        public List<UserInfoModel> GetUserAll()
        {
            UserInfoDAL usersDAL = new UserInfoDAL();
            List<UserInfoModel> users = new List<UserInfoModel>();
            users = usersDAL.GetUsers("");
            return users;
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public bool AddUserInfo(UserInfoModel model)
        {
            UserInfoDAL userInfoDAL = new UserInfoDAL();
            int r = userInfoDAL.Add(model);
            return r > 0;
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdataUserInfo(UserInfoModel model)
        {
            UserInfoDAL userInfoDAL = new UserInfoDAL();
            return userInfoDAL.Updata(model);
            
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DelUserInfo(int id)
        {
            UserInfoDAL userInfoDAL=new UserInfoDAL();
            return userInfoDAL.Delete(id);
        }

    }
   
}
