using RAiso1.Controllers;
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
            String gender = GenderDD.Text.ToString();
            String phone = PhoneTB.Text.ToString() ;
            String address = AddressTB.Text.ToString() ;
            DateTime dob = DobCalendar.SelectedDate;
            Message.Text = UserController.registerUser(username, password, gender, phone, address, dob);
            if (Message.Text == (username + " has been registered"))
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