using ComputerOrderForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComputerOrderForm
{
    public partial class ReviewComputerOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // created order varaible to retreive the Session state CurrentOrder and setting it as type Computer Order
            //General Overview:
            //Created order to represent the Session of Current Order
            //to allow the data in the current session to be binded to the read only text fields on the review page
            ComputerOrder order = Session["CurrentOrder"] as ComputerOrder;
            OrderNumber.Text = order.OrderId.ToString();
            OrderName.Text = order.OrderName;
            Customer.Text = order.Customer;
            CustomerEmail.Text = order.CustomerEmail;
            DeliveryDate.Text = order.DeliveryDate.ToShortDateString();
            PartNumber.Text = order.PartNumber.ToString();
            RushOrder.Text = order.Rush == true ? "Yes" : "No";

            //TODO: Create a button to process a new order
        }
    }
}