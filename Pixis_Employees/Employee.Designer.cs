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
            this.rEGIONIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Pixis_Employees.DataSet1();
            this.eMPLOYEETableAdapter = new Pixis_Employees.DataSet1TableAdapters.EMPLOYEETableAdapter();
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
            this.button1.Text = "close";
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
            this.eMTERMDTDataGridViewTextBoxColumn,
            this.rEGIONIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eMPLOYEEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(864, 695);
            this.dataGridView1.TabIndex = 7;
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
            // rEGIONIDDataGridViewTextBoxColumn
            // 
            this.rEGIONIDDataGridViewTextBoxColumn.DataPropertyName = "REGIONID";
            this.rEGIONIDDataGridViewTextBoxColumn.HeaderText = "REGIONID";
            this.rEGIONIDDataGridViewTextBoxColumn.Name = "rEGIONIDDataGridViewTextBoxColumn";
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
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 754);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGIONIDDataGridViewTextBoxColumn;
    }
}