using RAiso1.Handlers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Factories
{
    public class CartFactory
    {
        public static Cart Create(int userID, int stationeryID, int quantity)
        {
            Cart cart = new Cart();
            cart.UserID = userID;
            cart.StationeryID = stationeryID;
            cart.Quantity = quantity;
            return cart;
        }
    }
}