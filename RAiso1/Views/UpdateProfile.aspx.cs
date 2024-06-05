using RAiso1.Controllers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso1.Views
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        User u;
        protected void Page_Load(object sender, EventArgs e)
        {
            u = UserController.getLoggedUser();
            if(u == null)
            {
                Response.Redirect("~/Views/Login.aspx");
            }
            UsernameTB.Text = u.Username;
            PasswordTB.Text = u.Password;
            GenderDD.Text = u.Gender;
            PhoneTB.Text = u.Phone;
            AddressTB.Text = u.Address;
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            String username = UsernameTB.Text.ToString();
            String password = PasswordTB.Text.ToString();
            String gender = GenderDD.Text.ToString();
            String phone = PhoneTB.Text.ToString();
            String address = AddressTB.Text.ToString();
            DateTime dob = DobCalendar.SelectedDate;
            Message.Text = UserController.updateUser(u.UserID,username, password, gender, phone, address, dob);
            if (Message.Text == (username + " has been updated"))
            {
                Session["User"] = username;
                HttpCookie cookie = Request.Cookies["User_Cookie"];
                if (cookie != null)
                {
                    cookie.Value = username;
                }
                Response.Redirect("~/Views/Home.aspx");
            }
        }
    }
}