using RAiso1.Controllers;
using RAiso1.Handlers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso1.Views
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            String username = UsernameTB.Text.ToString();
            String password = PasswordTB.Text.ToString();
            Message.Text = UserController.loginUser(username, password);
            if(Message.Text == (username + " has been logged in"))
            {
                Session["User"] = username;
                if (Remember.Checked)
                {
                    HttpCookie cookie = new HttpCookie("User_Cookie");
                    cookie.Value = username;
                    cookie.Expires = DateTime.Now.AddHours(6);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("~/Views/Home.aspx");
            }
        }
    }
}