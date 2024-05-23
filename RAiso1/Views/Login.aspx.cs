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
            User user = UserHandler.getUserLogin(username, password);
            if (user == null)
            {
                LoginWarning.Text = "User Not Found";
            }
            else
            {
                if (Remember.Checked)
                {
                    HttpCookie cookie = new HttpCookie("User_Cookie");
                    cookie.Value = user.UserID.ToString();
                    cookie.Expires = DateTime.Now.AddHours(6);
                    Response.Cookies.Add(cookie);
                }
                Session["User"] = user.UserID;
                UserHandler.loggedUser = user;
                Response.Redirect("~/Views/Home.aspx");
            }
        }
    }
}