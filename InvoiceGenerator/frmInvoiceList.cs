using InvoiceGenerator.Helper;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace InvoiceGenerator
{
    public partial class frmInvoiceList : MetroForm
    {
        public static DateTime InvDate;
        public static DateTime InvStartDate;
        public static DateTime InvEndDate;

        public frmInvoiceList()
        {
            InitializeComponent();
        }
        private void frmInvoiceList_Load(object sender, EventArgs e)
        {
            BindGrid();
            if (UserSession.ShowPaidInvoice)
                this.Text = "Paid Invoice List";
            else
                this.Text = "Unpaid Invoice List";
        }

        #region Events
        private void Grid_InvoiceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(Grid_InvoiceList.CurrentRow.Cells["InvoiceID"].Value) != 0)
            {
                if (e.ColumnIndex == 0)
                {
                    frmInvoice.ID = Convert.ToInt32(Grid_InvoiceList.CurrentRow.Cells["InvoiceID"].Value);
                    frmInvoice ObjInv = new frmInvoice();
                    this.Close();
                    ObjInv.Show();
                    
                    //ShowData(frmInvoice.ID);
                }
                else if (e.ColumnIndex == 1)
                {
                    if (MessageBox.Show("Do you want to Delete this record. Confirm?", "Alet", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        frmInvoice.ID = Convert.ToInt32(Grid_InvoiceList.CurrentRow.Cells["InvoiceID"].Value);
                        DeleteData(frmInvoice.ID);
                        BindGrid();
                    }
                }
                else if (e.ColumnIndex == 2)
                {
                    int ID = Convert.ToInt32(Grid_InvoiceList.CurrentRow.Cells["InvoiceID"].Value);
                    UserSession.InvoiceID = ID;
                    frmReport objfrmReport = new frmReport();
                    objfrmReport.Show();
                }
                else if (e.ColumnIndex == 3)
                {
                    int ID = Convert.ToInt32(Grid_InvoiceList.CurrentRow.Cells["InvoiceID"].Value);
                    InvoiceEntities db = new InvoiceEntities();
                    tblInvoice objtblInvoice = db.tblInvoice.Find(ID);

                    if (!UserSession.ShowPaidInvoice)
                    {
                        string fileName = DateTime.Now.Millisecond+" - "+objtblInvoice.tblCustomer.CustomerName + " - Invoice.pdf";
                        CreatePDF(fileName, ID);

                        Email objEmail = new Email();
                        //Email to Customer
                        string message = "Find the attached invoice.<br/><br/>";
                        message += "<i>This is system generated email do no reply.</i>";

                        MailMessage mm = new MailMessage();
                        mm.Attachments.Add(new Attachment(fileName));
                        mm.From = new MailAddress(Helper.SystemParameter.DefaultFromAddress);
                        mm.To.Add(objtblInvoice.tblCustomer.Email);
                        string[] objBCCEmail = Helper.SystemParameter.BCCEmails.Split(',');
                        foreach (string item in objBCCEmail)
                        {
                            mm.Bcc.Add(item);
                        }
                        mm.Body = message;
                        mm.IsBodyHtml = true;
                        mm.Subject = "Invoice";

                        objEmail.Send(mm);

                        objtblInvoice.IsPaid = true;
                        db.SaveChanges();

                        if (objtblInvoice.IsPaid.HasValue)
                        {
                            if (!objtblInvoice.IsPaid.Value)
                                MessageBox.Show("Invoice has been sent and Marked as Paid.", "Success", MessageBoxButtons.OK);
                            else
                                MessageBox.Show("Invoice has been sent and Marked as Paid.", "Success", MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("Invoice has been sent and Marked as Paid.", "Success", MessageBoxButtons.OK);

                        //File.Delete(fileName);

                    }
                    //else
                    //{
                    //    objtblInvoice.IsPaid = false;
                    //    db.SaveChanges();

                    //    MessageBox.Show("Invoice has been Marked as Unpaid.", "Success", MessageBoxButtons.OK);
                    //}
                 
                }
                else if(e.ColumnIndex == 9)
                {
                    int ID = Convert.ToInt32(Grid_InvoiceList.CurrentRow.Cells["InvoiceID"].Value);
                    InvoiceEntities db = new InvoiceEntities();
                    tblInvoice objtblInvoice = db.tblInvoice.Find(ID);
                    objtblInvoice.IsPaid = true;
                    db.SaveChanges();

                    MessageBox.Show("Invoice has been Marked as Unpaid.", "Success", MessageBoxButtons.OK);
                    BindGrid();
                }
            }
        }

        private void CreatePDF(string fileName, int ID)
        {
            // Variables
            Warning[] warnings;
            string[] streamIds;
            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;


            // Setup the report viewer object and get the array of bytes
            ReportViewer viewer = new ReportViewer();
            InvoiceEntities db = new InvoiceEntities();
            ReportDataSource objReports = new ReportDataSource("CustomerInvoiceDS", db.VwInvoiceReport.Where(col => col.InvoiceID == ID).ToList());
            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.LocalReport.ReportPath = @"../../Report/CustomerInvoice.rdlc";
            viewer.LocalReport.DataSources.Add(objReports);

            byte[] bytes = viewer.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamIds, out warnings);

            System.IO.File.WriteAllBytes(fileName, bytes);
            // Now that you have all the bytes representing the PDF report, buffer it and send it to the client.
            //Response.Buffer = true;
            //Response.Clear();
            //Response.ContentType = mimeType;
            //Response.AddHeader("content-disposition", "attachment; filename=" + fileName + "." + extension);
            //Response.BinaryWrite(bytes); // create the file
            //Response.Flush(); // send it to the client to download
        }

        private string GetAdminMessageBody(tblInvoice objtblInvoice, List<tblInvoiceDetail> objtblInvoiceDetail)
        {
            string Message = "";
            Message += "Invoice detail: <br/><br/>";
            Message += "<b>Terms: </b>" + objtblInvoice.Terms+ "<br/>";
            Message += "<b>Amount: </b>" + objtblInvoice.TotalAmount.Value.ToString("#,##0.00") + "<br/>";
            Message += "<b>GST: </b>" + objtblInvoice.GST.Value.ToString("#,##0.00") + "<br/>";

            for (int i = 0; i < objtblInvoiceDetail.Count - 1; i++)
            {
                Message += "--------------------------------------------<br/>";
                Message += "<b>Description: </b> " + objtblInvoiceDetail[i].Description + "<br/>";
                Message += "<b>Service Start: </b> " + objtblInvoiceDetail[i].StartDate.Value.ToString("MMMM dd, yyyy") + "<br/>";
                Message += "<b>Service End: </b> " + objtblInvoiceDetail[i].EndDate.Value.ToString("MMMM dd, yyyy") + "<br/>";
                if(objtblInvoiceDetail[i].Amount.HasValue)
                    Message += "<b>Amount: </b> " + objtblInvoiceDetail[i].Amount.Value.ToString("#,##0.00") + "<br/>";
                else
                    Message += "<b>Amount: </b> 0<br/>";

                Message += "--------------------------------------------<br/>";
            }

            Message += "<i>This email is system generated doesn't reply on it.</i>";
            return Message;
        }

        #endregion

        #region Methods
        public void BindGrid()
        {

            using (InvoiceEntities cntx = new InvoiceEntities())
            {

                var Query = from a in cntx.VwInvoiceList where a.IsPaid == UserSession.ShowPaidInvoice select new { a.InvoiceID, a.InvoiceNo    , a.InvoiceDate, a.CustomerName, a.TotalAmount };
                
                Grid_InvoiceList.DataSource = Query.ToList();
                
            }

            if (UserSession.ShowPaidInvoice)
            {
                DataGridViewButtonColumn objbtn = (DataGridViewButtonColumn)Grid_InvoiceList.Columns[3];

                objbtn.HeaderText = "Paid Invoice";
                objbtn.Name = "btnpaid";
                objbtn.Text = "Paid Invoice";
                objbtn.UseColumnTextForButtonValue = true;
            }
            else
            {
                DataGridViewButtonColumn objBtn = new DataGridViewButtonColumn();
                objBtn.HeaderText = "Mark as Paid";
                objBtn.Name = "btnMarkPaid";
                objBtn.Text = "Mark as Paid";
                objBtn.UseColumnTextForButtonValue = true;
                Grid_InvoiceList.Columns.Add(objBtn);
            }
        }
        private void DeleteData(int ID)
        {
            using (InvoiceEntities cntx = new InvoiceEntities())
            {
                var Query = (from a in cntx.tblInvoiceDetail where a.InvoiceID == ID select a).ToList();
                for (int i = 0; i < Query.Count; i++)
                {
                    cntx.tblInvoiceDetail.RemoveRange(Query);
                }
                var Query3 = (from a in cntx.tblInvoice where a.InvoiceID == ID select a).FirstOrDefault();
                cntx.tblInvoice.Remove(Query3);
                cntx.SaveChanges();
            }
        }
        private void ShowData(int ID)
        {
            using (InvoiceEntities cntx = new InvoiceEntities())
            {
                var Query = (from c in cntx.tblInvoice where c.InvoiceID == ID select c).FirstOrDefault();
                InvDate = Convert.ToDateTime(Query.InvoiceDate);

                var Query2 = (from c in cntx.tblInvoiceDetail where c.InvoiceID == ID select c).FirstOrDefault();
                InvStartDate = Convert.ToDateTime(Query2.StartDate);
                InvEndDate = Convert.ToDateTime(Query2.EndDate);

                frmInvoice ObjInv = new frmInvoice();
                ObjInv.Show();

            }
        }


        #endregion
    }
}



