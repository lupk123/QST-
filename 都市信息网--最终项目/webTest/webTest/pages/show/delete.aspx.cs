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
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int typeId = 0;
                string id = Request.QueryString["id"];
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
                TbInfoService infoService = new TbInfoService();
                int num = infoService.deleInfo(typeId);
                if (num == 1)
                {
                    Response.Write("<script>alert('删除成功'); window.location.href = '../show/searchshow.aspx'; </script>");
                }
                else
                    Response.Write("<script>alert('删除失败')</script>");
            }
        }
    }
}
