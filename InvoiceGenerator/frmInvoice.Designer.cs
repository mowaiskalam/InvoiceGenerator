namespace InvoiceGenerator
{
    partial class frmInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlHeader = new MetroFramework.Controls.MetroPanel();
            this.chkIsPaid = new System.Windows.Forms.CheckBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.Cmb_Customer = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.PnlFooter = new MetroFramework.Controls.MetroPanel();
            this.cmbDescription = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_Amount = new MetroFramework.Controls.MetroTextBox();
            this.btn_AddMore = new MetroFramework.Controls.MetroButton();
            this.Grid_Invoice = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_Save = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lbl_GST = new MetroFramework.Controls.MetroLabel();
            this.lbl_Amount = new MetroFramework.Controls.MetroLabel();
            this.lbl_TotalAmount = new MetroFramework.Controls.MetroLabel();
            this.PnlHeader.SuspendLayout();
            this.PnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlHeader.Controls.Add(this.chkIsPaid);
            this.PnlHeader.Controls.Add(this.dtp_Date);
            this.PnlHeader.Controls.Add(this.Cmb_Customer);
            this.PnlHeader.Controls.Add(this.metroLabel8);
            this.PnlHeader.Controls.Add(this.metroLabel1);
            this.PnlHeader.Controls.Add(this.metroLabel2);
            this.PnlHeader.HorizontalScrollbarBarColor = true;
            this.PnlHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.PnlHeader.HorizontalScrollbarSize = 10;
            this.PnlHeader.Location = new System.Drawing.Point(20, 62);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(925, 161);
            this.PnlHeader.TabIndex = 3;
            this.PnlHeader.VerticalScrollbarBarColor = true;
            this.PnlHeader.VerticalScrollbarHighlightOnWheel = false;
            this.PnlHeader.VerticalScrollbarSize = 10;
            // 
            // chkIsPaid
            // 
            this.chkIsPaid.AutoSize = true;
            this.chkIsPaid.Location = new System.Drawing.Point(60, 126);
            this.chkIsPaid.Name = "chkIsPaid";
            this.chkIsPaid.Size = new System.Drawing.Size(47, 17);
            this.chkIsPaid.TabIndex = 45;
            this.chkIsPaid.Text = "Paid";
            this.chkIsPaid.UseVisualStyleBackColor = true;
            // 
            // dtp_Date
            // 
            this.dtp_Date.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.dtp_Date.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(159, 85);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(197, 22);
            this.dtp_Date.TabIndex = 36;
            // 
            // Cmb_Customer
            // 
            this.Cmb_Customer.FormattingEnabled = true;
            this.Cmb_Customer.ItemHeight = 23;
            this.Cmb_Customer.Items.AddRange(new object[] {
            "Normal Combobox 1",
            "Normal Combobox 2",
            "Normal Combobox 3",
            "Normal Combobox 4"});
            this.Cmb_Customer.Location = new System.Drawing.Point(159, 50);
            this.Cmb_Customer.Name = "Cmb_Customer";
            this.Cmb_Customer.PromptText = "Select Customer";
            this.Cmb_Customer.Size = new System.Drawing.Size(197, 29);
            this.Cmb_Customer.TabIndex = 35;
            this.Cmb_Customer.UseSelectable = true;
            this.Cmb_Customer.SelectedIndexChanged += new System.EventHandler(this.Cmb_Customer_SelectedIndexChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(60, 55);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(77, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "Customer  :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(60, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Date :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(40, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(176, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Invoice Information :";
            // 
            // PnlFooter
            // 
            this.PnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlFooter.Controls.Add(this.cmbDescription);
            this.PnlFooter.Controls.Add(this.metroLabel7);
            this.PnlFooter.Controls.Add(this.dtp_EndDate);
            this.PnlFooter.Controls.Add(this.dtp_StartDate);
            this.PnlFooter.Controls.Add(this.metroLabel4);
            this.PnlFooter.Controls.Add(this.txt_Amount);
            this.PnlFooter.Controls.Add(this.btn_AddMore);
            this.PnlFooter.Controls.Add(this.Grid_Invoice);
            this.PnlFooter.HorizontalScrollbarBarColor = true;
            this.PnlFooter.HorizontalScrollbarHighlightOnWheel = false;
            this.PnlFooter.HorizontalScrollbarSize = 10;
            this.PnlFooter.Location = new System.Drawing.Point(20, 250);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(925, 350);
            this.PnlFooter.TabIndex = 4;
            this.PnlFooter.VerticalScrollbarBarColor = true;
            this.PnlFooter.VerticalScrollbarHighlightOnWheel = false;
            this.PnlFooter.VerticalScrollbarSize = 10;
            // 
            // cmbDescription
            // 
            this.cmbDescription.FormattingEnabled = true;
            this.cmbDescription.IntegralHeight = false;
            this.cmbDescription.ItemHeight = 23;
            this.cmbDescription.Items.AddRange(new object[] {
            "Normal Combobox 1",
            "Normal Combobox 2",
            "Normal Combobox 3",
            "Normal Combobox 4"});
            this.cmbDescription.Location = new System.Drawing.Point(19, 28);
            this.cmbDescription.Name = "cmbDescription";
            this.cmbDescription.PromptText = "Select Description";
            this.cmbDescription.Size = new System.Drawing.Size(337, 29);
            this.cmbDescription.TabIndex = 44;
            this.cmbDescription.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(564, 28);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(69, 19);
            this.metroLabel7.TabIndex = 43;
            this.metroLabel7.Text = "End Date :";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.dtp_EndDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndDate.Location = new System.Drawing.Point(564, 59);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(190, 22);
            this.dtp_EndDate.TabIndex = 42;
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.dtp_StartDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDate.Location = new System.Drawing.Point(365, 59);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(190, 22);
            this.dtp_StartDate.TabIndex = 37;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(365, 28);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 37;
            this.metroLabel4.Text = "Start Date :";
            // 
            // txt_Amount
            // 
            this.txt_Amount.IconRight = true;
            this.txt_Amount.Lines = new string[0];
            this.txt_Amount.Location = new System.Drawing.Point(763, 58);
            this.txt_Amount.MaxLength = 32767;
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.PasswordChar = '\0';
            this.txt_Amount.PromptText = "Amount";
            this.txt_Amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Amount.SelectedText = "";
            this.txt_Amount.Size = new System.Drawing.Size(135, 25);
            this.txt_Amount.TabIndex = 39;
            this.txt_Amount.UseSelectable = true;
            this.txt_Amount.UseStyleColors = true;
            this.txt_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Amount_KeyPress);
            // 
            // btn_AddMore
            // 
            this.btn_AddMore.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_AddMore.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_AddMore.Highlight = true;
            this.btn_AddMore.Location = new System.Drawing.Point(763, 25);
            this.btn_AddMore.Name = "btn_AddMore";
            this.btn_AddMore.Size = new System.Drawing.Size(135, 25);
            this.btn_AddMore.TabIndex = 36;
            this.btn_AddMore.Text = "Add More";
            this.btn_AddMore.UseSelectable = true;
            this.btn_AddMore.Click += new System.EventHandler(this.btn_AddMore_Click);
            // 
            // Grid_Invoice
            // 
            this.Grid_Invoice.AllowUserToResizeColumns = false;
            this.Grid_Invoice.AllowUserToResizeRows = false;
            this.Grid_Invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Invoice.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Grid_Invoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_Invoice.CausesValidation = false;
            this.Grid_Invoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_Invoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.StartDate,
            this.EndDate,
            this.Amount,
            this.Delete});
            this.Grid_Invoice.GridColor = System.Drawing.Color.Silver;
            this.Grid_Invoice.Location = new System.Drawing.Point(19, 87);
            this.Grid_Invoice.Name = "Grid_Invoice";
            this.Grid_Invoice.ReadOnly = true;
            this.Grid_Invoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_Invoice.Size = new System.Drawing.Size(884, 239);
            this.Grid_Invoice.TabIndex = 2;
            this.Grid_Invoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Invoice_CellContentClick);
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Description.DefaultCellStyle = dataGridViewCellStyle1;
            this.Description.FillWeight = 90F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.StartDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.EndDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle4;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::InvoiceGenerator.Properties.Resources.icon_delete;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // btn_Save
            // 
            this.btn_Save.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Save.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Save.Highlight = true;
            this.btn_Save.Location = new System.Drawing.Point(80, 681);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(108, 25);
            this.btn_Save.TabIndex = 37;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseSelectable = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(673, 661);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(39, 19);
            this.metroLabel9.TabIndex = 38;
            this.metroLabel9.Text = "GST :";
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.Location = new System.Drawing.Point(855, 662);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(16, 19);
            this.lbl_GST.TabIndex = 39;
            this.lbl_GST.Text = "0";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(673, 626);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(87, 19);
            this.lbl_Amount.TabIndex = 44;
            this.lbl_Amount.Text = "Total Amount";
            // 
            // lbl_TotalAmount
            // 
            this.lbl_TotalAmount.AutoSize = true;
            this.lbl_TotalAmount.Location = new System.Drawing.Point(855, 626);
            this.lbl_TotalAmount.Name = "lbl_TotalAmount";
            this.lbl_TotalAmount.Size = new System.Drawing.Size(16, 19);
            this.lbl_TotalAmount.TabIndex = 45;
            this.lbl_TotalAmount.Text = "0";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 732);
            this.Controls.Add(this.lbl_TotalAmount);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.lbl_GST);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.PnlFooter);
            this.Controls.Add(this.PnlHeader);
            this.MaximizeBox = false;
            this.Name = "frmInvoice";
            this.Text = "      Add A Record";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.PnlFooter.ResumeLayout(false);
            this.PnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PnlHeader;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox Cmb_Customer;
        private MetroFramework.Controls.MetroPanel PnlFooter;
        private System.Windows.Forms.DataGridView Grid_Invoice;
        private MetroFramework.Controls.MetroButton btn_AddMore;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_Save;
        private MetroFramework.Controls.MetroTextBox txt_Amount;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel lbl_GST;
        private MetroFramework.Controls.MetroLabel lbl_Amount;
        private MetroFramework.Controls.MetroLabel lbl_TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private MetroFramework.Controls.MetroComboBox cmbDescription;
        private System.Windows.Forms.CheckBox chkIsPaid;
    }
}