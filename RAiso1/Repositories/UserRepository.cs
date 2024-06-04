using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Repositories
{
    public class UserRepository
    {
        static RAisoDBEntities db = DBSingleton.getInstance();
        public static int getLatestUserID()
        {
            return (from user in db.Users orderby user.UserID descending select user.UserID).FirstOrDefault();
        }
        public static List<User> getUsers()
        {
            return (from user in db.Users select user).ToList();
        }
        public static User getUserByID(int id)
        {
            return (from user in db.Users where user.UserID == id select user).FirstOrDefault();
        }
        public static User getUserLogin(string username, string password)
        {
            return (from user in db.Users where user.Username == username && user.Password == password select user).FirstOrDefault();
        }
        public static User getUserByName(string username)
        {
            return (from user in db.Users where user.Username == username select user).FirstOrDefault();

        }
        public static void updateUser(User user)
        {
            User foundUser = getUserByID(user.UserID);
            foundUser.Username = user.Username;
            foundUser.Gender = user.Gender;
            foundUser.DOB = user.DOB;
            foundUser.Phone = user.Phone;
            foundUser.Address = user.Address;
            foundUser.Password = user.Password;
            foundUser.Role = user.Role;
            db.SaveChanges();
        }
        public static void registerUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}