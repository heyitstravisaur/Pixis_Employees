namespace Pixis_Employees
{
    partial class FlightStaff
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
            this.btnCheckStaff = new System.Windows.Forms.Button();
            this.txtboxFlightNum = new System.Windows.Forms.TextBox();
            this.dataSet1 = new Pixis_Employees.DataSet1();
            this.cREWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cREWTableAdapter = new Pixis_Employees.DataSet1TableAdapters.CREWTableAdapter();
            this.fLIGHTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREWCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pILOTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTTENDANTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESCLERKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAINTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jANITORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFUELINGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1100, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 102);
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
            this.fLIGHTNODataGridViewTextBoxColumn,
            this.cREWCODEDataGridViewTextBoxColumn,
            this.pILOTSDataGridViewTextBoxColumn,
            this.aTTENDANTSDataGridViewTextBoxColumn,
            this.rESCLERKDataGridViewTextBoxColumn,
            this.mAINTDataGridViewTextBoxColumn,
            this.jANITORDataGridViewTextBoxColumn,
            this.rEFUELINGDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cREWBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1271, 445);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnCheckStaff
            // 
            this.btnCheckStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckStaff.Location = new System.Drawing.Point(320, 12);
            this.btnCheckStaff.Name = "btnCheckStaff";
            this.btnCheckStaff.Size = new System.Drawing.Size(155, 103);
            this.btnCheckStaff.TabIndex = 12;
            this.btnCheckStaff.Text = "Check Staff on Flight";
            this.btnCheckStaff.UseVisualStyleBackColor = true;
            // 
            // txtboxFlightNum
            // 
            this.txtboxFlightNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFlightNum.Location = new System.Drawing.Point(12, 42);
            this.txtboxFlightNum.Name = "txtboxFlightNum";
            this.txtboxFlightNum.Size = new System.Drawing.Size(291, 35);
            this.txtboxFlightNum.TabIndex = 13;
            this.txtboxFlightNum.Text = "Enter Flight Number";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cREWBindingSource
            // 
            this.cREWBindingSource.DataMember = "CREW";
            this.cREWBindingSource.DataSource = this.dataSet1;
            // 
            // cREWTableAdapter
            // 
            this.cREWTableAdapter.ClearBeforeFill = true;
            // 
            // fLIGHTNODataGridViewTextBoxColumn
            // 
            this.fLIGHTNODataGridViewTextBoxColumn.DataPropertyName = "FLIGHTNO";
            this.fLIGHTNODataGridViewTextBoxColumn.HeaderText = "FLIGHTNO";
            this.fLIGHTNODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fLIGHTNODataGridViewTextBoxColumn.Name = "fLIGHTNODataGridViewTextBoxColumn";
            this.fLIGHTNODataGridViewTextBoxColumn.Width = 150;
            // 
            // cREWCODEDataGridViewTextBoxColumn
            // 
            this.cREWCODEDataGridViewTextBoxColumn.DataPropertyName = "CREWCODE";
            this.cREWCODEDataGridViewTextBoxColumn.HeaderText = "CREWCODE";
            this.cREWCODEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cREWCODEDataGridViewTextBoxColumn.Name = "cREWCODEDataGridViewTextBoxColumn";
            this.cREWCODEDataGridViewTextBoxColumn.Width = 150;
            // 
            // pILOTSDataGridViewTextBoxColumn
            // 
            this.pILOTSDataGridViewTextBoxColumn.DataPropertyName = "PILOTS";
            this.pILOTSDataGridViewTextBoxColumn.HeaderText = "PILOTS";
            this.pILOTSDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pILOTSDataGridViewTextBoxColumn.Name = "pILOTSDataGridViewTextBoxColumn";
            this.pILOTSDataGridViewTextBoxColumn.Width = 150;
            // 
            // aTTENDANTSDataGridViewTextBoxColumn
            // 
            this.aTTENDANTSDataGridViewTextBoxColumn.DataPropertyName = "ATTENDANTS";
            this.aTTENDANTSDataGridViewTextBoxColumn.HeaderText = "ATTENDANTS";
            this.aTTENDANTSDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aTTENDANTSDataGridViewTextBoxColumn.Name = "aTTENDANTSDataGridViewTextBoxColumn";
            this.aTTENDANTSDataGridViewTextBoxColumn.Width = 150;
            // 
            // rESCLERKDataGridViewTextBoxColumn
            // 
            this.rESCLERKDataGridViewTextBoxColumn.DataPropertyName = "RESCLERK";
            this.rESCLERKDataGridViewTextBoxColumn.HeaderText = "RESCLERK";
            this.rESCLERKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rESCLERKDataGridViewTextBoxColumn.Name = "rESCLERKDataGridViewTextBoxColumn";
            this.rESCLERKDataGridViewTextBoxColumn.Width = 150;
            // 
            // mAINTDataGridViewTextBoxColumn
            // 
            this.mAINTDataGridViewTextBoxColumn.DataPropertyName = "MAINT";
            this.mAINTDataGridViewTextBoxColumn.HeaderText = "MAINT";
            this.mAINTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mAINTDataGridViewTextBoxColumn.Name = "mAINTDataGridViewTextBoxColumn";
            this.mAINTDataGridViewTextBoxColumn.Width = 150;
            // 
            // jANITORDataGridViewTextBoxColumn
            // 
            this.jANITORDataGridViewTextBoxColumn.DataPropertyName = "JANITOR";
            this.jANITORDataGridViewTextBoxColumn.HeaderText = "JANITOR";
            this.jANITORDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jANITORDataGridViewTextBoxColumn.Name = "jANITORDataGridViewTextBoxColumn";
            this.jANITORDataGridViewTextBoxColumn.Width = 150;
            // 
            // rEFUELINGDataGridViewTextBoxColumn
            // 
            this.rEFUELINGDataGridViewTextBoxColumn.DataPropertyName = "REFUELING";
            this.rEFUELINGDataGridViewTextBoxColumn.HeaderText = "REFUELING";
            this.rEFUELINGDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rEFUELINGDataGridViewTextBoxColumn.Name = "rEFUELINGDataGridViewTextBoxColumn";
            this.rEFUELINGDataGridViewTextBoxColumn.Width = 150;
            // 
            // FlightStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 586);
            this.Controls.Add(this.txtboxFlightNum);
            this.Controls.Add(this.btnCheckStaff);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Name = "FlightStaff";
            this.Text = "FlightStaff";
            this.Load += new System.EventHandler(this.FlightStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCheckStaff;
        private System.Windows.Forms.TextBox txtboxFlightNum;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cREWBindingSource;
        private DataSet1TableAdapters.CREWTableAdapter cREWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLIGHTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREWCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pILOTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTTENDANTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESCLERKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAINTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jANITORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFUELINGDataGridViewTextBoxColumn;
    }
}