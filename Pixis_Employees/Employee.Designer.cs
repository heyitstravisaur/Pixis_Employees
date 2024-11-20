namespace Pixis_Employees
{
    partial class Employee
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rEGIONIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eADDRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eZIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRKSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLYRATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMHIREDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMSTARTDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMTERMDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Pixis_Employees.DataSet1();
            this.eMPLOYEETableAdapter = new Pixis_Employees.DataSet1TableAdapters.EMPLOYEETableAdapter();
            this.txt_filter_regionid = new System.Windows.Forms.TextBox();
            this.lbl_filter = new System.Windows.Forms.Label();
            this.txt_filter_empno = new System.Windows.Forms.TextBox();
            this.txt_filter_efname = new System.Windows.Forms.TextBox();
            this.txt_filter_elname = new System.Windows.Forms.TextBox();
            this.txt_filter_eaddr = new System.Windows.Forms.TextBox();
            this.txt_filter_ecity = new System.Windows.Forms.TextBox();
            this.txt_filter_estate = new System.Windows.Forms.TextBox();
            this.txt_filter_ezip = new System.Windows.Forms.TextBox();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.lbl_region = new System.Windows.Forms.Label();
            this.btn_employees_from_region = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 707);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(227, 707);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 36);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(119, 707);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(11, 707);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(104, 36);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rEGIONIDDataGridViewTextBoxColumn,
            this.eMPNODataGridViewTextBoxColumn,
            this.eFNAMEDataGridViewTextBoxColumn,
            this.eLNAMEDataGridViewTextBoxColumn,
            this.eADDRDataGridViewTextBoxColumn,
            this.eCITYDataGridViewTextBoxColumn,
            this.eSTATEDataGridViewTextBoxColumn,
            this.eZIPDataGridViewTextBoxColumn,
            this.ePHONEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.gENDERDataGridViewTextBoxColumn,
            this.jOBIDDataGridViewTextBoxColumn,
            this.wRKSTATUSDataGridViewTextBoxColumn,
            this.hRLYRATEDataGridViewTextBoxColumn,
            this.eMHIREDTDataGridViewTextBoxColumn,
            this.eMSTARTDTDataGridViewTextBoxColumn,
            this.eMTERMDTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eMPLOYEEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(864, 622);
            this.dataGridView1.TabIndex = 7;
            // 
            // rEGIONIDDataGridViewTextBoxColumn
            // 
            this.rEGIONIDDataGridViewTextBoxColumn.DataPropertyName = "REGIONID";
            this.rEGIONIDDataGridViewTextBoxColumn.HeaderText = "REGIONID";
            this.rEGIONIDDataGridViewTextBoxColumn.Name = "rEGIONIDDataGridViewTextBoxColumn";
            // 
            // eMPNODataGridViewTextBoxColumn
            // 
            this.eMPNODataGridViewTextBoxColumn.DataPropertyName = "EMPNO";
            this.eMPNODataGridViewTextBoxColumn.HeaderText = "EMPNO";
            this.eMPNODataGridViewTextBoxColumn.Name = "eMPNODataGridViewTextBoxColumn";
            // 
            // eFNAMEDataGridViewTextBoxColumn
            // 
            this.eFNAMEDataGridViewTextBoxColumn.DataPropertyName = "EFNAME";
            this.eFNAMEDataGridViewTextBoxColumn.HeaderText = "EFNAME";
            this.eFNAMEDataGridViewTextBoxColumn.Name = "eFNAMEDataGridViewTextBoxColumn";
            // 
            // eLNAMEDataGridViewTextBoxColumn
            // 
            this.eLNAMEDataGridViewTextBoxColumn.DataPropertyName = "ELNAME";
            this.eLNAMEDataGridViewTextBoxColumn.HeaderText = "ELNAME";
            this.eLNAMEDataGridViewTextBoxColumn.Name = "eLNAMEDataGridViewTextBoxColumn";
            // 
            // eADDRDataGridViewTextBoxColumn
            // 
            this.eADDRDataGridViewTextBoxColumn.DataPropertyName = "EADDR";
            this.eADDRDataGridViewTextBoxColumn.HeaderText = "EADDR";
            this.eADDRDataGridViewTextBoxColumn.Name = "eADDRDataGridViewTextBoxColumn";
            // 
            // eCITYDataGridViewTextBoxColumn
            // 
            this.eCITYDataGridViewTextBoxColumn.DataPropertyName = "ECITY";
            this.eCITYDataGridViewTextBoxColumn.HeaderText = "ECITY";
            this.eCITYDataGridViewTextBoxColumn.Name = "eCITYDataGridViewTextBoxColumn";
            // 
            // eSTATEDataGridViewTextBoxColumn
            // 
            this.eSTATEDataGridViewTextBoxColumn.DataPropertyName = "ESTATE";
            this.eSTATEDataGridViewTextBoxColumn.HeaderText = "ESTATE";
            this.eSTATEDataGridViewTextBoxColumn.Name = "eSTATEDataGridViewTextBoxColumn";
            // 
            // eZIPDataGridViewTextBoxColumn
            // 
            this.eZIPDataGridViewTextBoxColumn.DataPropertyName = "EZIP";
            this.eZIPDataGridViewTextBoxColumn.HeaderText = "EZIP";
            this.eZIPDataGridViewTextBoxColumn.Name = "eZIPDataGridViewTextBoxColumn";
            // 
            // ePHONEDataGridViewTextBoxColumn
            // 
            this.ePHONEDataGridViewTextBoxColumn.DataPropertyName = "EPHONE";
            this.ePHONEDataGridViewTextBoxColumn.HeaderText = "EPHONE";
            this.ePHONEDataGridViewTextBoxColumn.Name = "ePHONEDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // gENDERDataGridViewTextBoxColumn
            // 
            this.gENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.HeaderText = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.Name = "gENDERDataGridViewTextBoxColumn";
            // 
            // jOBIDDataGridViewTextBoxColumn
            // 
            this.jOBIDDataGridViewTextBoxColumn.DataPropertyName = "JOBID";
            this.jOBIDDataGridViewTextBoxColumn.HeaderText = "JOBID";
            this.jOBIDDataGridViewTextBoxColumn.Name = "jOBIDDataGridViewTextBoxColumn";
            // 
            // wRKSTATUSDataGridViewTextBoxColumn
            // 
            this.wRKSTATUSDataGridViewTextBoxColumn.DataPropertyName = "WRKSTATUS";
            this.wRKSTATUSDataGridViewTextBoxColumn.HeaderText = "WRKSTATUS";
            this.wRKSTATUSDataGridViewTextBoxColumn.Name = "wRKSTATUSDataGridViewTextBoxColumn";
            // 
            // hRLYRATEDataGridViewTextBoxColumn
            // 
            this.hRLYRATEDataGridViewTextBoxColumn.DataPropertyName = "HRLYRATE";
            this.hRLYRATEDataGridViewTextBoxColumn.HeaderText = "HRLYRATE";
            this.hRLYRATEDataGridViewTextBoxColumn.Name = "hRLYRATEDataGridViewTextBoxColumn";
            // 
            // eMHIREDTDataGridViewTextBoxColumn
            // 
            this.eMHIREDTDataGridViewTextBoxColumn.DataPropertyName = "EMHIREDT";
            this.eMHIREDTDataGridViewTextBoxColumn.HeaderText = "EMHIREDT";
            this.eMHIREDTDataGridViewTextBoxColumn.Name = "eMHIREDTDataGridViewTextBoxColumn";
            // 
            // eMSTARTDTDataGridViewTextBoxColumn
            // 
            this.eMSTARTDTDataGridViewTextBoxColumn.DataPropertyName = "EMSTARTDT";
            this.eMSTARTDTDataGridViewTextBoxColumn.HeaderText = "EMSTARTDT";
            this.eMSTARTDTDataGridViewTextBoxColumn.Name = "eMSTARTDTDataGridViewTextBoxColumn";
            // 
            // eMTERMDTDataGridViewTextBoxColumn
            // 
            this.eMTERMDTDataGridViewTextBoxColumn.DataPropertyName = "EMTERMDT";
            this.eMTERMDTDataGridViewTextBoxColumn.HeaderText = "EMTERMDT";
            this.eMTERMDTDataGridViewTextBoxColumn.Name = "eMTERMDTDataGridViewTextBoxColumn";
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // txt_filter_regionid
            // 
            this.txt_filter_regionid.Location = new System.Drawing.Point(74, 56);
            this.txt_filter_regionid.Name = "txt_filter_regionid";
            this.txt_filter_regionid.Size = new System.Drawing.Size(95, 20);
            this.txt_filter_regionid.TabIndex = 8;
            this.txt_filter_regionid.TextChanged += new System.EventHandler(this.txt_filter_regionid_TextChanged);
            // 
            // lbl_filter
            // 
            this.lbl_filter.AutoSize = true;
            this.lbl_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filter.Location = new System.Drawing.Point(13, 56);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(55, 20);
            this.lbl_filter.TabIndex = 9;
            this.lbl_filter.Text = "Filter:";
            // 
            // txt_filter_empno
            // 
            this.txt_filter_empno.Location = new System.Drawing.Point(175, 56);
            this.txt_filter_empno.Name = "txt_filter_empno";
            this.txt_filter_empno.Size = new System.Drawing.Size(95, 20);
            this.txt_filter_empno.TabIndex = 10;
            this.txt_filter_empno.TextChanged += new System.EventHandler(this.txt_filter_empno_TextChanged);
            // 
            // txt_filter_efname
            // 
            this.txt_filter_efname.Location = new System.Drawing.Point(276, 56);
            this.txt_filter_efname.Name = "txt_filter_efname";
            this.txt_filter_efname.Size = new System.Drawing.Size(95, 20);
            this.txt_filter_efname.TabIndex = 11;
            this.txt_filter_efname.TextChanged += new System.EventHandler(this.txt_filter_efname_TextChanged);
            // 
            // txt_filter_elname
            // 
            this.txt_filter_elname.Location = new System.Drawing.Point(377, 56);
            this.txt_filter_elname.Name = "txt_filter_elname";
            this.txt_filter_elname.Size = new System.Drawing.Size(95, 20);
            this.txt_filter_elname.TabIndex = 12;
            this.txt_filter_elname.TextChanged += new System.EventHandler(this.txt_filter_elname_TextChanged);
            // 
            // txt_filter_eaddr
            // 
            this.txt_filter_eaddr.Location = new System.Drawing.Point(478, 56);
            this.txt_filter_eaddr.Name = "txt_filter_eaddr";
            this.txt_filter_eaddr.Size = new System.Drawing.Size(91, 20);
            this.txt_filter_eaddr.TabIndex = 13;
            this.txt_filter_eaddr.TextChanged += new System.EventHandler(this.txt_filter_eaddr_TextChanged);
            // 
            // txt_filter_ecity
            // 
            this.txt_filter_ecity.Location = new System.Drawing.Point(575, 56);
            this.txt_filter_ecity.Name = "txt_filter_ecity";
            this.txt_filter_ecity.Size = new System.Drawing.Size(100, 20);
            this.txt_filter_ecity.TabIndex = 14;
            this.txt_filter_ecity.TextChanged += new System.EventHandler(this.txt_filter_ecity_TextChanged);
            // 
            // txt_filter_estate
            // 
            this.txt_filter_estate.Location = new System.Drawing.Point(681, 56);
            this.txt_filter_estate.Name = "txt_filter_estate";
            this.txt_filter_estate.Size = new System.Drawing.Size(91, 20);
            this.txt_filter_estate.TabIndex = 15;
            this.txt_filter_estate.TextChanged += new System.EventHandler(this.txt_filter_estate_TextChanged);
            // 
            // txt_filter_ezip
            // 
            this.txt_filter_ezip.Location = new System.Drawing.Point(778, 56);
            this.txt_filter_ezip.Name = "txt_filter_ezip";
            this.txt_filter_ezip.Size = new System.Drawing.Size(93, 20);
            this.txt_filter_ezip.TabIndex = 16;
            this.txt_filter_ezip.TextChanged += new System.EventHandler(this.txt_filter_ezip_TextChanged);
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(119, 15);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRegion.TabIndex = 17;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // lbl_region
            // 
            this.lbl_region.AutoSize = true;
            this.lbl_region.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_region.Location = new System.Drawing.Point(42, 16);
            this.lbl_region.Name = "lbl_region";
            this.lbl_region.Size = new System.Drawing.Size(71, 20);
            this.lbl_region.TabIndex = 18;
            this.lbl_region.Text = "Region:";
            // 
            // btn_employees_from_region
            // 
            this.btn_employees_from_region.Location = new System.Drawing.Point(246, 12);
            this.btn_employees_from_region.Name = "btn_employees_from_region";
            this.btn_employees_from_region.Size = new System.Drawing.Size(172, 27);
            this.btn_employees_from_region.TabIndex = 19;
            this.btn_employees_from_region.Text = "See Employees From Region";
            this.btn_employees_from_region.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 754);
            this.Controls.Add(this.btn_employees_from_region);
            this.Controls.Add(this.lbl_region);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.txt_filter_ezip);
            this.Controls.Add(this.txt_filter_estate);
            this.Controls.Add(this.txt_filter_ecity);
            this.Controls.Add(this.txt_filter_eaddr);
            this.Controls.Add(this.txt_filter_elname);
            this.Controls.Add(this.txt_filter_efname);
            this.Controls.Add(this.txt_filter_empno);
            this.Controls.Add(this.lbl_filter);
            this.Controls.Add(this.txt_filter_regionid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Employee";
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private DataSet1TableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGIONIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eADDRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eZIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRKSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hRLYRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMHIREDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMSTARTDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMTERMDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_filter_regionid;
        private System.Windows.Forms.Label lbl_filter;
        private System.Windows.Forms.TextBox txt_filter_empno;
        private System.Windows.Forms.TextBox txt_filter_efname;
        private System.Windows.Forms.TextBox txt_filter_elname;
        private System.Windows.Forms.TextBox txt_filter_eaddr;
        private System.Windows.Forms.TextBox txt_filter_ecity;
        private System.Windows.Forms.TextBox txt_filter_estate;
        private System.Windows.Forms.TextBox txt_filter_ezip;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.Label lbl_region;
        private System.Windows.Forms.Button btn_employees_from_region;
    }
}