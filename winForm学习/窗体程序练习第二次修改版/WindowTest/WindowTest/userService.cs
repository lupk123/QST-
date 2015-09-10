using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowTest
{
    class userService
    {
        /// <summary>
        /// 验证用户登录
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User checkLogin(User user)
        {
            User returnUser = null;
            string sql = "select * from users where loginName = @name and password = @pwd";
            SqlParameter[] value = new SqlParameter[]{
                new SqlParameter("@name", user.LoginName),
                new SqlParameter("@pwd", user.Password)
            };
            DataTable dt = DBHelper.GetDataTable(sql, value);
            if(dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                returnUser = new User();
                returnUser.LoginName = user.LoginName;
                returnUser.Password = user.Password;
                returnUser.Id = Convert.ToInt32(dr["id"]);
                returnUser.RealName = dr["realName"].ToString();
            }            
            return returnUser;
        }
    }
}
