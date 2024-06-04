using RAiso1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso1.Views
{
    public partial class EditStationery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void UpdateButton_Click(object sender, EventArgs e) 
        {
            string name = NameTB.Text.ToString();
            int price = Convert.ToInt32(PriceTB.Text.ToString());
            Message.Text = StationeryController.editStationery(Convert.ToInt32(Request.QueryString["ID"]), name, price);
            if(Message.Text == "updated successfully")
            {
                Response.Redirect("~/Views/Home.aspx");
            }
        }
    }
}