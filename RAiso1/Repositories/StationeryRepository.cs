using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Repositories
{
    public class StationeryRepository
    {
        static RAisoDBEntities db = DBSingleton.getInstance();
        public static List<Stationery> getStationeries()
        {
            return (from s in db.Stationeries select s).ToList();
        }
        public static Stationery getStationery(int id)
        {
            return (from s in db.Stationeries where s.StationeryID == id select s).FirstOrDefault();
        }
        public static void insertStationery(Stationery s)
        {
            db.Stationeries.Add(s);
            db.SaveChanges();
        }
        public static void updateStationery(Stationery s)
        {
            Stationery stationery = getStationery(s.StationeryID);
            stationery.Price = s.Price;
            stationery.Name = s.Name;
            db.SaveChanges();
        }
        public static void deleteStationery(Stationery s)
        {
            db.Stationeries.Remove(s);
            db.SaveChanges();
        }
        public static int getLatestID()
        {
            return (from s in db.Stationeries orderby s.StationeryID descending select s.StationeryID).FirstOrDefault();
        }
    }
}