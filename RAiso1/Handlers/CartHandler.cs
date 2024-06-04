using RAiso1.Models;
using RAiso1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Handlers
{
    public class CartHandler
    {
        public static void insertCart(Cart cart)
        {
            CartRepository.insertCart(cart);
        }
        public static List<Cart> getCarts(int userID)
        {
            return CartRepository.getCartByUserID(userID);
        }
        public static Cart getSpecificCart(int userID, int stationeryID)
        {
            return CartRepository.getSpecificCart(userID, stationeryID);
        }
        public static void updateCart(Cart cart) 
        {
            CartRepository.updateCart(cart);
        }
    }
}