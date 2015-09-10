using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webTest.dao;
using webTest.model;

namespace webTest.pages.admin.view
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Users user = (Users)Session["user"];
                username.Text = user.LoginName;
            }
        }
    }
}
