using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLLibrary;

namespace Ovn30
{
    public partial class index : System.Web.UI.Page
    {
        List<Contact> contacts = new List<Contact>();

        protected void Page_Load(object sender, EventArgs e)
        {
            contacts = SQL.GetAllContacts();

            if (!IsPostBack)
            {
                LoadContacts();
            }
        }

        private void LoadContacts()
        {
            if (contacts.Count > 0)
            {
                string info = "";
                #region Some text
                //info += "<div class=\"container\">";
                //info += "<div class=\"table-responsive\">";
                //info += "<table class=\"table\" id=\"contactTable\">";
                info += "<table id=\"contactTable\">";
                info += "<thead>";
                info += "<tr>";
                info += " <th>#</th>";
                info += " <th>Firstname</th>";
                info += " <th>Lastname</th>";
                info += " <th>&nbsp</th>";
                info += "</tr>";
                info += "</thead>";
                info += "<tbody>";
                #endregion

                int counter = 1;
                foreach (var tmpContact in contacts)
                {
                    info += "<tr>\n";
                    info += $" <td>{counter++}</td>\n";
                    info += $" <td id=\"firstname{tmpContact.ID}\">{tmpContact.Firstname}</td>\n";
                    info += $" <td id=\"lastname{tmpContact.ID}\">{tmpContact.Lastname}</td>\n";

                    info += " <td>\n";
                    info += $"<a href=\"ViewContact.aspx?id={tmpContact.ID}\">View</a>\n";
                    info += "&nbsp;|&nbsp;\n";
                    //info += $"<a href=\"#\" onclick=\"showModalEdit({tmpContact.ID})\">Edit</a>\n";
                    info += $"<a href=\"EditContact.aspx?id={tmpContact.ID}\">Edit</a>\n";
                    info += "&nbsp;|&nbsp;\n";
                    info += $"<a href=\"DeleteContact.aspx?id={tmpContact.ID}\">Delete</a>\n";
                    info += " </td>\n";
                    info += "</tr>\n";
                }

                #region Some text 
                info += "</tbody>";
                info += "</table>";
                //info += "</div>";
                //info += "</div>";
                #endregion

                infoLiteral.Text = info;
            }
        }
    }
}