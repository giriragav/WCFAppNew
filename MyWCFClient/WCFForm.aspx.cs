using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWCFClient.MyWCFService;

namespace MyWCFClient
{
    public partial class WCFForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MyWCFService.WCFServicesClient WCFClient = new WCFServicesClient("BasicHttpBinding_IWCFServices");
            Response.Write(WCFClient.GetTextData());

        }
    }
}