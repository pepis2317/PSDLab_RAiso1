using RAiso1.Models;
using RAiso1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Handlers
{
    public class StationeryHandler
    {
        public static List<Stationery> getStationeries()
        {
            return StationeryRepository.getStationeries();
        }
        public static void insertStationery(Stationery stationery)
        {
            StationeryRepository.insertStationery(stationery);
        }
        public static Stationery getStationeryByID(int id)
        {
            return StationeryRepository.getStationery(id);
        }
        public static void editStationery(Stationery stationery)
        {
            StationeryRepository.updateStationery(stationery);
        }
        public static int getLatestID()
        {
            return StationeryRepository.getLatestID();
        }
    }
}