using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using webTest.model;
using webTest.dao;

namespace webTest.view
{
    public partial class left : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                showType();
                showSearchType();
            }
        }
        /// <summary>
        /// 显示查找类型
        /// </summary>
        private void showSearchType()
        {
            ArrayList list = new ArrayList();
            SearchType search = new SearchType();
            search.Title = "标题";
            search.Content = "info_title";
            list.Add(search);
            search = new SearchType();
            search.Title = "内容";
            search.Content = "info_content";
            list.Add(search);
            search = new SearchType();
            search.Title = "联系人";
            search.Content = "info_linkman";
            list.Add(search);
            search = new SearchType();
            search.Title = "电话号码";
            search.Content = "info_phone";
            list.Add(search);
            search = new SearchType();
            search.Title = "邮箱";
            search.Content = "info_email";
            list.Add(search);

            searchType.DataSource = list;
            searchType.DataTextField = "Title";
            searchType.DataValueField = "Content";
            searchType.DataBind();
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
            tb.TypeIntro = "全部消息";
            list.Insert(0, tb);

            infoType.DataSource = list;
            infoType.DataTextField = "TypeIntro";
           // infoType.DataTextField = "Id";
            infoType.DataValueField = "Id";
            infoType.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void search_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.InfoType = Convert.ToInt32(infoType.SelectedValue);
            search.Keys = keys.Text;
            search.Type = searchType.SelectedValue;           
            //if (allSearch.Checked == true && likeSearch.Checked == true)
            //    search.All = 1;
            //else if (allSearch.Checked == false && likeSearch.Checked == true)
            //    search.All = 0;
            //else
            //    search.All = 0;
            Session.Clear();
            Session["search"] = search;
            //Response.Write("<script>window.open( '../pages/show/searchshow.aspx');</scirpt>");
            Response.Redirect("../pages/show/searchshow.aspx");
        }
    }
}
