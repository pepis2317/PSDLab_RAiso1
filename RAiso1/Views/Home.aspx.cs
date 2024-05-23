using RAiso1.Handlers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
namespace RAiso1.Views
{
    public partial class Home : System.Web.UI.Page
    {
        public List<Stationery> stationeries = null;
        void updateStationeries()
        {
            stationeries = StationeryHandler.getStationeries();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            updateStationeries();
        }
    }
}