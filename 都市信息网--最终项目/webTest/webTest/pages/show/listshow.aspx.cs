using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webTest.model;
using webTest.dao;

namespace webTest.pages.show
{
    public partial class listshow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            int typeId = 0;
            if (id != null && id != "")
            {
                try
                {
                    typeId = Convert.ToInt32(id);
                }
                catch (Exception)
                {

                    typeId = -1;
                }
            }      
            showData(typeId);
        }

        private void showData(int typeId)
        {
            Info info = new Info();
            string content = null;
            TbInfoService infoservice = new TbInfoService();
            info = infoservice.CheckNewInfoByPay(1, typeId);
     //       Labe_Message.Text = DBHelper.Message;
            if (info != null)
            {
                title1.Text = info.Info_title;
                time1.Text = string.Format("{0:yyyy-MM-dd HH:mm:ss}", info.Info_date);
                if (info.Info_content == null || info.Info_content == string.Empty) {
                    info.Info_content = "无内容";
                }

                if (info.Info_content.Length > 20)
                {
                    content = info.Info_content.Substring(0, 19) + "...";
                }
                else
                    content = info.Info_content;
                content1.Text = content;
                try
                {
                    if (info.Info_phone.Length == 11)
                        phone1.Text = info.Info_phone.Substring(0, 7) + "****";                
                    linkman1.Text = info.Info_linkman;
                    email1.Text = "***" + info.Info_email.Substring(3);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
                content1.Text = "暂时没有此类消息";
            
            info = infoservice.CheckNewInfoByPay(0, typeId);
      //      Labe_Message.Text = DBHelper.Message;
            if (info != null)
            {
                title0.Text = info.Info_title;
                time0.Text = info.Info_date;
                if (info.Info_content == null || info.Info_content == string.Empty)
                {
                    info.Info_content = "无内容";
                }
                if (info.Info_content.Length > 20)
                {
                    content = info.Info_content.Substring(0, 19) + "...";
                }
                else
                    content = info.Info_content;
                content0.Text = content;
                phone0.Text = info.Info_phone.Substring(0, 7) + "****";
                linkman0.Text = info.Info_linkman;
                email0.Text = "***" + info.Info_email.Substring(3);
            }
            else
                content0.Text = "暂时没有此类消息";
        }
    }
}
