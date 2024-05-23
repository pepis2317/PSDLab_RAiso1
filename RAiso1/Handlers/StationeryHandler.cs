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
        public void insertStationery(Stationery stationery)
        {
            StationeryRepository.insertStationery(stationery);
        }
    }
}