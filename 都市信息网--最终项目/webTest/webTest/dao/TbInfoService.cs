using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using webTest.model;
using System.Collections;

namespace webTest.dao
{
    public class TbInfoService
    {
        public int deleInfo(int id)
        {
            int num = 0;
            string sql = "delete from tb_info where id = " + id;
            num = DBHelper.executeCommand(sql);
            return num;
        }

        /// <summary>
        /// 发布信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AddInfo(Info info)
        {
            string sql = "insert into tb_info(info_type, info_title, info_content, info_linkman, info_phone, info_email, info_date, info_state, info_payfor)values(@type, @title, @content, @linkman, @phone, @email, @time, 1, 0)";
            SqlParameter[] value = new SqlParameter[]
            {
                new SqlParameter("@type", info.Info_type),
                new SqlParameter("@title", info.Info_title),
                new SqlParameter("@content", info.Info_content),
                new SqlParameter("@linkman", info.Info_linkman),
                new SqlParameter("@phone", info.Info_phone),
                new SqlParameter("@email", info.Info_email),
                new SqlParameter("@time", info.Info_date)
            };
            int num = DBHelper.executeCommand(sql, value);
            return num;
        }
        /// <summary>
        /// 修改信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int ModifyInfo(Info info)
        {
            string sql = "update tb_info set info_type = @type, info_title = @title, info_content = @content, info_linkman = @linkman, info_phone = @phone, info_email = @email, info_date = @time where id = @id";
            SqlParameter[] value = new SqlParameter[]
            {
                new SqlParameter("@type", info.Info_type),
                new SqlParameter("@title", info.Info_title),
                new SqlParameter("@content", info.Info_content),
                new SqlParameter("@linkman", info.Info_linkman),
                new SqlParameter("@phone", info.Info_phone),
                new SqlParameter("@email", info.Info_email),
                new SqlParameter("@time", info.Info_date),
                new SqlParameter("@id", info.Id)
            };
            int num = DBHelper.executeCommand(sql, value);
            return num;
        }
        /// <summary>
        /// 查找最新的免费缴费信息
        /// </summary>
        /// <param name="pay"></param>
        /// <returns></returns>
        public Info CheckNewInfoByPay(int pay, int typeId)
        {
            Info info = null;
            string sql = "select * from tb_info where info_payfor = @pay";
            if (typeId > 0)
            {
                sql += " and info_type = @type";
            }
            sql += " order by id desc";
            SqlParameter[] value = new SqlParameter[]{
                new SqlParameter("@pay", pay),
                new SqlParameter("@type", typeId)
            };
            DataTable dt = DBHelper.GetDataTable(sql, value);
            try
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    info = new Info();
                    info.Id = Convert.ToInt32(dr["id"]);
                    info.Info_content = dr["info_content"].ToString();
                    info.Info_date = dr["info_date"].ToString();
                    info.Info_email = dr["info_email"].ToString();
                    info.Info_linkman = dr["info_linkman"].ToString();
                    info.Info_phone = dr["info_phone"].ToString();
                    info.Info_title = dr["info_title"].ToString();
                    info.Info_type = Convert.ToInt32(dr["info_type"]);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return info;
        }
        /// <summary>
        /// 查询信息
        /// </summary>
        /// <param name="typeId"></param>
        /// <param name="keys"></param>
        /// <param name="type"></param>
        /// <param name="all"></param>
        /// <returns></returns>
        public ArrayList searchInfo(int typeId, string keys, string type, int all)
        {
            ArrayList list = new ArrayList();
            string sql = null;
            Info info = null;
            sql = "select tb_info.*, tb_type.type_intro from tb_info inner join tb_type on tb_info.info_type = tb_type.id where 1=1";
            if (typeId > 0)
                sql += " and info_type =" + typeId;
            if (all == 0)
            {
                if (keys != "" && type != "")
                    sql += " and " + type + "=" + keys;
                else if (keys != "")
                    sql += " and info_title like '%" + keys+"%'";
            }
            else if (all == 1)
            {
                if (keys != "" && type != "")
                    sql += " and " + type + " like '%" + keys + "%'";
                else if (keys != "")
                    sql += " and info_title like '%" + keys + "%'";
            }
            DataTable dt = DBHelper.GetDataTable(sql);
            if (dt != null)
            {                                
                foreach (DataRow dr in dt.Rows)
                {
                    info = new Info();

                    try
                    {
                        info.Id = Convert.ToInt32(dr["id"]);
                        info.Info_title = dr["info_title"].ToString();
                        info.Info_date = dr["info_date"].ToString();
                        info.Info_content = dr["info_content"].ToString();
                        info.Info_phone = dr["info_phone"].ToString();
                        info.Info_linkman = dr["info_linkman"].ToString();
                        info.Info_email = dr["info_email"].ToString();
                        info.TbType.TypeIntro = dr["type_intro"].ToString();
                        list.Add(info);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// 根据编号查找信息
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public Info CheckId(int typeId)
        {
            Info info = null;
            string sql = "select * from tb_info  where tb_info.id = @id";
            SqlParameter[] value = new SqlParameter[]{
                new SqlParameter("@id", typeId)
            };
            DataTable dt = DBHelper.GetDataTable(sql, value);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                info = new Info();
                info.Id = Convert.ToInt32(dr["id"]);
                //info.Info_content = dr["info_content"].ToString();
                info.Info_date = dr["info_date"].ToString();
                info.Info_email = dr["info_email"].ToString();
                info.Info_linkman = dr["info_linkman"].ToString();
                info.Info_phone = dr["info_phone"].ToString();
                info.Info_title = dr["info_title"].ToString();
                info.Info_type = Convert.ToInt32(dr["info_type"]);
            }
            return info;
        }
        /// <summary>
        /// 首页缴费信息推荐
        /// </summary>
        /// <returns></returns>
        public ArrayList GetNewInfoPayfor()
        {
            ArrayList list = new ArrayList();
            string sql = null;
            Info info = null;
            sql = "select top 8 * from tb_info inner join tb_type on tb_info.info_type = tb_type.id where tb_info.info_payfor = 1 ";            
            DataTable dt = DBHelper.GetDataTable(sql);
            try
            {
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        info = new Info();
                        info.Id = Convert.ToInt32(dr["id"]);
                        info.Info_title = dr["info_title"].ToString();
                        info.Info_date = dr["info_date"].ToString();
                        info.Info_content = dr["info_content"].ToString();
                        info.Info_phone = dr["info_phone"].ToString();
                        info.Info_linkman = dr["info_linkman"].ToString();
                        info.Info_email = dr["info_email"].ToString();
                        info.TbType.TypeIntro = dr["type_intro"].ToString();
                        list.Add(info);
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return list;
        }
        /// <summary>
        /// 查看详细信息
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public Info CheckContent(int typeId)
        {
            Info info = null;
            string sql = "select * from tb_info inner join tb_type on tb_info.info_type = tb_type.id where tb_info.id = @id";
            SqlParameter[] value = new SqlParameter[]{
                new SqlParameter("@id", typeId)
            };
            DataTable dt = DBHelper.GetDataTable(sql, value);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                info = new Info();
                info.Id = Convert.ToInt32(dr["id"]);
                info.Info_content = dr["info_content"].ToString();
                info.Info_date = dr["info_date"].ToString();
                info.Info_email = dr["info_email"].ToString();
                info.Info_linkman = dr["info_linkman"].ToString();
                info.Info_phone = dr["info_phone"].ToString();
                info.Info_title = dr["info_title"].ToString();
                info.TbType.TypeIntro = dr["type_intro"].ToString();
            }
            return info;
        }

        public ArrayList GetNewInfoNoPay(int typeId)
        {
            ArrayList list = new ArrayList();
            string sql = null;
            Info info = null;
            sql = "select top 5 * from tb_info where info_payfor = 0 and info_type = "+typeId;
            DataTable dt = DBHelper.GetDataTable(sql);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    try
                    {
                        info = new Info();
                        info.Id = Convert.ToInt32(dr["id"]);
                        info.Info_title = dr["info_title"].ToString();
                        list.Add(info);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            return list;
        }
    }
}
