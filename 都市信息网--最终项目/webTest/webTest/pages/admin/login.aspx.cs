using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webTest.dao;
using webTest.model;

namespace webTest.pages.admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UsersService userService = new UsersService();
            Users user = new Users();
            string name = userName.Text;
            string pwd = password.Text;
            user.LoginName = name;
            user.Password = pwd;
            user = userService.CheckLogin(user);
            if (user == null)
                alter.Text = "用户名或密码不正确";
            else
            {
                Session["user"] = user;
                Response.Redirect("view/AdminTemp.aspx");
            }
        }
    }
}
