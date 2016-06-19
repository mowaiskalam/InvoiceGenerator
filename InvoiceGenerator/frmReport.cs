using InvoiceGenerator.Helper;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace InvoiceGenerator
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            InvoiceEntities db = new InvoiceEntities();
            ReportDataSource objReports = new ReportDataSource("CustomerInvoiceDS", db.VwInvoiceReport.Where(col => col.InvoiceID == UserSession.InvoiceID).ToList());
            this.reportViewer.LocalReport.ReportPath = @"../../Report/CustomerInvoice.rdlc";
            this.reportViewer.LocalReport.DataSources.Add(objReports);
            this.reportViewer.RefreshReport();            
        }
    }
}
