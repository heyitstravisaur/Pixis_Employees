namespace Pixis_Employees
{
    partial class Airport
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
            this.dataSet2 = new Pixis_Employees.DataSet2();
            this.aIRPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIRPORTTableAdapter = new Pixis_Employees.DataSet2TableAdapters.AIRPORTTableAdapter();
            this.aRCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRCITYNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRCNCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRFAACDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRICAOCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRLATITUDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRLNGITUDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRALTITUDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRTIMEZNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRTIMEZOFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(769, 25);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 31);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aRCDDataGridViewTextBoxColumn,
            this.aRNMDataGridViewTextBoxColumn,
            this.aRCITYNMDataGridViewTextBoxColumn,
            this.aRCNCDDataGridViewTextBoxColumn,
            this.aRFAACDDataGridViewTextBoxColumn,
            this.aRICAOCDDataGridViewTextBoxColumn,
            this.aRLATITUDEDataGridViewTextBoxColumn,
            this.aRLNGITUDEDataGridViewTextBoxColumn,
            this.aRALTITUDEDataGridViewTextBoxColumn,
            this.aRTIMEZNMDataGridViewTextBoxColumn,
            this.aRTIMEZOFDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aIRPORTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1148, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aIRPORTBindingSource
            // 
            this.aIRPORTBindingSource.DataMember = "AIRPORT";
            this.aIRPORTBindingSource.DataSource = this.dataSet2;
            // 
            // aIRPORTTableAdapter
            // 
            this.aIRPORTTableAdapter.ClearBeforeFill = true;
            // 
            // aRCDDataGridViewTextBoxColumn
            // 
            this.aRCDDataGridViewTextBoxColumn.DataPropertyName = "ARCD";
            this.aRCDDataGridViewTextBoxColumn.HeaderText = "ARCD";
            this.aRCDDataGridViewTextBoxColumn.Name = "aRCDDataGridViewTextBoxColumn";
            // 
            // aRNMDataGridViewTextBoxColumn
            // 
            this.aRNMDataGridViewTextBoxColumn.DataPropertyName = "ARNM";
            this.aRNMDataGridViewTextBoxColumn.HeaderText = "ARNM";
            this.aRNMDataGridViewTextBoxColumn.Name = "aRNMDataGridViewTextBoxColumn";
            // 
            // aRCITYNMDataGridViewTextBoxColumn
            // 
            this.aRCITYNMDataGridViewTextBoxColumn.DataPropertyName = "ARCITYNM";
            this.aRCITYNMDataGridViewTextBoxColumn.HeaderText = "ARCITYNM";
            this.aRCITYNMDataGridViewTextBoxColumn.Name = "aRCITYNMDataGridViewTextBoxColumn";
            // 
            // aRCNCDDataGridViewTextBoxColumn
            // 
            this.aRCNCDDataGridViewTextBoxColumn.DataPropertyName = "ARCNCD";
            this.aRCNCDDataGridViewTextBoxColumn.HeaderText = "ARCNCD";
            this.aRCNCDDataGridViewTextBoxColumn.Name = "aRCNCDDataGridViewTextBoxColumn";
            // 
            // aRFAACDDataGridViewTextBoxColumn
            // 
            this.aRFAACDDataGridViewTextBoxColumn.DataPropertyName = "ARFAACD";
            this.aRFAACDDataGridViewTextBoxColumn.HeaderText = "ARFAACD";
            this.aRFAACDDataGridViewTextBoxColumn.Name = "aRFAACDDataGridViewTextBoxColumn";
            // 
            // aRICAOCDDataGridViewTextBoxColumn
            // 
            this.aRICAOCDDataGridViewTextBoxColumn.DataPropertyName = "ARICAOCD";
            this.aRICAOCDDataGridViewTextBoxColumn.HeaderText = "ARICAOCD";
            this.aRICAOCDDataGridViewTextBoxColumn.Name = "aRICAOCDDataGridViewTextBoxColumn";
            // 
            // aRLATITUDEDataGridViewTextBoxColumn
            // 
            this.aRLATITUDEDataGridViewTextBoxColumn.DataPropertyName = "ARLATITUDE";
            this.aRLATITUDEDataGridViewTextBoxColumn.HeaderText = "ARLATITUDE";
            this.aRLATITUDEDataGridViewTextBoxColumn.Name = "aRLATITUDEDataGridViewTextBoxColumn";
            // 
            // aRLNGITUDEDataGridViewTextBoxColumn
            // 
            this.aRLNGITUDEDataGridViewTextBoxColumn.DataPropertyName = "ARLNGITUDE";
            this.aRLNGITUDEDataGridViewTextBoxColumn.HeaderText = "ARLNGITUDE";
            this.aRLNGITUDEDataGridViewTextBoxColumn.Name = "aRLNGITUDEDataGridViewTextBoxColumn";
            // 
            // aRALTITUDEDataGridViewTextBoxColumn
            // 
            this.aRALTITUDEDataGridViewTextBoxColumn.DataPropertyName = "ARALTITUDE";
            this.aRALTITUDEDataGridViewTextBoxColumn.HeaderText = "ARALTITUDE";
            this.aRALTITUDEDataGridViewTextBoxColumn.Name = "aRALTITUDEDataGridViewTextBoxColumn";
            // 
            // aRTIMEZNMDataGridViewTextBoxColumn
            // 
            this.aRTIMEZNMDataGridViewTextBoxColumn.DataPropertyName = "ARTIMEZNM";
            this.aRTIMEZNMDataGridViewTextBoxColumn.HeaderText = "ARTIMEZNM";
            this.aRTIMEZNMDataGridViewTextBoxColumn.Name = "aRTIMEZNMDataGridViewTextBoxColumn";
            // 
            // aRTIMEZOFDataGridViewTextBoxColumn
            // 
            this.aRTIMEZOFDataGridViewTextBoxColumn.DataPropertyName = "ARTIMEZOF";
            this.aRTIMEZOFDataGridViewTextBoxColumn.HeaderText = "ARTIMEZOF";
            this.aRTIMEZOFDataGridViewTextBoxColumn.Name = "aRTIMEZOFDataGridViewTextBoxColumn";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(453, 25);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 31);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Date";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(251, 36);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(108, 31);
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "Reload Table";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(49, 25);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 31);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update Table";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Airport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 594);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Airport";
            this.Text = "Aiport";
            this.Load += new System.EventHandler(this.Airport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource aIRPORTBindingSource;
        private DataSet2TableAdapters.AIRPORTTableAdapter aIRPORTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRCITYNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRCNCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRFAACDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRICAOCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRLATITUDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRLNGITUDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRALTITUDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRTIMEZNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRTIMEZOFDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnUpdate;
    }
}