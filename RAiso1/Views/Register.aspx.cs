using RAiso1.Factories;
using RAiso1.Handlers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso1.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            String username = UsernameTB.Text.ToString();
            String password = PasswordTB.Text.ToString();
            String gender = GenderTB.Text.ToString() ;
            String phone = PhoneTB.Text.ToString() ;
            String address = AddressTB.Text.ToString() ;
            DateTime dob = DobCalendar.SelectedDate;
            User user = UserFactory.create(username, dob, address, gender, phone, password);
            UserHandler.registerUser(user);
            Session["User"] = user.UserID;
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