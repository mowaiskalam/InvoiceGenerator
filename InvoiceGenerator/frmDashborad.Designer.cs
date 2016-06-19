namespace InvoiceGenerator
{
    partial class frmDashborad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMin = new MetroFramework.Controls.MetroTile();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.btnLogout = new MetroFramework.Controls.MetroTile();
            this.imgTitle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPaidInvoiceCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUnpaidCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlDes = new System.Windows.Forms.Panel();
            this.lblDesCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlDes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMin
            // 
            this.btnMin.ActiveControl = null;
            this.btnMin.Location = new System.Drawing.Point(1341, 5);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(29, 30);
            this.btnMin.TabIndex = 13;
            this.btnMin.Text = "-";
            this.btnMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMin.UseSelectable = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.Location = new System.Drawing.Point(1376, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "x";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveControl = null;
            this.btnLogout.Location = new System.Drawing.Point(1271, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(63, 30);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // imgTitle
            // 
            this.imgTitle.Image = global::InvoiceGenerator.Properties.Resources.ComputerNetworks_1024x697;
            this.imgTitle.Location = new System.Drawing.Point(861, 373);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(534, 390);
            this.imgTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTitle.TabIndex = 15;
            this.imgTitle.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblPaidInvoiceCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(589, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 120);
            this.panel1.TabIndex = 18;
            this.panel1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // lblPaidInvoiceCount
            // 
            this.lblPaidInvoiceCount.AutoSize = true;
            this.lblPaidInvoiceCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidInvoiceCount.Location = new System.Drawing.Point(85, 59);
            this.lblPaidInvoiceCount.Name = "lblPaidInvoiceCount";
            this.lblPaidInvoiceCount.Size = new System.Drawing.Size(0, 25);
            this.lblPaidInvoiceCount.TabIndex = 1;
            this.lblPaidInvoiceCount.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Paid Invoice";
            this.label2.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.lblUnpaidCount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(834, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 120);
            this.panel2.TabIndex = 19;
            this.panel2.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // lblUnpaidCount
            // 
            this.lblUnpaidCount.AutoSize = true;
            this.lblUnpaidCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnpaidCount.Location = new System.Drawing.Point(88, 59);
            this.lblUnpaidCount.Name = "lblUnpaidCount";
            this.lblUnpaidCount.Size = new System.Drawing.Size(0, 25);
            this.lblUnpaidCount.TabIndex = 1;
            this.lblUnpaidCount.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unpaid Invoice";
            this.label4.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Chocolate;
            this.panel3.Controls.Add(this.lblCustomerCount);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(330, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 120);
            this.panel3.TabIndex = 19;
            this.panel3.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCount.Location = new System.Drawing.Point(79, 59);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(0, 25);
            this.lblCustomerCount.TabIndex = 1;
            this.lblCustomerCount.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customer";
            this.label5.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.YellowGreen;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(75, 204);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 120);
            this.panel4.TabIndex = 20;
            this.panel4.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Create Invoice";
            this.label6.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // pnlDes
            // 
            this.pnlDes.BackColor = System.Drawing.Color.Gray;
            this.pnlDes.Controls.Add(this.lblDesCount);
            this.pnlDes.Controls.Add(this.label8);
            this.pnlDes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDes.ForeColor = System.Drawing.Color.White;
            this.pnlDes.Location = new System.Drawing.Point(1071, 204);
            this.pnlDes.Name = "pnlDes";
            this.pnlDes.Size = new System.Drawing.Size(187, 120);
            this.pnlDes.TabIndex = 21;
            this.pnlDes.Click += new System.EventHandler(this.pnlDes_Click);
            // 
            // lblDesCount
            // 
            this.lblDesCount.AutoSize = true;
            this.lblDesCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesCount.Location = new System.Drawing.Point(88, 59);
            this.lblDesCount.Name = "lblDesCount";
            this.lblDesCount.Size = new System.Drawing.Size(0, 25);
            this.lblDesCount.TabIndex = 1;
            this.lblDesCount.Click += new System.EventHandler(this.pnlDes_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Descriptions";
            this.label8.Click += new System.EventHandler(this.pnlDes_Click);
            // 
            // frmDashborad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InvoiceGenerator.Properties.Resources.ComputerNetworks_1024x697;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackImage = global::InvoiceGenerator.Properties.Resources.ComputerNetworks_1024x697;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1418, 786);
            this.Controls.Add(this.pnlDes);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgTitle);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.Name = "frmDashborad";
            this.Resizable = false;
            this.Text = "    Easttech Computers Pty. Ltd";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmDashborad_Activated);
            this.Load += new System.EventHandler(this.frmDashborad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlDes.ResumeLayout(false);
            this.pnlDes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile btnMin;
        private MetroFramework.Controls.MetroTile btnClose;
        private MetroFramework.Controls.MetroTile btnLogout;
        private System.Windows.Forms.PictureBox imgTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPaidInvoiceCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUnpaidCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlDes;
        private System.Windows.Forms.Label lblDesCount;
        private System.Windows.Forms.Label label8;
    }
}