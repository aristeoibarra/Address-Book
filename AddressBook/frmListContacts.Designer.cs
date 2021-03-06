﻿
namespace AddressBook
{
    partial class frmListContacts
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.addressidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.directoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAddressBook = new AddressBook.dsAddressBook();
            this.directoryTableAdapter = new AddressBook.dsAddressBookTableAdapters.directoryTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateNew = new ReaLTaiizor.Controls.HopeButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAddressBook)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hopeForm1
            // 
            this.hopeForm1.ControlBoxColorH = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.hopeForm1.ControlBoxColorHC = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeForm1.ControlBoxColorN = System.Drawing.Color.White;
            this.hopeForm1.Cursor = System.Windows.Forms.Cursors.Default;
            this.hopeForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hopeForm1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.hopeForm1.Image = null;
            this.hopeForm1.Location = new System.Drawing.Point(0, 0);
            this.hopeForm1.MaximizeBox = false;
            this.hopeForm1.Name = "hopeForm1";
            this.hopeForm1.Size = new System.Drawing.Size(845, 40);
            this.hopeForm1.TabIndex = 1;
            this.hopeForm1.Text = "Address Book";
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoGenerateColumns = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.Column1,
            this.Column3,
            this.Column2});
            this.dgvData.DataSource = this.directoryBindingSource;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(845, 349);
            this.dgvData.TabIndex = 2;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // addressidDataGridViewTextBoxColumn
            // 
            this.addressidDataGridViewTextBoxColumn.DataPropertyName = "address_id";
            this.addressidDataGridViewTextBoxColumn.HeaderText = "address_id";
            this.addressidDataGridViewTextBoxColumn.Name = "addressidDataGridViewTextBoxColumn";
            this.addressidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Edit";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Text = " Details";
            this.Column3.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Delete";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // directoryBindingSource
            // 
            this.directoryBindingSource.DataMember = "directory";
            this.directoryBindingSource.DataSource = this.dsAddressBook;
            // 
            // dsAddressBook
            // 
            this.dsAddressBook.DataSetName = "dsAddressBook";
            this.dsAddressBook.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directoryTableAdapter
            // 
            this.directoryTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreateNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 53);
            this.panel1.TabIndex = 3;
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnCreateNew.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnCreateNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateNew.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnCreateNew.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreateNew.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCreateNew.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnCreateNew.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnCreateNew.Location = new System.Drawing.Point(12, 7);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnCreateNew.Size = new System.Drawing.Size(129, 40);
            this.btnCreateNew.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnCreateNew.TabIndex = 33;
            this.btnCreateNew.Text = "Create New";
            this.btnCreateNew.TextColor = System.Drawing.Color.White;
            this.btnCreateNew.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvData);
            this.splitContainer1.Size = new System.Drawing.Size(845, 406);
            this.splitContainer1.SplitterDistance = 53;
            this.splitContainer1.TabIndex = 4;
            // 
            // frmListContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(219)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(845, 446);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.hopeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 728);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "frmListContacts";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTheme1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAddressBook)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private System.Windows.Forms.DataGridView dgvData;
        private dsAddressBook dsAddressBook;
        private System.Windows.Forms.BindingSource directoryBindingSource;
        private dsAddressBookTableAdapters.directoryTableAdapter directoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.HopeButton btnCreateNew;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

