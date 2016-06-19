namespace InvoiceGenerator
{
    partial class frmDescription
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.Grid_Customer = new System.Windows.Forms.DataGridView();
            this.DescriptionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImgEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ImgDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_Save = new MetroFramework.Controls.MetroButton();
            this.txt_Description = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.PnlFooter = new MetroFramework.Controls.MetroPanel();
            this.PnlHeader = new MetroFramework.Controls.MetroPanel();
            this.Cmb_Customer = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_Code = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Customer)).BeginInit();
            this.PnlFooter.SuspendLayout();
            this.PnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(53, 12);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(160, 25);
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
            this.DescriptionID,
            this.CustomerName,
            this.Email,
            this.Description,
            this.ImgEdit,
            this.ImgDel});
            this.Grid_Customer.GridColor = System.Drawing.Color.Silver;
            this.Grid_Customer.Location = new System.Drawing.Point(27, 62);
            this.Grid_Customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Grid_Customer.Name = "Grid_Customer";
            this.Grid_Customer.ReadOnly = true;
            this.Grid_Customer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_Customer.Size = new System.Drawing.Size(1000, 375);
            this.Grid_Customer.TabIndex = 2;
            this.Grid_Customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Customer_CellContentClick);
            // 
            // DescriptionID
            // 
            this.DescriptionID.DataPropertyName = "DescriptionID";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DescriptionID.DefaultCellStyle = dataGridViewCellStyle1;
            this.DescriptionID.FillWeight = 38.06006F;
            this.DescriptionID.HeaderText = "Description ID";
            this.DescriptionID.Name = "DescriptionID";
            this.DescriptionID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerName.DefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerName.FillWeight = 49.75869F;
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
            this.Email.FillWeight = 64.62608F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 243.6549F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // ImgEdit
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ImgEdit.DefaultCellStyle = dataGridViewCellStyle4;
            this.ImgEdit.FillWeight = 93.86755F;
            this.ImgEdit.HeaderText = "Edit";
            this.ImgEdit.Image = global::InvoiceGenerator.Properties.Resources.icon_edit;
            this.ImgEdit.Name = "ImgEdit";
            this.ImgEdit.ReadOnly = true;
            this.ImgEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ImgDel
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.ImgDel.DefaultCellStyle = dataGridViewCellStyle5;
            this.ImgDel.FillWeight = 110.0329F;
            this.ImgDel.HeaderText = "Delete";
            this.ImgDel.Image = global::InvoiceGenerator.Properties.Resources.icon_delete;
            this.ImgDel.Name = "ImgDel";
            this.ImgDel.ReadOnly = true;
            this.ImgDel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btn_Save
            // 
            this.btn_Save.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Save.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Save.Highlight = true;
            this.btn_Save.Location = new System.Drawing.Point(852, 268);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(144, 31);
            this.btn_Save.TabIndex = 34;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseSelectable = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Description
            // 
            this.txt_Description.IconRight = true;
            this.txt_Description.Lines = new string[0];
            this.txt_Description.Location = new System.Drawing.Point(55, 140);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Description.MaxLength = 32767;
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.PasswordChar = '\0';
            this.txt_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Description.SelectedText = "";
            this.txt_Description.Size = new System.Drawing.Size(943, 110);
            this.txt_Description.TabIndex = 27;
            this.txt_Description.UseSelectable = true;
            this.txt_Description.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(55, 69);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 20);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Customer :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(53, 110);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Description :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(53, 12);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(206, 25);
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
            this.PnlFooter.HorizontalScrollbarSize = 12;
            this.PnlFooter.Location = new System.Drawing.Point(31, 423);
            this.PnlFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(1053, 466);
            this.PnlFooter.TabIndex = 5;
            this.PnlFooter.VerticalScrollbarBarColor = true;
            this.PnlFooter.VerticalScrollbarHighlightOnWheel = false;
            this.PnlFooter.VerticalScrollbarSize = 13;
            // 
            // PnlHeader
            // 
            this.PnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlHeader.Controls.Add(this.txt_Code);
            this.PnlHeader.Controls.Add(this.metroLabel1);
            this.PnlHeader.Controls.Add(this.Cmb_Customer);
            this.PnlHeader.Controls.Add(this.btn_Save);
            this.PnlHeader.Controls.Add(this.txt_Description);
            this.PnlHeader.Controls.Add(this.metroLabel6);
            this.PnlHeader.Controls.Add(this.metroLabel3);
            this.PnlHeader.Controls.Add(this.metroLabel2);
            this.PnlHeader.HorizontalScrollbarBarColor = true;
            this.PnlHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.PnlHeader.HorizontalScrollbarSize = 12;
            this.PnlHeader.Location = new System.Drawing.Point(31, 78);
            this.PnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1053, 323);
            this.PnlHeader.TabIndex = 4;
            this.PnlHeader.VerticalScrollbarBarColor = true;
            this.PnlHeader.VerticalScrollbarHighlightOnWheel = false;
            this.PnlHeader.VerticalScrollbarSize = 13;
            // 
            // Cmb_Customer
            // 
            this.Cmb_Customer.FormattingEnabled = true;
            this.Cmb_Customer.ItemHeight = 24;
            this.Cmb_Customer.Items.AddRange(new object[] {
            "Normal Combobox 1",
            "Normal Combobox 2",
            "Normal Combobox 3",
            "Normal Combobox 4"});
            this.Cmb_Customer.Location = new System.Drawing.Point(165, 62);
            this.Cmb_Customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_Customer.Name = "Cmb_Customer";
            this.Cmb_Customer.PromptText = "Select Customer";
            this.Cmb_Customer.Size = new System.Drawing.Size(261, 30);
            this.Cmb_Customer.TabIndex = 36;
            this.Cmb_Customer.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(448, 66);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 20);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "Code :";
            // 
            // txt_Code
            // 
            this.txt_Code.IconRight = true;
            this.txt_Code.Lines = new string[0];
            this.txt_Code.Location = new System.Drawing.Point(516, 62);
            this.txt_Code.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Code.MaxLength = 32767;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.PasswordChar = '\0';
            this.txt_Code.PromptText = "Code";
            this.txt_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Code.SelectedText = "";
            this.txt_Code.Size = new System.Drawing.Size(180, 31);
            this.txt_Code.TabIndex = 40;
            this.txt_Code.UseSelectable = true;
            this.txt_Code.UseStyleColors = true;
            // 
            // frmDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 900);
            this.Controls.Add(this.PnlFooter);
            this.Controls.Add(this.PnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDescription";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Description for Invoice";
            this.Load += new System.EventHandler(this.frmDescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Customer)).EndInit();
            this.PnlFooter.ResumeLayout(false);
            this.PnlFooter.PerformLayout();
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.DataGridView Grid_Customer;
        private MetroFramework.Controls.MetroButton btn_Save;
        private MetroFramework.Controls.MetroTextBox txt_Description;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel PnlFooter;
        private MetroFramework.Controls.MetroPanel PnlHeader;
        private MetroFramework.Controls.MetroComboBox Cmb_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewImageColumn ImgEdit;
        private System.Windows.Forms.DataGridViewImageColumn ImgDel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_Code;
    }
}