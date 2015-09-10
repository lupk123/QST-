using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webTest.model;
using webTest.dao;
using System.Collections;

namespace webTest.pages.add
{
    public partial class addInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            showType();
        }
        /// <summary>
        /// 下拉列表显示信息类型
        /// </summary>
        public void showType()
        {
            TbTypeService service = new TbTypeService();
            ArrayList list = service.GetTbTypeList();
            TbTypeList.DataSource = list;
            TbTypeList.DataTextField = "TypeIntro";
            TbTypeList.DataValueField = "Id";
            TbTypeList.DataBind();
        }

        protected void txtContent_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Ok_Click(object sender, EventArgs e)
        {
            TbInfoService infoService = new TbInfoService();
            string date = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            Info info = new Info();
            info.Info_type = Convert.ToInt32(TbTypeList.SelectedValue);
            info.Info_content = txtContent.Text;
            info.Info_email = email.Text;
            info.Info_linkman = linkman.Text;
            info.Info_phone = phone.Text;
            info.Info_title = infoTitle.Text;
            info.Info_date = date;
            int num = infoService.AddInfo(info);
            if (num == 1)
            {
                Response.Write("<script>alert('发布成功'); window.location.href = '../show/listshow.aspx?id=" + info.Id + "'; </script>");
            }
            else
                Response.Write("<script>alert('发布失败')</script>");
        }
    }
}
