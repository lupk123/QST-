using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webTest.dao;
using webTest.model;
using System.Collections;

namespace webTest.view
{
    public partial class top : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            showTbType();
        }
        private void showTbType()
        {
            TbTypeService typeService = new TbTypeService();
            ArrayList list = new ArrayList();            
            list = typeService.GetTbTypeList();
            rptTbType.DataSource = list;
            rptTbType.DataBind();
        }
    }
}
