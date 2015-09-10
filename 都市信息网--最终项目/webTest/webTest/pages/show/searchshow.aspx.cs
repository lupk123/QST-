using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webTest.dao;
using webTest.model;
using System.Collections;
using webTest.view;

namespace webTest.pages.show
{
    public partial class searchshow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gdvInfo.AutoGenerateColumns = false;
                showType();
                showData();
            }
        }

        private void showData()
        {
            ArrayList list = null;
            TbInfoService infoService = new TbInfoService();
           // Search search = (Search)Session["search"];
           
            //if(search != null)
            //    list = infoService.searchInfo(search.InfoType, search.Keys, search.Type, search.All);
            string keys = title.Text;
            //Response.Write(DropDownList1.SelectedValue);
            int type = Convert.ToInt32(DropDownList1.SelectedValue);
            string typeId = "";
            list = infoService.searchInfo(type, keys, typeId, 0);
            gdvInfo.DataSource = list;         
            gdvInfo.DataBind();
        }

        /// <summary>
        /// 下拉列表显示信息类型
        /// </summary>
        public void showType()
        {
            TbTypeService service = new TbTypeService();
            ArrayList list = service.GetTbTypeList();
            TbType tb = new TbType();
            tb.Id = 0;
            tb.TypeIntro = "全部";
            list.Insert(0, tb);

            DropDownList1.DataSource = list;
            DropDownList1.DataTextField = "TypeIntro";
            // infoType.DataTextField = "Id";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            showData();

        }
    }
}
