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

namespace InvoiceGenerator
{
    public partial class frmDescription : MetroForm
    {
        public frmDescription()
        {
            InitializeComponent();
        }
        int ID;

        private void frmDescription_Load(object sender, EventArgs e)
        {
            BindCombo();
            BindGrid();
            Clear();
        }

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

        private void Grid_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(Grid_Customer.CurrentRow.Cells["DescriptionID"].Value) != 0)
            {
                if (e.ColumnIndex == 0)
                {

                    ID = Convert.ToInt32(Grid_Customer.CurrentRow.Cells["DescriptionID"].Value);
                    ShowData(ID);
                }

                else if (e.ColumnIndex == 1)
                {
                    if (MessageBox.Show("Do you want to Delete this record. Confirm?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ID = Convert.ToInt32(Grid_Customer.CurrentRow.Cells["DescriptionID"].Value);
                        DeleteData(ID);
                        BindGrid();
                        Clear();
                    }
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
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

        private void BindGrid()
        {
            using (InvoiceEntities cntx = new InvoiceEntities())
            {
                var Query = from a in cntx.VwDescription select new { a.DescriptionID, a.CustomerName, a.Email, a.Description };
                Grid_Customer.DataSource = Query.ToList();
            }
        }
        private void DeleteData(int ID)
        {
            using (InvoiceEntities cntx = new InvoiceEntities())
            {
                var Query = (from a in cntx.tblDescription where a.DescriptionID == ID select a).FirstOrDefault();
                if (Query == null)
                {
                    MessageBox.Show("Can't Delete Because this record while in use", "Alert");
                }
                else
                {
                    cntx.tblDescription.Remove(Query);
                    cntx.SaveChanges();
                }

            }
        }
        private void ShowData(int ID)
        {
            using (InvoiceEntities cntx = new InvoiceEntities())
            {
                var Query = (from c in cntx.tblDescription where c.DescriptionID == ID select c).FirstOrDefault();
                txt_Description.Text = Query.Description;
                Cmb_Customer.SelectedValue = Query.CustomerID.Value;
            }
        }
        private void UpdateData(int ID)
        {
            using (InvoiceEntities cntx = new InvoiceEntities())
            {

                var objDes = (from c in cntx.tblDescription where c.DescriptionID == ID select c).FirstOrDefault();
                objDes.Description = txt_Description.Text;
                objDes.CustomerID = Convert.ToInt32(Cmb_Customer.SelectedValue);

                objDes.IsActive = true;

                objDes.ModifiedOn = DateTime.Now;

                cntx.SaveChanges();
                MessageBox.Show("Update Record Successfully");
            }

        }
        private void SaveData()
        {
            using (InvoiceEntities cntx = new InvoiceEntities())
            {
                tblDescription objDes = new tblDescription();

                objDes.Description = txt_Description.Text;
                objDes.CustomerID = Convert.ToInt32(Cmb_Customer.SelectedValue);

                objDes.IsActive = true;

                objDes.CreatedOn = DateTime.Now;
                objDes.ModifiedOn = null;
                cntx.tblDescription.Add(objDes);
                cntx.SaveChanges();
                MessageBox.Show("Save Record Successfully");

            }
        }

        private void Clear()
        {

            txt_Description.Text = "";
            ID = 0;
        }
    }
}
