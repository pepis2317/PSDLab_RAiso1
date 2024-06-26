﻿using RAiso1.Factories;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Repositories
{
    public class CartRepository
    {
        static RAisoDBEntities db = DBSingleton.getInstance();
        public static List<Cart> getCarts()
        {
            return (from cart in db.Carts select cart).ToList();
        }
        public static Cart getSpecificCart(int userID, int stationeryID)
        {
            return (from cart in db.Carts where cart.UserID == userID && cart.StationeryID == stationeryID select cart).FirstOrDefault();
        }
        public static List<Cart> getCartByUserID(int userID)
        {
            return (from cart in db.Carts where cart.UserID == userID select cart).ToList();
        }
        public static void insertCart(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();

        }
        public static void deleteCarts(int userID)
        {
            List<Cart> carts = getCartByUserID(userID);
            foreach(Cart c in carts)
            {
                db.Carts.Remove(c);
            }
            
            db.SaveChanges();
        }
        public static void deleteCart(Cart cart)
        {
            db.Carts.Remove(cart);
            db.SaveChanges();
        }
        public static void updateCart(Cart cart)
        {
            Cart c = getSpecificCart(cart.UserID, cart.StationeryID);
            cart.Quantity = c.Quantity;
            db.SaveChanges();
        }
    }
}