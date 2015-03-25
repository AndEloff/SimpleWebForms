using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //assigned local bool var for check box var
            bool ssd = SSD.Checked;
            bool ram = SixteenGB.Checked;
            bool dual = DualMonitor.Checked;
            //Set the text using the tunary operator and setting the text to blank if the bool is false
            Msg2.Text = "<br /> You Selected: ";
            Msg2.Text += ssd ? "SSD Drive " : "";
            Msg2.Text += ram ? " 16GB RAM " : "";
            Msg2.Text += dual ? " Duel Monitors" : "";

            //check box list
            //Iterate through all the check box list items and if its checked we add it to the message text
            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    //taking hte list item and taking its value and coverting it to a string
                    Message.Text += li.Value.ToString();
                }
            }

            //radio buttons
            Message.Text = "<br /> The customer is: ";
            //Since there is only 2 values I was able to say its going to be Male OR Female
            Message.Text += Male.Checked ? "Male was selected" : "Female";
            Message.Text += "<br /> Your age group is: ";

            //radio list items
            foreach (ListItem li in RadioButtonList1.Items)
            {
                if (li.Selected)
                {
                    //if the radio button is selected, append the value we get from that list item
                    Message.Text += li.Value.ToString() + ". ";
                }
            }

            //dropdown list
            Message.Text += "<br /> You Selected: ";
            Message.Text += DropDownList1.SelectedValue.ToString();
        }
    }
}