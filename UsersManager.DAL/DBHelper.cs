using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersManager.DAL
{
    internal class DBHelper
    {
        /// <summary>
        /// 数据库链接字符串
        /// </summary>
        public static string SQLstr = "server=.;database=DB_Users;uid=sa;pwd=123456";
        /// <summary>
        /// 查询数据表
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        public static DataSet Query(string SQL)
        {
            using (SqlConnection conn = new SqlConnection(SQLstr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(SQL,conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }
        /// <summary>
        /// 数据库增删改
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns>受影响行数</returns>
        /// <exception cref="Exception"></exception>
        public static int ExecuteNonQuery(string SQL,params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(SQLstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL,conn);
                cmd.Parameters.AddRange(parameters);
                int r = cmd.ExecuteNonQuery();
                if (r >= 1)
                {
                    return r;
                }
                else
                {
                    throw new Exception("数据库操作失败");
                }
            }
        }
    }
}
