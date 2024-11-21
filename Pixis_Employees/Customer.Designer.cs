namespace Pixis_Employees
{
    partial class Customer
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cUSTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cADDRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cZIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSCCARDNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSPYMTSTLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPWORDHASHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Pixis_Employees.DataSet2();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter = new Pixis_Employees.DataSet2TableAdapters.EMPLOYEETableAdapter();
            this.cUSTOMERTableAdapter = new Pixis_Employees.DataSet2TableAdapters.CUSTOMERTableAdapter();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(662, 465);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 31);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "&Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUSTNODataGridViewTextBoxColumn,
            this.cFNAMEDataGridViewTextBoxColumn,
            this.cLNAMEDataGridViewTextBoxColumn,
            this.cADDRDataGridViewTextBoxColumn,
            this.cCITYDataGridViewTextBoxColumn,
            this.cSTATEDataGridViewTextBoxColumn,
            this.cZIPDataGridViewTextBoxColumn,
            this.cPHONEDataGridViewTextBoxColumn,
            this.cEMAILDataGridViewTextBoxColumn,
            this.cDOBDataGridViewTextBoxColumn,
            this.cGENDERDataGridViewTextBoxColumn,
            this.cPWORDDataGridViewTextBoxColumn,
            this.cSCCARDNODataGridViewTextBoxColumn,
            this.cSPYMTSTLDataGridViewTextBoxColumn,
            this.cPWORDHASHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cUSTOMERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 431);
            this.dataGridView1.TabIndex = 11;
            // 
            // cUSTNODataGridViewTextBoxColumn
            // 
            this.cUSTNODataGridViewTextBoxColumn.DataPropertyName = "CUSTNO";
            this.cUSTNODataGridViewTextBoxColumn.HeaderText = "CUSTNO";
            this.cUSTNODataGridViewTextBoxColumn.Name = "cUSTNODataGridViewTextBoxColumn";
            // 
            // cFNAMEDataGridViewTextBoxColumn
            // 
            this.cFNAMEDataGridViewTextBoxColumn.DataPropertyName = "CFNAME";
            this.cFNAMEDataGridViewTextBoxColumn.HeaderText = "CFNAME";
            this.cFNAMEDataGridViewTextBoxColumn.Name = "cFNAMEDataGridViewTextBoxColumn";
            // 
            // cLNAMEDataGridViewTextBoxColumn
            // 
            this.cLNAMEDataGridViewTextBoxColumn.DataPropertyName = "CLNAME";
            this.cLNAMEDataGridViewTextBoxColumn.HeaderText = "CLNAME";
            this.cLNAMEDataGridViewTextBoxColumn.Name = "cLNAMEDataGridViewTextBoxColumn";
            // 
            // cADDRDataGridViewTextBoxColumn
            // 
            this.cADDRDataGridViewTextBoxColumn.DataPropertyName = "CADDR";
            this.cADDRDataGridViewTextBoxColumn.HeaderText = "CADDR";
            this.cADDRDataGridViewTextBoxColumn.Name = "cADDRDataGridViewTextBoxColumn";
            // 
            // cCITYDataGridViewTextBoxColumn
            // 
            this.cCITYDataGridViewTextBoxColumn.DataPropertyName = "CCITY";
            this.cCITYDataGridViewTextBoxColumn.HeaderText = "CCITY";
            this.cCITYDataGridViewTextBoxColumn.Name = "cCITYDataGridViewTextBoxColumn";
            // 
            // cSTATEDataGridViewTextBoxColumn
            // 
            this.cSTATEDataGridViewTextBoxColumn.DataPropertyName = "CSTATE";
            this.cSTATEDataGridViewTextBoxColumn.HeaderText = "CSTATE";
            this.cSTATEDataGridViewTextBoxColumn.Name = "cSTATEDataGridViewTextBoxColumn";
            // 
            // cZIPDataGridViewTextBoxColumn
            // 
            this.cZIPDataGridViewTextBoxColumn.DataPropertyName = "CZIP";
            this.cZIPDataGridViewTextBoxColumn.HeaderText = "CZIP";
            this.cZIPDataGridViewTextBoxColumn.Name = "cZIPDataGridViewTextBoxColumn";
            // 
            // cPHONEDataGridViewTextBoxColumn
            // 
            this.cPHONEDataGridViewTextBoxColumn.DataPropertyName = "CPHONE";
            this.cPHONEDataGridViewTextBoxColumn.HeaderText = "CPHONE";
            this.cPHONEDataGridViewTextBoxColumn.Name = "cPHONEDataGridViewTextBoxColumn";
            // 
            // cEMAILDataGridViewTextBoxColumn
            // 
            this.cEMAILDataGridViewTextBoxColumn.DataPropertyName = "CEMAIL";
            this.cEMAILDataGridViewTextBoxColumn.HeaderText = "CEMAIL";
            this.cEMAILDataGridViewTextBoxColumn.Name = "cEMAILDataGridViewTextBoxColumn";
            // 
            // cDOBDataGridViewTextBoxColumn
            // 
            this.cDOBDataGridViewTextBoxColumn.DataPropertyName = "CDOB";
            this.cDOBDataGridViewTextBoxColumn.HeaderText = "CDOB";
            this.cDOBDataGridViewTextBoxColumn.Name = "cDOBDataGridViewTextBoxColumn";
            // 
            // cGENDERDataGridViewTextBoxColumn
            // 
            this.cGENDERDataGridViewTextBoxColumn.DataPropertyName = "CGENDER";
            this.cGENDERDataGridViewTextBoxColumn.HeaderText = "CGENDER";
            this.cGENDERDataGridViewTextBoxColumn.Name = "cGENDERDataGridViewTextBoxColumn";
            // 
            // cPWORDDataGridViewTextBoxColumn
            // 
            this.cPWORDDataGridViewTextBoxColumn.DataPropertyName = "CPWORD";
            this.cPWORDDataGridViewTextBoxColumn.HeaderText = "CPWORD";
            this.cPWORDDataGridViewTextBoxColumn.Name = "cPWORDDataGridViewTextBoxColumn";
            // 
            // cSCCARDNODataGridViewTextBoxColumn
            // 
            this.cSCCARDNODataGridViewTextBoxColumn.DataPropertyName = "CSCCARDNO";
            this.cSCCARDNODataGridViewTextBoxColumn.HeaderText = "CSCCARDNO";
            this.cSCCARDNODataGridViewTextBoxColumn.Name = "cSCCARDNODataGridViewTextBoxColumn";
            // 
            // cSPYMTSTLDataGridViewTextBoxColumn
            // 
            this.cSPYMTSTLDataGridViewTextBoxColumn.DataPropertyName = "CSPYMTSTL";
            this.cSPYMTSTLDataGridViewTextBoxColumn.HeaderText = "CSPYMTSTL";
            this.cSPYMTSTLDataGridViewTextBoxColumn.Name = "cSPYMTSTLDataGridViewTextBoxColumn";
            // 
            // cPWORDHASHDataGridViewTextBoxColumn
            // 
            this.cPWORDHASHDataGridViewTextBoxColumn.DataPropertyName = "CPWORDHASH";
            this.cPWORDHASHDataGridViewTextBoxColumn.HeaderText = "CPWORDHASH";
            this.cPWORDHASHDataGridViewTextBoxColumn.Name = "cPWORDHASHDataGridViewTextBoxColumn";
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.dataSet2;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(256, 465);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(108, 31);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "&Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(144, 465);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(108, 31);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "&Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(32, 465);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(108, 31);
            this.btn_refresh.TabIndex = 14;
            this.btn_refresh.Text = "&Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 507);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Customer";
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customer_FormClosing);
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private DataSet2TableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private DataSet2TableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cADDRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cZIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSCCARDNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSPYMTSTLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPWORDHASHDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_refresh;
    }
}