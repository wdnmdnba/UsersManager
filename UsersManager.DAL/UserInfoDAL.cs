using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersManager.DAL.comm;
using UsersManager.Model;

namespace UsersManager.DAL
{
    public class UserInfoDAL
    {
        /// <summary>
        /// 查询用户表表
        /// </summary>
        /// <param name="SQLwhere"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string SQLwhere)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("select id,name,age,loginid,loginpwd,loginip,checktime,roleId from userinfo");
            if (!string.IsNullOrEmpty(SQLwhere))
            {
                builder.Append(" where ");
                builder.Append(SQLwhere);
            }
            return DBHelper.Query(builder.ToString());
        }
        /// <summary>
        /// 获取user集合
        /// </summary>
        /// <param name="SQLWhere"></param>
        /// <returns></returns>
        public List<UserInfoModel> GetUsers(string SQLWhere)
        {
            List<UserInfoModel> usersModels = new List<UserInfoModel>();
            DataSet ds = GetDataSet(SQLWhere);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
               usersModels.Add(dr.ToModel<UserInfoModel>());
            }
            return usersModels;
        }
        
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(UserInfoModel model)
        {
            StringBuilder builder =new StringBuilder();
            builder.Append(" insert into userinfo (Name,Age,LoginID,LoginPwd,LoginIp,CheckTime,roleId) values(@Name,@Age,@LoginID,@LoginPwd,@LoginIp,@CheckTime,@roleId)");
            SqlParameter[] parameters =
            {
                new SqlParameter("@Name",SqlDbType.VarChar),
                new SqlParameter("@Age",SqlDbType.VarChar),
                new SqlParameter("@LoginID",SqlDbType.VarChar),
                new SqlParameter("@LoginPwd",SqlDbType.VarChar),
                new SqlParameter("@LoginIp",SqlDbType.VarChar),
                new SqlParameter("@CheckTime",SqlDbType.VarChar),
                new SqlParameter("@roleId",SqlDbType.VarChar)
            };
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Age;
            parameters[2].Value = model.LoginID;
            parameters[3].Value = model.LoginPwd;
            parameters[4].Value = model.LoginIP;
            parameters[5].Value = model.CheckTime;
            parameters[6].Value = model.RoleId;
            int r = DBHelper.ExecuteNonQuery(builder.ToString(), parameters);
            return r;
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Updata(UserInfoModel model)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("update userinfo set name = @Name,Age = @Age,LoginID = @LoginID,LoginPwd = @LoginPwd,LoginIp=@LoginIp,CheckTime=@CheckTime,roleId=@roleId where id = @id");
            SqlParameter[] parameters =
            {
                new SqlParameter("@Name",SqlDbType.VarChar),
                new SqlParameter("@Age",SqlDbType.VarChar),
                new SqlParameter("@LoginID",SqlDbType.VarChar),
                new SqlParameter("@LoginPwd",SqlDbType.VarChar),
                new SqlParameter("@LoginIp",SqlDbType.VarChar),
                new SqlParameter("@CheckTime",SqlDbType.VarChar),
                new SqlParameter("@roleId",SqlDbType.VarChar),
                new SqlParameter("@id",SqlDbType.Int)
            };
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Age;
            parameters[2].Value = model.LoginID;
            parameters[3].Value = model.LoginPwd;
            parameters[4].Value = model.LoginIP;
            parameters[5].Value = model.CheckTime;
            parameters[6].Value = model.RoleId;
            parameters[7].Value = model.Id;
            int r = DBHelper.ExecuteNonQuery(builder.ToString(), parameters);
            return r > 0;
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("delete from userinfo where id = @id");
            SqlParameter[] parameters =
            {
                new SqlParameter("@id",SqlDbType.Int)
            };
            parameters[0].Value = id;
            int r = DBHelper.ExecuteNonQuery(builder.ToString(),parameters);
            return r > 0;
        }
    }
}
