using RAiso1.Factories;
using RAiso1.Handlers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace RAiso1.Controllers
{
    public class StationeryController
    {
        public static List<Stationery> getStationeries()
        {
            return StationeryHandler.getStationeries();
        }
        public static string insertStationery(string name, int price)
        {
            if (name != null)
            {
                if (price < 2000)
                {
                    return "price must be greater or equal to 2000";
                }
                Stationery s = StationeryFactory.Create(name, price);
                StationeryHandler.insertStationery(s);
                return "inserted successfully";
            }
            return "all fields must be filled";
        }
        public static string editStationery(int id, string name, int price)
        {
            if(name!=null)
            {
                if(price < 2000)
                {
                    return "price must be greater or equal to 2000";
                }
                Stationery s = StationeryHandler.getStationeryByID(id);
                s.Name = name;
                s.Price = price;
                StationeryHandler.editStationery(s);
                return "updated successfully";
            }
            return "all fields must be filled";
        }
        public static Stationery getStationeryByID(int id)
        {
            return StationeryHandler.getStationeryByID(id);
        }
        public static void deleteStationery(int stationeryID)
        {
            StationeryHandler.deleteStationery(stationeryID);
        }
    }
}