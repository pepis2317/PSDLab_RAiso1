using RAiso1.Handlers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Factories
{
    public class UserFactory
    {
        public static User create(string Username, DateTime DOB, string Address, string Gender, string Phone, string Password)
        {
            User user = new User();
            user.UserID = UserHandler.getLatestUserID() + 1;
            user.Username = Username;
            user.Gender = Gender;
            user.DOB = DOB;
            user.Phone = Phone;
            user.Password = Password;
            user.Address = Address;
            if (Username.StartsWith("Admin_"))
            {
                user.Role = "Admin";
            }
            else
            {
                user.Role = "Customer";
            }
            return user;
        }
    }
}