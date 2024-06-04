using RAiso1.Controllers;
using RAiso1.Handlers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
namespace RAiso1.Views
{
    public partial class Home : System.Web.UI.Page
    {
        //protected List<Stationery> stationeries = null;
        protected bool IsAdmin = false;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            User loggedUser = UserController.getLoggedUser();

            if (loggedUser!= null && loggedUser.Role == "Admin")
            {
                IsAdmin = true;
            }
            if (!IsPostBack)
            {
                // Bind data to the Repeater
                var stationeries = StationeryController.getStationeries();
                StationeryRepeater.DataSource = stationeries;
                StationeryRepeater.DataBind();
            }
        }
        protected void Stationery_Command(object sender, CommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();
            if (e.CommandName == "Delete")
            {
                System.Diagnostics.Debug.WriteLine($"Delete {id}");
            }
            else if (e.CommandName == "Edit")
            {
                System.Diagnostics.Debug.WriteLine($"Edit {id}");
                Response.Redirect($"~/Views/EditStationery.aspx?ID={id}");
            }
            else if (e.CommandName == "Details")
            {
                Response.Redirect($"~/Views/StationeryDetails.aspx?ID={id}");
            }
        }

    }
}