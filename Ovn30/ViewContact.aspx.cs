using SQLLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace Ovn30
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(Session["myContact"] != null && Session["myContact"].ToString().Length > 0)
            //{
            //    infoLiteral.Text = Session["myContact"].ToString();
            //}          
            //else if(Request["id"] != null && Request["id"].Length > 0)
            //{
            //    Contact myContact = SQL.GetContact(Request["id"]);

            //    infoLiteral.Text = myContact.ToString();

            //    Session["myContact"] = myContact.ToString();
            //}
            //else
            //{
            //    //TODO Hämta något default
            //}
        }
    }
}