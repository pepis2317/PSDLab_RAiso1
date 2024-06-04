using RAiso1.Controllers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso1.Views
{
    public partial class StationeryDetail : System.Web.UI.Page
    {
        protected bool IsLoggedIn = false;
        protected Stationery s;
        protected Cart c;
        protected void Page_Load(object sender, EventArgs e)
        {
            User loggedUser = UserController.getLoggedUser();
            string stationeryID = Request.QueryString["ID"];
            c = CartController.getSpecificCart(loggedUser.UserID, Convert.ToInt32(stationeryID));
            if (c != null)
            {
                Response.Redirect($"~/Views/EditCart.aspx?ID={loggedUser.UserID}");
            }
            if (loggedUser!= null &&( loggedUser.Role == "Customer" || loggedUser.Role == "Admin") )
            {
                IsLoggedIn = true;
                if(loggedUser.Role == "Customer")
                {
                    CommsPlaceholder.Visible = true;
                }
                else
                {
                    CommsPlaceholder.Visible = false;
                }
            }
            if (!IsLoggedIn)
            {
                Response.Redirect("~/Views/Login.aspx");
            }
              
            s = StationeryController.getStationeryByID(Convert.ToInt32(stationeryID));
            NameLabel.Text = s.Name;
            PriceLabel.Text = s.Price.ToString();
        }

        protected void IncreaseButton_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Counter.Text);
            Counter.Text = (count + 1).ToString();
        }

        protected void DecreaseButton_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Counter.Text);
            if(count > 0 )
            {
                Counter.Text = (count - 1).ToString();
            }
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            Message.Text = CartController.insertCart(UserController.getLoggedUser().UserID, s.StationeryID, Convert.ToInt32(Counter.Text));
            if(Message.Text == "cart inserted")
            {
                Response.Redirect("~/Views/Home.aspx");
            }
        }
    }
}