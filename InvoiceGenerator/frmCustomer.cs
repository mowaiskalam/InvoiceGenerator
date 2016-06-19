using MetroFramework.Demo;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceGenerator
{
    public partial class frmCustomer : MetroForm
    {
        int ID;
        public frmCustomer()
        {
            InitializeComponent();
        }

        #region Events
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            BindGrid();
            Clear();
        }


        private void Grid_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(Grid_Customer.CurrentRow.Cells["CustomerID"].Value) != 0)
            {
                if (e.ColumnIndex == 0)
                {

                    ID = Convert.ToInt32(Grid_Customer.CurrentRow.Cells["CustomerID"].Value);
                    ShowData(ID);
                }

                else if (e.ColumnIndex == 1)
                {
                    if (MessageBox.Show("Do you want to Delete this record. Confirm?", "Alet", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ID = Convert.ToInt32(Grid_Customer.CurrentRow.Cells["CustomerID"].Value);
                        DeleteData(ID);
                        BindGrid();
                        Clear();
                    }
                }


            }

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txt_Name.Text))
            //{

            //}

            if (txt_Name.Text != "" && txt_ContactNo.Text != "" && txt_Email.Text != "")
            {
                if (ID == 0)
                {
                    SaveData();
                    Clear();
                }
                else
                {
                    UpdateData(ID);
                    Clear();
                }

                BindGrid();
            }


        }
        #endregion

        #region Methods
        private void BindGrid()
        {
            using (InvoiceEntities cntx = new InvoiceEntities())
            {
                var Query = from a in cntx.tblCustomer select new { a.CustomerID, a.CustomerName, a.Email, a.BusinessName, a.IsActive };
                Grid_Customer.DataSource = Query.ToList();
            }
        }
        private void DeleteData(int ID)
        {
            using (InvoiceEntities cntx = new InvoiceEntities())
            {
                var Query = (from a in cntx.tblCustomer where a.CustomerID == ID select a).FirstOrDefault();
                var Query2 = (from a in cntx.tblInvoice where a.CustomerID == ID select a).FirstOrDefault();
                if (Query2 != null)
                {
                    MessageBox.Show("Can't Delete Because this record while in use", "Alert");
                }
                else
                {
                    cntx.tblCustomer.Remove(Query);
                    cntx.SaveChanges();
                }

            }
        }
        private void ShowData(int ID)
        {
            using (InvoiceEntities cntx = new InvoiceEntities())
            {
                var Query = (from c in cntx.tblCustomer where c.CustomerID == ID select c).FirstOrDefault();
                txt_Name.Text = Query.CustomerName;
                txt_Address.Text = Query.Address;
                txt_Email.Text = Query.Email;
                txt_ContactNo.Text = Query.ContactNo;
                txt_BName.Text = Query.BusinessName;
                txt_BAddress.Text = Query.BusinessAddress;
                txt_BWeb.Text = Query.BusinessWebsite;
                if (Query.IsActive == true)
                {
                    rdb_Yes.Checked = true;
                }
                else
                {
                    rdb_No.Checked = false;
                }

            }
        }
        private void UpdateData(int ID)
        {
            using (InvoiceEntities cntx = new InvoiceEntities())
            {
                //var Query = (from c in cntx.tblCustomer where c.CustomerName == txt_Name.Text select c).FirstOrDefault();

                //if (Query != null)
                //{
                //    MessageBox.Show("Name is already Exit");
                //}
                //else
                //{
                var ObjCust = (from c in cntx.tblCustomer where c.CustomerID == ID select c).FirstOrDefault();
                ObjCust.CustomerName = txt_Name.Text;
                ObjCust.Address = txt_Address.Text;
                ObjCust.Email = txt_Email.Text;
                ObjCust.ContactNo = txt_ContactNo.Text;
                ObjCust.BusinessName = txt_BName.Text;
                ObjCust.BusinessAddress = txt_BAddress.Text;
                ObjCust.BusinessWebsite = txt_BWeb.Text;
                if (rdb_Yes.Checked)
                {
                    ObjCust.IsActive = true;
                }
                else
                {
                    ObjCust.IsActive = false;
                }
                ObjCust.ModifiedOn = DateTime.Now;
                cntx.SaveChanges();
                MessageBox.Show("Update Record Successfully");

                //}


            }

        }
        private void SaveData()
        {
            using (InvoiceEntities cntx = new InvoiceEntities())
            {
                tblCustomer ObjCust = new tblCustomer();
                //var Query = (from c in cntx.tblCustomer where c.CustomerName == txt_Name.Text select c).FirstOrDefault();

                //if (Query != null)
                //{
                //    MessageBox.Show("Name is already Exit");
                //}
                //else
                //{

                ObjCust.CustomerName = txt_Name.Text;
                ObjCust.Address = txt_Address.Text;
                ObjCust.Email = txt_Email.Text;
                ObjCust.ContactNo = txt_ContactNo.Text;
                ObjCust.BusinessName = txt_BName.Text;
                ObjCust.BusinessAddress = txt_BAddress.Text;
                ObjCust.BusinessWebsite = txt_BWeb.Text;
                if (rdb_Yes.Checked)
                {
                    ObjCust.IsActive = true;
                }
                else
                {
                    ObjCust.IsActive = false;
                }
                ObjCust.CreatedOn = DateTime.Now;
                ObjCust.ModifiedOn = null;
                cntx.tblCustomer.Add(ObjCust);
                cntx.SaveChanges();
                MessageBox.Show("Save Record Successfully");

                
                //}
            }
        }
        private void Clear()
        {
            txt_Name.Text = "";
            txt_Address.Text = "";
            txt_ContactNo.Text = "";
            txt_Email.Text = "";
            txt_BAddress.Text = "";
            txt_BName.Text = "";
            txt_BWeb.Text = "";
            rdb_Yes.Checked = true;
            ID = 0;
        }

        #endregion

        private void txt_Name_Validating(object sender, CancelEventArgs e)
        {
            if (txt_Name.Text == string.Empty)
            {
                errorProvider1.SetError(txt_Name, "Please Enter Name");
            }
        }

        private void txt_Email_Validating(object sender, CancelEventArgs e)
        {
            if (txt_Email.Text == string.Empty)
            {
                errorProvider1.SetError(txt_Email, "Please Enter Email");
            }
        }

        private void txt_ContactNo_Validating(object sender, CancelEventArgs e)
        {
            if (txt_ContactNo.Text == string.Empty)
            {
                errorProvider1.SetError(txt_ContactNo, "Please Enter Contact No");
            }

        }


    }
}
