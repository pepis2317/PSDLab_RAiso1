using RAiso1.Controllers;
using RAiso1.Models;
using RAiso1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace RAiso1.Views
{
    public partial class EditCart : System.Web.UI.Page
    {
        protected Stationery s;
        protected Cart c;
        protected User u;
        protected void Page_Load(object sender, EventArgs e)
        {
            u = UserController.getLoggedUser();
            s = StationeryController.getStationeryByID(Convert.ToInt32(Request.QueryString["ID"]));
            c = CartController.getSpecificCart(u.UserID, Convert.ToInt32(Request.QueryString["ID"]));
            if (!IsPostBack)
            {
                NameLabel.Text = s.Name;
                PriceLabel.Text = s.Price.ToString();
                Counter.Text = c.Quantity.ToString();
            }
           
        }

        protected void DecreaseButton_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Counter.Text);
            if (count > 0)
            {
                Counter.Text = (count - 1).ToString();
            }
        }

        protected void IncreaseButton_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Counter.Text);
            Counter.Text = (count + 1).ToString();
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            Message.Text = CartController.updateCart(u.UserID, s.StationeryID, Convert.ToInt32(Counter.Text));
            if(Message.Text == "cart updated")
            {
                Response.Redirect($"~/Views/Carts.aspx?ID={u.UserID}");
            }
        }
    }
}