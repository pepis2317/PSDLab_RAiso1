using RAiso1.Factories;
using RAiso1.Handlers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Controllers
{
    public class CartController
    {
        public static string insertCart(int userID, int stationeryID, int quantity)
        {
            if (quantity <= 0)
            {
                return "quantity must be greater than 0";
            }
            Cart c = CartFactory.Create(userID, stationeryID, quantity);
            CartHandler.insertCart(c);
            return "cart inserted";

        }
        public static List<Cart> getCart(int userID)
        {
            return CartHandler.getCarts(userID);
        }
        public static Cart getSpecificCart(int userID, int stationeryID)
        {
            return CartHandler.getSpecificCart(userID, stationeryID);
        }
        public static string updateCart(int userID, int stationeryID, int quantity)
        {
            if (quantity > 0)
            {
                Cart c = CartHandler.getSpecificCart(userID, stationeryID);
                c.Quantity = quantity; 
                CartHandler.updateCart(c);
                return "cart updated";
            }
            return "quantity must be greater than 0";
        }
    }
}