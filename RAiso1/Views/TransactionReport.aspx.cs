using RAiso1.Controllers;
using RAiso1.Dataset;
using RAiso1.Models;
using RAiso1.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso1.Views
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            DataSet1 data = getData(TransactionHeaderController.getTransactionHeaders());
            report.SetDataSource(data);
        }
        private DataSet1 getData(List<TransactionHeader> thl)
        {
            DataSet1 data = new DataSet1();
            var headertable = data.TransactionHeader;
            var detailtable = data.TransactionDetail;
            foreach ( var t in thl )
            {
                var hrow = headertable.NewRow();
                hrow["TransactionID"] = t.TransactionID;
                hrow["UserID"] = t.UserID;
                hrow["TransactionDate"] = t.TransactionDate;
                headertable.Rows.Add(hrow);

                foreach(TransactionDetail d in t.TransactionDetails)
                {
                    Stationery s = StationeryController.getStationeryByID(d.StationeryID);
                    string name = "";
                    int price = 0;
                    if(s != null)
                    {
                        name = s.Name;
                        price = s.Price;
                    }
                    var drow = detailtable.NewRow();
                    drow["TransactionID"] = d.TransactionID;
                    drow["StationeryName"] = name;
                    drow["Quantity"] = d.Quantity;
                    drow["StationeryPrice"] = price;
                    drow["SubTotal"] = d.Quantity * price;
                    detailtable.Rows.Add(drow);
                }
            }
            return data;
        }
    }
}