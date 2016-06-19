using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvoiceGenerator;
using MetroFramework.Controls;
using InvoiceGenerator.Helper;

namespace InvoiceGenerator
{
    public partial class frmInvoice : MetroForm
    {
        public static int ID;
        decimal Gst;
        
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            FillColumn();
            if (ID != 0)
            {
                ShowData(ID);
            }
            BindCombo();
            Grid_Invoice.AutoGenerateColumns = false;
        }

        public DataTable CurrentData { get; set; }

        public void FillColumn()
        {
            CurrentData = new DataTable();
            CurrentData.Columns.Add("InvoiceDetailID");
            CurrentData.Columns.Add("Description");
            CurrentData.Columns.Add("StartDate");
            CurrentData.Columns.Add("EndDate");
            CurrentData.Columns.Add("Amount");
        }

        #region Events
        private void btn_AddMore_Click(object sender, EventArgs e)
        {
            if (txt_Amount.Text != "")
            {
                decimal TotalAmount = Convert.ToDecimal(txt_Amount.Text);
                //DataTable dt = Grid_Invoice.DataSource as DataTable;
                //Create the new row
                DataRow row = CurrentData.NewRow();

                row[0] = "0";
                row[1] = cmbDescription.Text;
                row[2] = dtp_StartDate.Value.ToShortDateString();
                row[3] = dtp_EndDate.Value.ToShortDateString();
                row[4] = "$ "+ txt_Amount.Text;

                //Add the row to data table
                CurrentData.Rows.Add(row);

                Grid_Invoice.DataSource = CurrentData;

                //Grid_Invoice.Rows.Insert(0, txt_Des.Text, dtp_StartDate.Value.ToShortDateString(), dtp_EndDate.Value.ToShortDateString(), txt_Amount.Text);
                decimal sum = 0;
                for (int i = 0; i < CurrentData.Rows.Count; i++)
                {
                    if (CurrentData.Rows[i][4].ToString() != null)
                    {
                        sum += Convert.ToDecimal(CurrentData.Rows[i][4].ToString().Replace("$ ",""));
                    }
                }
                lbl_TotalAmount.Text = "$ "+ sum.ToString();
                Gst = Convert.ToDecimal(sum) * 10 / 100;
                lbl_GST.Text = "$ "+ Gst.ToString();
                Clear();
            }
            else
            {
                MessageBox.Show("Please enter Description or Amount");
            }

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            frmInvoiceList frmInvList = new frmInvoiceList();
            if (dtp_Date.Value != null && Cmb_Customer.SelectedValue != null )
            {
                if (ID == 0)
                {
                    SaveData();
                    Close();
                    if (chkIsPaid.Checked)
                        UserSession.ShowPaidInvoice = true;
                    else
                        UserSession.ShowPaidInvoice = false;
                    frmInvList.Show();
                }
                else
                {
                    UpdateData(ID);
                    Close();
                    Clear();
                    ID = 0;
                    frmInvList.Show();
                }
            }


        }
        
        private void txt_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as MetroTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    

        #endregion

        #region Methods
        void BindCombo()
        {
            using (InvoiceEntities cntx = new InvoiceEntities())
            {
                var Query = from a in cntx.tblCustomer select a;
                Cmb_Customer.DisplayMember = "CustomerName";
                Cmb_Customer.ValueMember = "CustomerID";
                Cmb_Customer.DataSource = Query.ToList();
            }
        }
        
        void FillDescription()
        {
            using (InvoiceEntities cntx = new InvoiceEntities())
            {
                int CustomerID = Convert.ToInt32(Cmb_Customer.SelectedValue);
                var Query = from a in cntx.tblDescription where a.CustomerID == CustomerID select a;
                cmbDescription.DisplayMember = "Description";
                cmbDescription.ValueMember = "DescriptionID";
                cmbDescription.DataSource = Query.ToList();
            }
        }

        void SaveData()
        {
            using (InvoiceEntities cntx = new InvoiceEntities())
            {
                tblInvoiceDetail ObjDetail = new tblInvoiceDetail();

                tblInvoice ObjInvoice = new tblInvoice();
                ObjInvoice.InvoiceNo = "PI" + LastInvoiceID();
                ObjInvoice.InvoiceDate = dtp_Date.Value;
                ObjInvoice.CustomerID = Convert.ToInt32(Cmb_Customer.SelectedValue);
                ObjInvoice.TotalAmount = Convert.ToDecimal(lbl_TotalAmount.Text.Replace("$ ", "")) + Convert.ToDecimal(lbl_GST.Text.Replace("$ ", ""));
                ObjInvoice.GST = Convert.ToDecimal(lbl_GST.Text.Replace("$ ", ""));
                //ObjInvoice.Terms = txt_Terms.Text;
                ObjInvoice.IsPaid = chkIsPaid.Checked;
                ObjInvoice.CreatedOn = DateTime.Now;
                cntx.tblInvoice.Add(ObjInvoice);
                cntx.SaveChanges();

                for (int i = 0; i < CurrentData.Rows.Count; i++)
                {
                    ObjDetail.Description = CurrentData.Rows[i][1].ToString();
                    ObjDetail.StartDate = Convert.ToDateTime(CurrentData.Rows[i][2].ToString());
                    ObjDetail.EndDate = Convert.ToDateTime(CurrentData.Rows[i][3].ToString());
                    ObjDetail.Amount = Convert.ToDecimal(CurrentData.Rows[i][4].ToString().Replace("$ ", ""));
                    ObjDetail.Duration = (ObjDetail.EndDate - ObjDetail.StartDate).Value.TotalDays + " Days";
                    ObjDetail.InvoiceID = ObjInvoice.InvoiceID;
                    cntx.tblInvoiceDetail.Add(ObjDetail);
                    cntx.SaveChanges();

                }
            }


           
        }

