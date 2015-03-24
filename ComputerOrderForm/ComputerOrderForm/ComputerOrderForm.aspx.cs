using ComputerOrderForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComputerOrderForm
{
    public partial class ComputerOrderForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //created an order variable to represent the ComputerOrder class to access its properites 
            var order = new ComputerOrder();
            //Usually for the ID this would be connected up to a database with a table ID. I am not doing that here but should in real practice
            order.OrderId = 101;
            order.OrderName = OrderName.Text;
            order.Customer = Customer.Text;
            order.CustomerEmail = CustomerEmail.Text;
            order.DeliveryDate = DeliveryDate.SelectedDate;
            order.PartNumber = int.Parse(PartNumber.Text); //parsing the text into an int for the order property 
            order.Rush = RushYes.Checked;
            //Stashing in Session State - preserve the data during the session 
            Session["CurrentOrder"] = order;
            //after submitting the computer order, the user will be redirected to the read only review page
            Response.Redirect("ReviewComputerOrder.aspx");
        }
    }
}