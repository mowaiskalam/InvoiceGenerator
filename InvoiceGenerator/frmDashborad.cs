using InvoiceGenerator.Helper;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace InvoiceGenerator
{
    public partial class frmDashborad : MetroForm
    {
        public frmDashborad()
        {
            InitializeComponent();
        }

        private void frmDashborad_Load(object sender, EventArgs e)
        {
            int WindowHeight, WindowWidth;
            WindowWidth = Screen.PrimaryScreen.WorkingArea.Size.Width;
            WindowHeight = Screen.PrimaryScreen.WorkingArea.Size.Height;
            btnClose.Location = new Point(WindowWidth - 28, 2);
            btnMin.Location = new Point(WindowWidth - 60, 2);
            btnLogout.Location = new Point(WindowWidth - 125, 2);
            imgTitle.Location = new Point(WindowWidth - imgTitle.Width - 100, WindowHeight - imgTitle.Height - 100);
            LoadCounts();
        }

        public void LoadCounts()
        {
            InvoiceEntities db = new InvoiceEntities();
            lblCustomerCount.Text = db.tblCustomer.Count().ToString();
            lblPaidInvoiceCount.Text = db.tblInvoice.Count(col => col.IsPaid == true).ToString();
            lblUnpaidCount.Text = db.tblInvoice.Count(col => col.IsPaid == false).ToString();
            lblDesCount.Text = db.tblDescription.Count(col => col.IsActive == true).ToString();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            frmInvoice frmInv = null;
            if ((IsFormAlreadyOpen(typeof(frmInvoice)) == null))
            {
                using (InvoiceEntities cntx = new InvoiceEntities())
                {
                    tblCustomer ObjCust = new tblCustomer();
                    var Query = (from a in cntx.tblCustomer select new { a.CustomerID });
                    if (Query.Count() == 0)
                    {
                        MessageBox.Show("You Have To Create At Least One Customer", "Attention");
                    }
                    else
                    {
                        frmInv = new frmInvoice();
                        frmInvoice.ID = 0;
                        frmInv.Show();
                    }

                }
               
            }

            else
            {
                MessageBox.Show("Form is already open"); 
            }
        }


            //frmCustomer frmCus = new frmCustomer

            //frmCus.Show();
            //FormCollection fc = Application.OpenForms;
            //if (frmCustomer.Name == "frmCustomer")
            //{
            //    MessageBox.Show(frmCustomer.Name + " is open");
            //}
            //else {

            //    frmCustomer.Show();
            //}

            //string FormName = "frmCustomer";

            //string FormName = "frmCustomer";

            //foreach (Form frm in Application.OpenForms)
            //{
            //    if (fc.Count == 2)
            //{
            //    MessageBox.Show(frm.Name + " is already open");
            //} 
            //else
            //{

            //}
            //}




       
        private void metroTile4_Click(object sender, EventArgs e)
        {
            frmCustomer frmCus = null;
            if ((IsFormAlreadyOpen(typeof(frmCustomer)) == null))
            {
                frmCus = new frmCustomer();
                frmCus.Show();
            }

            else
            {
                MessageBox.Show("Form is already open"); 
            }

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            frmInvoiceList frmInvLSit = null;
            UserSession.ShowPaidInvoice = false;
            if ((IsFormAlreadyOpen(typeof(frmInvoiceList)) == null))
            {
                frmInvLSit = new frmInvoiceList();
                frmInvLSit.Show();
            }

            else
            {
                MessageBox.Show("Form is already open"); 
            }
        }
        public static Form IsFormAlreadyOpen(Type FormType)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType() == FormType)
                    return OpenForm;
            }

            return null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.UserID = null;
            frmLogin objfrmLogin = new frmLogin();
            this.Hide();
            objfrmLogin.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmInvoiceList frmInvLSit = null;
            UserSession.ShowPaidInvoice = true;
            if ((IsFormAlreadyOpen(typeof(frmInvoiceList)) == null))
            {
                frmInvLSit = new frmInvoiceList();
                frmInvLSit.Show();
            }
            else
            {
                MessageBox.Show("Form is already open");
            }
        }

        private void frmDashborad_Activated(object sender, EventArgs e)
        {
            LoadCounts();
        }

        private void pnlDes_Click(object sender, EventArgs e)
        {
            frmDescription frmDescription = null;
            if ((IsFormAlreadyOpen(typeof(frmDescription)) == null))
            {
                frmDescription = new frmDescription();
                frmDescription.Show();
            }
            else
            {
                MessageBox.Show("Form is already open");
            }
        }
    }
}
