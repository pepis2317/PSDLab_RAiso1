using CrystalDecisions.Shared;
using RAiso1.Dataset;
using RAiso1.Models;
using RAiso1.Report;
using RAiso1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso1.Views
{
    public partial class TransactionReportPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TransactionReport report = new TransactionReport();
            CrystalReportViewer1.ReportSource = report;

            List<TransactionHeader> transactions = TransactionHeaderRepository.getTransactionHeaders();
            List<TransactionDetail> details = TransactionDetailRepository.getTransactionDetails();
            List<Stationery> stationeries = StationeryRepository.getStationeries();

            report.SetDataSource(CrystalReportViewer1.ReportSource);

        }

        private DataSet GetData(List<TransactionHeader> transactions, List<TransactionDetail> details, List<Stationery> stationeries)
        {
            DataSet data = new DataSet();
            var headertable = data.TransactionHeader;
            var detailtable = data.TransactionDetail;
            
            foreach ( var t in transactions )
            {
                var hrow = headertable.NewRow();
                hrow["TransactionID"] = t.TransactionID;
                hrow["UserID"] = t.UserID;
                hrow["TransactionDate"] = t.TransactionDate;
                
                headertable.Rows.Add( hrow );

                foreach(var d in details)
                {
                    var drow = detailtable.NewRow();
                    drow["TransactionID"] = d.TransactionID;

                    var stationery = stationeries.FirstOrDefault(s => s.StationeryID == d.StationeryID);
                    if (stationery != null)
                    {
                        drow["Name"] = stationery.Name;
                        drow["Quantity"] = d.Quantity;
                        drow["Price"] = stationery.Price;
                        drow["Subtotal"] = d.Quantity * stationery.Price;
                        detailtable.Rows.Add(drow);
                    }
                }
            }
            return data;
        }
    }
}