using SQLLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace Ovn30.svc
{
    public partial class _svcGetContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] != null && Request["id"].Length > 0)
            {
                Contact myContact = SQL.GetContact(Request["id"]);

                jsonInfo.Text = JsonConvert.SerializeObject(myContact);
            }
        }
    }
}