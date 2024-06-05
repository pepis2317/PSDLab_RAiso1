using RAiso1.Factories;
using RAiso1.Handlers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Controllers
{
    public class UserController
    {
        public static string registerUser(string username, string password, string gender, string phone, string address, DateTime dob)
        {
            if(username != null && password != null && gender != null && phone !=null && address !=null && dob != null){
                if(username.Length < 5 || username.Length > 50)
                {
                    return "username must be between 5 and 50";
                }
                if (UserHandler.getUserByName(username) != null)
                {
                    return "username must be unique";
                }
                if (!password.All(char.IsLetterOrDigit))
                {
                    return "password must be alphanumeric";
                }
                if (!phone.All(char.IsDigit))
                {
                    return "phone must only contain digits";
                }
                DateTime oneYearAgo = DateTime.Now.AddYears(-1);
                if (dob > oneYearAgo)
                {
                    return "date of birth must be at least one year ago";
                }
                User user = UserFactory.create(username, dob, address, gender, phone, password);
                UserHandler.registerUser(user);
                UserHandler.loggedUser = user;
                return username + " has been registered";
            }
            return "all fields must be filled";
        }
        public static string updateUser(int id, string username, string password, string gender, string phone, string address, DateTime dob)
        {
            if (username != null && password != null && gender != null && phone != null && address != null && dob != null)
            {
                if (username.Length < 5 || username.Length > 50)
                {
                    return "username must be between 5 and 50";
                }
                if (UserHandler.getUserByName(username).Username!=username&&UserHandler.getUserByName(username) != null)
                {
                    return "username must be unique";
                }
                if (!password.All(char.IsLetterOrDigit))
                {
                    return "password must be alphanumeric";
                }
                if (!phone.All(char.IsDigit))
                {
                    return "phone must only contain digits";
                }
                DateTime oneYearAgo = DateTime.Now.AddYears(-1);
                if (dob > oneYearAgo)
                {
                    return "date of birth must be at least one year ago";
                }
                User user = UserHandler.getUserByID(id);
                user.Username = username;
                user.Password = password;
                user.Gender = gender;
                user.Phone = phone;
                user.Address = address;
                user.DOB = dob;
                UserHandler.updateUser(user);

                return username + " has been updated";
            }
            return "all fields must be filled";
        }
        public static string loginUser(string username, string password)
        {
            if (username != null && password != null)
            {
                if(UserHandler.getUserLogin(username, password) == null)
                {
                    return "invalid user credentials";
                }
                User user = UserHandler.getUserLogin(username, password);
                UserHandler.loggedUser = user;
                return username + " has been logged in";
            }
            return "all fields must be filled";
        }
        
        public static void logOutUser()
        {
            UserHandler.loggedUser = null;
        }
        public static User getLoggedUser()
        {
            return UserHandler.loggedUser;
        }
    }

}