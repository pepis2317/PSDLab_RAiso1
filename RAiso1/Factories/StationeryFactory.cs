using RAiso1.Handlers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Factories
{
    public class StationeryFactory
    {
        public static Stationery Create(string name, int price)
        {
            Stationery stationery = new Stationery();
            stationery.StationeryID = StationeryHandler.getLatestID() + 1;
            stationery.Name = name;
            stationery.Price = price;
            return stationery;
        }
    }
}