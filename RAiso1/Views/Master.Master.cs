using Microsoft.Win32;
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
                TransactionsButton.Visible = false;
                UpdateButton.Visible = false;
            }
            else
            {
                LoginButton.Visible = false;
                RegisterButton.Visible = false;
                TransactionsButton.Visible = true;
                UpdateButton.Visible = true;
                LogoutButton.Visible = true;
                if (UserHandler.loggedUser.Role == "Customer")
                {
                    CartButton.Visible = true;
                }
                else
                {
                    CartButton.Visible = false;
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
    }
}