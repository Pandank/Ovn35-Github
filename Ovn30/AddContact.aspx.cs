using SQLLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ovn30
{
    public partial class AddContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAddContact_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                string firstName = TextBoxFirstname.Text.Trim();
                string lastName = TextBoxLastname.Text.Trim();

                if (firstName.Length > 0 && lastName.Length > 0)
                {
                    Contact newContact = new Contact(0, firstName, lastName);
                    newContact.Create();

                    TextBoxFirstname.Text = "";
                    TextBoxLastname.Text = "";

                    Server.Transfer("index.aspx");
                }
            }
        }
    }
}