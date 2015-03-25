using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionVApplicationState
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            Session["Name"] = UserName.Text; //Session is tied to a particular browser
            Application["Email"] = UserEmail.Text; //Application is tied to the entire application KEY DIFFERENCE between Session
            NameAndEmail.Text = UserName.Text + " " + UserEmail.Text;
        }

        protected void RetrieveBtn_Click(object sender, EventArgs e)
        {
            string name = "";
            string email = "";

            if (Session["Name"] != null)
            {
                name = Session["Name"].ToString();
            }

            if (Application["Email"] != null)
            {
                email = Application["Email"].ToString();
            }

            RetrieveNameAndEmail.Text = "Retrieved: " + name + " " + email; 
        }
    }
}