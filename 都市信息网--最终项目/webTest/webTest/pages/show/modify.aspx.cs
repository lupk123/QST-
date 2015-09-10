using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webTest.dao;
using webTest.model;
using System.Collections;
using System.Data;

namespace webTest.pages.show
{
    public partial class modify : System.Web.UI.Page
    {
        int typeId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];

            if (id != null && id != "")
            {
                try
                {
                    typeId = Convert.ToInt32(id);
                }
                catch (Exception)                {

                    typeId = -1;
                }
            }
            if (!Page.IsPostBack)
            {
                showType();
                
                showData(typeId);
            }
        }

        protected void Ok_Click(object sender, EventArgs e)
        {
            TbInfoService infoService = new TbInfoService();
            string date = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            Info info = new Info();
            info.Id = typeId;
            info.Info_type = Convert.ToInt32(TbTypeList.SelectedValue);
            info.Info_content = txtContent.Text;
            info.Info_date = date;
            info.Info_email = email.Text;
            info.Info_linkman = linkman.Text;
            info.Info_phone = phone.Text;
            info.Info_title = infoTitle.Text;
            int num = infoService.ModifyInfo(info);
            if (num == 1)
            {
                Response.Write("<script>alert('修改成功'); window.location.href = '../show/searchshow.aspx'; </script>");
            }
            else
                Response.Write("<script>alert('修改失败')</script>");
        }

        private void showData(int typeId)
        {
            Info info = null;
            TbInfoService infoService = new TbInfoService();
            info = infoService.CheckId(typeId);
            if (info != null)
            {
                TbTypeList.SelectedValue = info.Info_type.ToString();
                infoTitle.Text = info.Info_title;
                txtContent.Text = info.Info_content;
                phone.Text = info.Info_phone;
                email.Text = info.Info_email;
                linkman.Text = info.Info_linkman;
            }
            else
            {

            }
        }
        protected void txtContent_TextChanged(object sender, EventArgs e)
        {

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
    }
}