        public string LastInvoiceID()
        {
            InvoiceEntities db = new InvoiceEntities();
            List<tblInvoice> objtblInvoiceCol = db.tblInvoice.ToList();
            if (objtblInvoiceCol.Count > 0)
                return (objtblInvoiceCol[objtblInvoiceCol.Count - 1].InvoiceID + 1).ToString();
            else
                return "1";
        }

        void Clear()
        {
            //txt_Des.Text = "";
            txt_Amount.Text = "";

        }
        private void UpdateData(int ID)
        {
            using (InvoiceEntities cntx = new InvoiceEntities())
            {
                var ObjInv = (from c in cntx.tblInvoice where c.InvoiceID == ID select c).FirstOrDefault();
                ObjInv.InvoiceDate = dtp_Date.Value;
                ObjInv.CustomerID = Convert.ToInt32(Cmb_Customer.SelectedValue);
                ObjInv.TotalAmount = Convert.ToDecimal(lbl_TotalAmount.Text.Replace("$ ","")) + Convert.ToDecimal(lbl_GST.Text.Replace("$ ", ""));
                ObjInv.GST = Convert.ToDecimal(lbl_GST.Text.Replace("$ ", ""));
                //ObjInv.Terms = txt_Terms.Text;
                ObjInv.IsPaid = chkIsPaid.Checked;
                ObjInv.ModifiedOn = DateTime.Now;

                var objInvoiceDetailCol = (from c in cntx.tblInvoiceDetail where c.InvoiceID == ID select c).ToList();

                cntx.tblInvoiceDetail.RemoveRange(objInvoiceDetailCol);
                cntx.SaveChanges();

                tblInvoiceDetail objtblInvoiceDetail;
                for (int i = 0; i < CurrentData.Rows.Count; i++)
                {
                    objtblInvoiceDetail = new tblInvoiceDetail();
                    objtblInvoiceDetail.InvoiceID = ID;
                    objtblInvoiceDetail.Description = CurrentData.Rows[i][1].ToString();
                    objtblInvoiceDetail.StartDate = Convert.ToDateTime(CurrentData.Rows[i][2].ToString());
                    objtblInvoiceDetail.EndDate = Convert.ToDateTime(CurrentData.Rows[i][3].ToString());
                    objtblInvoiceDetail.Duration = (objtblInvoiceDetail.EndDate - objtblInvoiceDetail.StartDate).Value.TotalDays + " Days";
                    objtblInvoiceDetail.Amount = Convert.ToDecimal(CurrentData.Rows[i][4].ToString().Replace("$ ", ""));
                    cntx.tblInvoiceDetail.Add(objtblInvoiceDetail);
                    cntx.SaveChanges();
                }

                MessageBox.Show("Update Record Successfully");

            }

        }
        void ShowData()
        {
            dtp_Date.Value = frmInvoiceList.InvDate;
            dtp_EndDate.Value = frmInvoiceList.InvEndDate;
            dtp_StartDate.Value = frmInvoiceList.InvStartDate;
        }

        private void ShowData(int ID)
        {
            if (ID > 0)
            {
                using (InvoiceEntities cntx = new InvoiceEntities())
                {
                    var Query = (from c in cntx.tblInvoice where c.InvoiceID == ID select c).FirstOrDefault();

                    DataTable dt = new DataTable();

                    dtp_Date.Value = Convert.ToDateTime(Query.InvoiceDate);
                    //txt_Terms.Text = Query.Terms;
                    lbl_TotalAmount.Text = "$ "+ Query.TotalAmount.Value.ToString("#,##0.00");
                    if (Query.IsPaid.HasValue)
                        chkIsPaid.Checked = Query.IsPaid.Value;
                    if (Query.GST.HasValue)
                        lbl_GST.Text = "$ " + Query.GST.Value.ToString("#,##0.00");
                    //InvDate = 

                    var Query2 = (from c in cntx.tblInvoiceDetail where c.InvoiceID == ID select new { c.InvoiceDetailID, c.Description, c.StartDate, c.EndDate, c.Amount }).ToList();

                    DataRow dr;
                    foreach (var item in Query2)
                    {
                        dr = CurrentData.NewRow();
                        dr[0] = item.InvoiceDetailID;
                        dr[1] = item.Description;
                        dr[2] = item.StartDate.Value.ToString("MMMM dd, yyyy");
                        dr[3] = item.EndDate.Value.ToString("MMMM dd, yyyy");
                        dr[4] = "$ "+ item.Amount.Value.ToString("#,##0.00");
                        CurrentData.Rows.Add(dr);
                    }

                    Grid_Invoice.DataSource = CurrentData;

                }
            }

        }


        #endregion

        private void Grid_Invoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show(this, "Are You Sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if(e.ColumnIndex == 0)
                {
                    CurrentData.Rows.RemoveAt(e.RowIndex);
                    Grid_Invoice.DataSource = CurrentData;

                    decimal sum = 0;
                    for (int i = 0; i < CurrentData.Rows.Count; i++)
                    {
                        if (CurrentData.Rows[i][4].ToString() != null)
                        {
                            sum += Convert.ToDecimal(CurrentData.Rows[i][4].ToString().Replace("$ ", ""));
                        }
                    }
                    lbl_TotalAmount.Text = "$ " + sum.ToString();
                    Gst = Convert.ToDecimal(sum) * 10 / 100;
                    lbl_GST.Text = "$ " + Gst.ToString();
                }
            }
        }

        private void Cmb_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDescription();
        }
    }
}
