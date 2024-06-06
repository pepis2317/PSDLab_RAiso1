using RAiso1.Controllers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso1.Views
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<TransactionHeader>  thl = TransactionHeaderController.GetTransactionHeadersByUserID(UserController.getLoggedUser().UserID);
                CartRepeater.DataSource = thl;
                CartRepeater.DataBind();
            }
        }

        protected void DetailsButton_Command(object sender, CommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();
            if (e.CommandName == "Details")
            {
                Response.Redirect($"~/Views/tDetailsPage.aspx?ID={id}");
            }
        }
    }
}