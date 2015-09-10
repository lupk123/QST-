using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace webTest.dao
{
    public  class DBHelper
    {
        /// <summary>
        /// 静态
        /// </summary>
        static SqlConnection conn = null;
        public static string Message = string.Empty;

        private static void openConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            //string connStr = "Data Source=.\\SQL2012;Initial Catalog=account;Persist Security Info=True;User ID=sa;Password=123456";
            conn = new SqlConnection(connStr);
            conn.Open();
        }
        /// <summary>
        /// 执行增删改操作
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <returns>返回成功所影响的行数</returns>
        public static int executeCommand(string sql)
        {
            int ok = 0;
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                ok = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Message = e.Message;
            }
            finally
            {
                Close();
            }
            return ok;
        }
        /// <summary>
        /// 方法重载
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int executeCommand(string sql, SqlParameter[] values)
        {
            int ok = 0;
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddRange(values);
                ok = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Message = e.Message;
            }
            finally
            {
                Close();
            }
            return ok;
        }
        /// <summary>
        /// 执行查询操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetDataReader(string sql)
        {
            SqlDataReader rs = null;
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                rs = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                Message = e.Message;
            }
            return rs;
        }
        /// <summary>
        /// 执行查询并返回DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                Message = e.Message;
            }
            finally
            {
                Close();
            }
            return dt;
        }
        public static DataTable GetDataTable(string sql, SqlParameter[] values)
        {
            DataTable dt = new DataTable();
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddRange(values);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                Message = e.Message;
            }
            finally
            {
                Close();
            }
            return dt;
        }
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public static void Close()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
