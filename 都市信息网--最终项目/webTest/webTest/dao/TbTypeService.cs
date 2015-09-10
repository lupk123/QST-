using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data;
using webTest.model;

namespace webTest.dao
{
    public class TbTypeService
    {
        /// <summary>
        /// 返回信息类型
        /// </summary>
        /// <returns></returns>
        public ArrayList GetTbTypeList()
        {
            ArrayList list = new ArrayList();
            string sql = "select * from tb_type";
            DataTable dt = DBHelper.GetDataTable(sql);
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    TbType tb = new TbType();
                    tb.Id = Convert.ToInt32(dr["id"]);
                    tb.TypeIntro = dr["type_intro"].ToString();
                    list.Add(tb);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return list;
        }
    }
}
