using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webTest.dao;
using webTest.model;

namespace webTest.pages.show
{
    public partial class singleshow : System.Web.UI.Page
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
            GetInfoContent(typeId);
        }
        private void GetInfoContent(int id)
        {
            TbInfoService infoService = new TbInfoService();
            Info info = null;
            info = infoService.CheckContent(id);
            if (info != null)
            {
                infoTitle1.Text = info.Info_title;
                time1.Text = info.Info_date;
                content1.Text = info.Info_content;
                phone1.Text = info.Info_phone;
                linkman1.Text = info.Info_linkman;
                email1.Text = info.Info_email;
                infoType.Text = info.TbType.TypeIntro;
                infoContent.Text = info.Info_content;
                addTime.Text = info.Info_date;
                infoTitle.Text = info.Info_title;
                phone.Text = info.Info_phone;
                email.Text = info.Info_email;
                linkman.Text = info.Info_linkman;
            }
        }
    }
}
