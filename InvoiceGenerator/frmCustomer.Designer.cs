using System;

namespace InvoiceGenerator
{
    partial class frmCustomer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.PnlHeader = new MetroFramework.Controls.MetroPanel();
            this.rdb_No = new MetroFramework.Controls.MetroRadioButton();
            this.rdb_Yes = new MetroFramework.Controls.MetroRadioButton();
            this.btn_Save = new MetroFramework.Controls.MetroButton();
            this.txt_BWeb = new MetroFramework.Controls.MetroTextBox();
            this.txt_BAddress = new MetroFramework.Controls.MetroTextBox();
            this.txt_BName = new MetroFramework.Controls.MetroTextBox();
            this.txt_ContactNo = new MetroFramework.Controls.MetroTextBox();
            this.txt_Email = new MetroFramework.Controls.MetroTextBox();
            this.txt_Address = new MetroFramework.Controls.MetroTextBox();
            this.txt_Name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.PnlFooter = new MetroFramework.Controls.MetroPanel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.Grid_Customer = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusinessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImgEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ImgDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PnlHeader.SuspendLayout();
            this.PnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlHeader.Controls.Add(this.rdb_No);
            this.PnlHeader.Controls.Add(this.rdb_Yes);
            this.PnlHeader.Controls.Add(this.btn_Save);
            this.PnlHeader.Controls.Add(this.txt_BWeb);
            this.PnlHeader.Controls.Add(this.txt_BAddress);
            this.PnlHeader.Controls.Add(this.txt_BName);
            this.PnlHeader.Controls.Add(this.txt_ContactNo);
            this.PnlHeader.Controls.Add(this.txt_Email);
            this.PnlHeader.Controls.Add(this.txt_Address);
            this.PnlHeader.Controls.Add(this.txt_Name);
            this.PnlHeader.Controls.Add(this.metroLabel7);
            this.PnlHeader.Controls.Add(this.metroLabel8);
            this.PnlHeader.Controls.Add(this.metroLabel9);
            this.PnlHeader.Controls.Add(this.metroLabel10);
            this.PnlHeader.Controls.Add(this.metroLabel6);
            this.PnlHeader.Controls.Add(this.metroLabel5);
            this.PnlHeader.Controls.Add(this.metroLabel4);
            this.PnlHeader.Controls.Add(this.metroLabel3);
            this.PnlHeader.Controls.Add(this.metroLabel2);
            this.PnlHeader.HorizontalScrollbarBarColor = true;
            this.PnlHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.PnlHeader.HorizontalScrollbarSize = 10;
            this.PnlHeader.Location = new System.Drawing.Point(20, 60);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(790, 289);
            this.PnlHeader.TabIndex = 2;
            this.PnlHeader.VerticalScrollbarBarColor = true;
            this.PnlHeader.VerticalScrollbarHighlightOnWheel = false;
            this.PnlHeader.VerticalScrollbarSize = 10;
            // 
            // rdb_No
            // 
            this.rdb_No.AutoSize = true;
            this.rdb_No.Location = new System.Drawing.Point(679, 171);
            this.rdb_No.Name = "rdb_No";
            this.rdb_No.Size = new System.Drawing.Size(39, 15);
            this.rdb_No.TabIndex = 38;
            this.rdb_No.TabStop = true;
            this.rdb_No.Text = "No";
            this.rdb_No.UseSelectable = true;
            // 
            // rdb_Yes
            // 
            this.rdb_Yes.AutoSize = true;
            this.rdb_Yes.Location = new System.Drawing.Point(612, 171);
            this.rdb_Yes.Name = "rdb_Yes";
            this.rdb_Yes.Size = new System.Drawing.Size(40, 15);
            this.rdb_Yes.TabIndex = 37;
            this.rdb_Yes.TabStop = true;
            this.rdb_Yes.Text = "Yes";
            this.rdb_Yes.UseSelectable = true;
            // 
            // btn_Save
            // 
            this.btn_Save.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Save.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Save.Highlight = true;
            this.btn_Save.Location = new System.Drawing.Point(40, 241);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(108, 25);
            this.btn_Save.TabIndex = 34;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseSelectable = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_BWeb
            // 
            this.txt_BWeb.IconRight = true;
            this.txt_BWeb.Lines = new string[0];
            this.txt_BWeb.Location = new System.Drawing.Point(579, 141);
            this.txt_BWeb.MaxLength = 32767;
            this.txt_BWeb.Name = "txt_BWeb";
            this.txt_BWeb.PasswordChar = '\0';
            this.txt_BWeb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_BWeb.SelectedText = "";
            this.txt_BWeb.Size = new System.Drawing.Size(187, 22);
            this.txt_BWeb.TabIndex = 32;
            this.txt_BWeb.UseSelectable = true;
            this.txt_BWeb.UseStyleColors = true;
            // 
            // txt_BAddress
            // 
            this.txt_BAddress.IconRight = true;
            this.txt_BAddress.Lines = new string[0];
            this.txt_BAddress.Location = new System.Drawing.Point(579, 111);
            this.txt_BAddress.MaxLength = 32767;
            this.txt_BAddress.Name = "txt_BAddress";
            this.txt_BAddress.PasswordChar = '\0';
            this.txt_BAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_BAddress.SelectedText = "";
            this.txt_BAddress.Size = new System.Drawing.Size(187, 22);
            this.txt_BAddress.TabIndex = 31;
            this.txt_BAddress.UseSelectable = true;
            this.txt_BAddress.UseStyleColors = true;
            // 
            // txt_BName
            // 
            this.txt_BName.IconRight = true;
            this.txt_BName.Lines = new string[0];
            this.txt_BName.Location = new System.Drawing.Point(579, 81);
            this.txt_BName.MaxLength = 32767;
            this.txt_BName.Name = "txt_BName";
            this.txt_BName.PasswordChar = '\0';
            this.txt_BName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_BName.SelectedText = "";
            this.txt_BName.Size = new System.Drawing.Size(187, 22);
            this.txt_BName.TabIndex = 30;
            this.txt_BName.UseSelectable = true;
            this.txt_BName.UseStyleColors = true;
            // 
            // txt_ContactNo
            // 
            this.errorProvider1.SetError(this.txt_ContactNo, "Please Enter a Contact No");
            this.txt_ContactNo.IconRight = true;
            this.txt_ContactNo.Lines = new string[0];
            this.txt_ContactNo.Location = new System.Drawing.Point(124, 188);
            this.txt_ContactNo.MaxLength = 32767;
            this.txt_ContactNo.Name = "txt_ContactNo";
            this.txt_ContactNo.PasswordChar = '\0';
            this.txt_ContactNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ContactNo.SelectedText = "";
            this.txt_ContactNo.Size = new System.Drawing.Size(187, 22);
            this.txt_ContactNo.TabIndex = 29;
            this.txt_ContactNo.UseSelectable = true;
            this.txt_ContactNo.UseStyleColors = true;
            this.txt_ContactNo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ContactNo_Validating);
            // 
            // txt_Email
            // 
            this.errorProvider1.SetError(this.txt_Email, "Please Enter a Email");
            this.txt_Email.IconRight = true;
            this.txt_Email.Lines = new string[0];
            this.txt_Email.Location = new System.Drawing.Point(124, 159);
            this.txt_Email.MaxLength = 32767;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Email.SelectedText = "";
            this.txt_Email.Size = new System.Drawing.Size(187, 22);
            this.txt_Email.TabIndex = 28;
            this.txt_Email.UseSelectable = true;
            this.txt_Email.UseStyleColors = true;
            this.txt_Email.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Email_Validating);
            // 
            // txt_Address
            // 
            this.txt_Address.IconRight = true;
            this.txt_Address.Lines = new string[0];
            this.txt_Address.Location = new System.Drawing.Point(124, 110);
            this.txt_Address.MaxLength = 32767;
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.PasswordChar = '\0';
            this.txt_Address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Address.SelectedText = "";
            this.txt_Address.Size = new System.Drawing.Size(187, 43);
            this.txt_Address.TabIndex = 27;
            this.txt_Address.UseSelectable = true;
            this.txt_Address.UseStyleColors = true;
            // 
            // txt_Name
            // 
            this.errorProvider1.SetError(this.txt_Name, "Please Enter a Name");
            this.txt_Name.IconRight = true;
            this.txt_Name.Lines = new string[0];
            this.txt_Name.Location = new System.Drawing.Point(124, 81);
            this.txt_Name.MaxLength = 32767;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Name.SelectedText = "";
            this.txt_Name.Size = new System.Drawing.Size(187, 22);
            this.txt_Name.TabIndex = 26;
            this.txt_Name.UseSelectable = true;
            this.txt_Name.UseStyleColors = true;
            this.txt_Name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Name_Validating);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(455, 112);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(114, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Business Address :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(455, 83);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(103, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "Business Name :";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(455, 170);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(59, 19);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "IsActive :";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(455, 141);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(113, 19);
            this.metroLabel10.TabIndex = 11;
            this.metroLabel10.Text = "Business Website :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(40, 83);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Name :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(40, 161);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Email :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(40, 190);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Contact No:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(40, 112);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Address :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(40, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(197, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Customer Information :";
            // 
            // PnlFooter
            // 
            this.PnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlFooter.Controls.Add(this.metroLabel11);
            this.PnlFooter.Controls.Add(this.Grid_Customer);
            this.PnlFooter.HorizontalScrollbarBarColor = true;
            this.PnlFooter.HorizontalScrollbarHighlightOnWheel = false;
            this.PnlFooter.HorizontalScrollbarSize = 10;
            this.PnlFooter.Location = new System.Drawing.Point(20, 379);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(790, 379);
            this.PnlFooter.TabIndex = 3;
            this.PnlFooter.VerticalScrollbarBarColor = true;
            this.PnlFooter.VerticalScrollbarHighlightOnWheel = false;
            this.PnlFooter.VerticalScrollbarSize = 10;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(40, 10);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(151, 25);
            this.metroLabel11.TabIndex = 3;
            this.metroLabel11.Text = "View All Records :";
            // 
            // Grid_Customer
            // 
            this.Grid_Customer.AllowUserToResizeColumns = false;
            this.Grid_Customer.AllowUserToResizeRows = false;
            this.Grid_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Customer.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Grid_Customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_Customer.CausesValidation = false;
            this.Grid_Customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grid_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.Email,
            this.BusinessName,
            this.IsActive,
            this.ImgEdit,
            this.ImgDel});
            this.Grid_Customer.GridColor = System.Drawing.Color.Silver;
            this.Grid_Customer.Location = new System.Drawing.Point(20, 50);
            this.Grid_Customer.Name = "Grid_Customer";
            this.Grid_Customer.ReadOnly = true;
            this.Grid_Customer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_Customer.Size = new System.Drawing.Size(750, 305);
            this.Grid_Customer.TabIndex = 2;
            this.Grid_Customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Customer_CellContentClick);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerID.DefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerName.DefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerName.HeaderText = "Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Email.DefaultCellStyle = dataGridViewCellStyle3;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // BusinessName
            // 
            this.BusinessName.DataPropertyName = "BusinessName";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.BusinessName.DefaultCellStyle = dataGridViewCellStyle4;
            this.BusinessName.HeaderText = "Business Name";
            this.BusinessName.Name = "BusinessName";
            this.BusinessName.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.IsActive.DefaultCellStyle = dataGridViewCellStyle5;
            this.IsActive.HeaderText = "IsActive";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // ImgEdit
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.ImgEdit.DefaultCellStyle = dataGridViewCellStyle6;
            this.ImgEdit.HeaderText = "Edit";
            this.ImgEdit.Image = global::InvoiceGenerator.Properties.Resources.icon_edit;
            this.ImgEdit.Name = "ImgEdit";
            this.ImgEdit.ReadOnly = true;
            this.ImgEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ImgDel
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.ImgDel.DefaultCellStyle = dataGridViewCellStyle7;
            this.ImgDel.HeaderText = "Delete";
            this.ImgDel.Image = global::InvoiceGenerator.Properties.Resources.icon_delete;
            this.ImgDel.Name = "ImgDel";
            this.ImgDel.ReadOnly = true;
            this.ImgDel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 82;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 109;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 150;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 800);
            this.Controls.Add(this.PnlFooter);
            this.Controls.Add(this.PnlHeader);
            this.MaximizeBox = false;
            this.Name = "frmCustomer";
            this.Resizable = false;
            this.Text = "      Add A Record";
            this.TransparencyKey = System.Drawing.Color.LightSteelBlue;
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.PnlFooter.ResumeLayout(false);
            this.PnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel PnlHeader;
        private MetroFramework.Controls.MetroPanel PnlFooter;
        private System.Windows.Forms.DataGridView Grid_Customer;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txt_Name;
        private MetroFramework.Controls.MetroTextBox txt_Address;
        private MetroFramework.Controls.MetroTextBox txt_Email;
        private MetroFramework.Controls.MetroTextBox txt_ContactNo;
        private MetroFramework.Controls.MetroTextBox txt_BWeb;
        private MetroFramework.Controls.MetroTextBox txt_BAddress;
        private MetroFramework.Controls.MetroTextBox txt_BName;
        private MetroFramework.Controls.MetroButton btn_Save;
        private MetroFramework.Controls.MetroRadioButton rdb_No;
        private MetroFramework.Controls.MetroRadioButton rdb_Yes;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;

        public static implicit operator frmCustomer(bool v)
        {
            throw new NotImplementedException();
        }
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusinessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewImageColumn ImgEdit;
        private System.Windows.Forms.DataGridViewImageColumn ImgDel;
    }
}

