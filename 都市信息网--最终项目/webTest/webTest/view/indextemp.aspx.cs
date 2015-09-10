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
    public partial class indextemp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            showDataTop();
            showDataMiddle();
        }
        private void showDataTop()
        { 
            TbInfoService infoService = new TbInfoService();
            ArrayList list = new ArrayList();
            list = infoService.GetNewInfoPayfor();
            Repeater1.DataSource = list;
            Repeater1.DataBind();
        }
        private void showDataMiddle()
        {
            int typeId = 0;
            TbInfoService infoService = new TbInfoService();
            ArrayList list1 = new ArrayList();
            typeId = 2;
            list1 = infoService.GetNewInfoNoPay(typeId);
            Repeater2.DataSource = list1;
            Repeater2.DataBind();

            ArrayList list2 = new ArrayList();
            typeId = 7;
            list2 = infoService.GetNewInfoNoPay(typeId);
            Repeater3.DataSource = list2;
            Repeater3.DataBind();
        }
    }
}
