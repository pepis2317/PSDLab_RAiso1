using Microsoft.Win32;
using RAiso1.Controllers;
using RAiso1.Handlers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Util;

namespace RAiso1.Views
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserHandler.loggedUser == null)
            {
                LogoutButton.Visible = false;
                CartButton.Visible = false;
                TransactionHistoryButton.Visible = false;
                UpdateButton.Visible = false;
                InsertButton.Visible = false;
                TransactionReportButton.Visible = false;
            }
            else
            {
                LoginButton.Visible = false;
                RegisterButton.Visible = false;
                UpdateButton.Visible = true;
                LogoutButton.Visible = true;
                if (UserHandler.loggedUser.Role == "Customer")
                {
                    CartButton.Visible = true;
                    InsertButton.Visible = false;
                    TransactionHistoryButton.Visible = true;
                    TransactionReportButton.Visible = false;
                }
                else
                {
                    CartButton.Visible = false;
                    InsertButton.Visible = true;
                    TransactionHistoryButton.Visible = false;
                    TransactionReportButton.Visible = true;
                }
            }

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Home.aspx");
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Register.aspx");
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Session["User"] = null;
            Response.Cookies["User_Cookie"].Expires = DateTime.Now.AddDays(-1);
            UserController.logOutUser();
            Response.Redirect("~/Views/Home.aspx");
        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertStationery.aspx");
        }

        protected void CartButton_Click(object sender, EventArgs e)
        {
            Response.Redirect($"~/Views/Carts.aspx?ID={UserController.getLoggedUser().UserID}");

        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/UpdateProfile.aspx");
        }

        protected void TransactionHistoryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/TransactionHistory.aspx");
        }

        protected void TransactionReportButton_Click(object sender, EventArgs e)
        {

        }
    }
}