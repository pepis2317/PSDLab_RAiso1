using RAiso1.Models;
using RAiso1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Handlers
{
    public class UserHandler
    {
        public static User loggedUser = null;
        public static int getLatestUserID()
        {
            return UserRepository.getLatestUserID();
        }
        public static List<User> getUsers()
        {
            return UserRepository.getUsers();
        }
        public static User getUserLogin(string username, string password)
        {
            return UserRepository.getUserLogin(username, password);
        }
        public static User getUserByID(int id)
        {
            return UserRepository.getUserByID(id);
        }
        public static User getUserByName(string name)
        {
            return UserRepository.getUserByName(name);
        }
        public static void updateUser(User user)
        {
            UserRepository.updateUser(user);
        }
        public static void registerUser(User user)
        {
            UserRepository.registerUser(user);
        }
    }
}