using RAiso1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso1.Views
{
    public partial class Carts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var carts = CartController.getCart(Convert.ToInt32(Request.QueryString["ID"]));
                CartRepeater.DataSource = carts;
                CartRepeater.DataBind();
            }
        }
        protected void Cart_Command(object sender, CommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();
            if (e.CommandName == "Delete")
            {
                System.Diagnostics.Debug.WriteLine($"Delete {id}");
            }
            else if (e.CommandName == "Update")
            {
                System.Diagnostics.Debug.WriteLine($"Edit {id}");
                Response.Redirect($"~/Views/EditCart.aspx?ID={id}");
            }
        }
    }
}