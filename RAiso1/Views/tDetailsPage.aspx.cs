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
    public partial class tDetailsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<TransactionDetail> tdl = TransactionDetailsController.getTransactionDetailsByID(Convert.ToInt32(Request.QueryString["ID"]));
                CartRepeater.DataSource = tdl;
                CartRepeater.DataBind();
            }

        }
        protected string GetStationeryName(object dataItem)
        {
            var transactionDetail = dataItem as TransactionDetail;
            return transactionDetail?.Stationery?.Name ?? "Stationery is null";
        }

        protected string GetStationeryPrice(object dataItem)
        {
            var transactionDetail = dataItem as TransactionDetail;
            return transactionDetail?.Stationery?.Price.ToString("C") ?? "Price is null";
        }
    }
}