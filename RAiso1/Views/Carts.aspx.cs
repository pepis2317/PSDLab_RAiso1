using RAiso1.Controllers;
using RAiso1.Factories;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso1.Views
{
    public partial class Carts : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Cart> carts = CartController.getCart(Convert.ToInt32(Request.QueryString["ID"]));
                CartRepeater.DataSource = carts;
                CartRepeater.DataBind();
            }
        }
        protected void Cart_Command(object sender, CommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();
            if (e.CommandName == "Remove")
            {
                CartController.deleteCart(Convert.ToInt32(Request.QueryString["ID"]), Convert.ToInt32(id));
                Response.Redirect($"~/Views/Carts.aspx?ID={Request.QueryString["ID"]}");

            }
            else if (e.CommandName == "Update")
            {
                System.Diagnostics.Debug.WriteLine($"Edit {id}");
                Response.Redirect($"~/Views/EditCart.aspx?ID={id}");
            }
        }

        protected void CheckoutButton_Click(object sender, EventArgs e)
        {
            List<Cart> carts = CartController.getCart(Convert.ToInt32(Request.QueryString["ID"]));
            int transactionID = TransactionHeaderController.insertTransactionHeader(Convert.ToInt32(Request.QueryString["ID"]));

            foreach (Cart c in carts)
            {
                TransactionDetailsController.insertTransactionDetail(transactionID, c.StationeryID, c.Quantity);
            }
            Message.Text = CartController.deleteCarts(Convert.ToInt32(Request.QueryString["ID"]));
            if (Message.Text == "carts deleted")
            {
                Response.Redirect("~/Views/Home.aspx");
            }
        }
    }
}