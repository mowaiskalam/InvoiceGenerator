using InvoiceGenerator.Helper;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace InvoiceGenerator
{
    public partial class frmLogin : MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                MessageBox.Show("Please enter username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            else
            {
                InvoiceEntities db = new InvoiceEntities();
                tblUser objtblUser = db.tblUser
                    .Where(col => col.Username == txtUsername.Text 
                        && col.Password == txtPassword.Text
                        && col.IsActive == true).FirstOrDefault();

                if(objtblUser != null)
                {
                    UserSession.UserID = objtblUser.UserID;
                    UserSession.currentUser = objtblUser;

                    frmDashborad objfrmDashboard = new frmDashborad();
                    objfrmDashboard.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
