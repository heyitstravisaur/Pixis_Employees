﻿namespace Pixis_Employees
{
    partial class Airplane
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
            this.pLANENODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAXDISTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCLASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCLASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAVAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAINTMILESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANEMODELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMAKEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPARCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPACTDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPIACTDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEMAINTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIRPLANEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Pixis_Employees.DataSet2();
            this.aIRPLANETableAdapter = new Pixis_Employees.DataSet2TableAdapters.AIRPLANETableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPLANEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(813, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
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
            this.pLANENODataGridViewTextBoxColumn,
            this.mAXDISTDataGridViewTextBoxColumn,
            this.fCLASSDataGridViewTextBoxColumn,
            this.cCLASSDataGridViewTextBoxColumn,
            this.pAVAILDataGridViewTextBoxColumn,
            this.mAINTMILESDataGridViewTextBoxColumn,
            this.pLANEMODELDataGridViewTextBoxColumn,
            this.pMAKEDataGridViewTextBoxColumn,
            this.aPARCDDataGridViewTextBoxColumn,
            this.aPACTDTDataGridViewTextBoxColumn,
            this.aPIACTDTDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn,
            this.dATEMAINTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aIRPLANEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1351, 395);
            this.dataGridView1.TabIndex = 11;
            // 
            // pLANENODataGridViewTextBoxColumn
            // 
            this.pLANENODataGridViewTextBoxColumn.DataPropertyName = "PLANENO";
            this.pLANENODataGridViewTextBoxColumn.HeaderText = "PLANENO";
            this.pLANENODataGridViewTextBoxColumn.Name = "pLANENODataGridViewTextBoxColumn";
            // 
            // mAXDISTDataGridViewTextBoxColumn
            // 
            this.mAXDISTDataGridViewTextBoxColumn.DataPropertyName = "MAXDIST";
            this.mAXDISTDataGridViewTextBoxColumn.HeaderText = "MAXDIST";
            this.mAXDISTDataGridViewTextBoxColumn.Name = "mAXDISTDataGridViewTextBoxColumn";
            // 
            // fCLASSDataGridViewTextBoxColumn
            // 
            this.fCLASSDataGridViewTextBoxColumn.DataPropertyName = "FCLASS";
            this.fCLASSDataGridViewTextBoxColumn.HeaderText = "FCLASS";
            this.fCLASSDataGridViewTextBoxColumn.Name = "fCLASSDataGridViewTextBoxColumn";
            // 
            // cCLASSDataGridViewTextBoxColumn
            // 
            this.cCLASSDataGridViewTextBoxColumn.DataPropertyName = "CCLASS";
            this.cCLASSDataGridViewTextBoxColumn.HeaderText = "CCLASS";
            this.cCLASSDataGridViewTextBoxColumn.Name = "cCLASSDataGridViewTextBoxColumn";
            // 
            // pAVAILDataGridViewTextBoxColumn
            // 
            this.pAVAILDataGridViewTextBoxColumn.DataPropertyName = "PAVAIL";
            this.pAVAILDataGridViewTextBoxColumn.HeaderText = "PAVAIL";
            this.pAVAILDataGridViewTextBoxColumn.Name = "pAVAILDataGridViewTextBoxColumn";
            // 
            // mAINTMILESDataGridViewTextBoxColumn
            // 
            this.mAINTMILESDataGridViewTextBoxColumn.DataPropertyName = "MAINTMILES";
            this.mAINTMILESDataGridViewTextBoxColumn.HeaderText = "MAINTMILES";
            this.mAINTMILESDataGridViewTextBoxColumn.Name = "mAINTMILESDataGridViewTextBoxColumn";
            // 
            // pLANEMODELDataGridViewTextBoxColumn
            // 
            this.pLANEMODELDataGridViewTextBoxColumn.DataPropertyName = "PLANEMODEL";
            this.pLANEMODELDataGridViewTextBoxColumn.HeaderText = "PLANEMODEL";
            this.pLANEMODELDataGridViewTextBoxColumn.Name = "pLANEMODELDataGridViewTextBoxColumn";
            // 
            // pMAKEDataGridViewTextBoxColumn
            // 
            this.pMAKEDataGridViewTextBoxColumn.DataPropertyName = "PMAKE";
            this.pMAKEDataGridViewTextBoxColumn.HeaderText = "PMAKE";
            this.pMAKEDataGridViewTextBoxColumn.Name = "pMAKEDataGridViewTextBoxColumn";
            // 
            // aPARCDDataGridViewTextBoxColumn
            // 
            this.aPARCDDataGridViewTextBoxColumn.DataPropertyName = "APARCD";
            this.aPARCDDataGridViewTextBoxColumn.HeaderText = "APARCD";
            this.aPARCDDataGridViewTextBoxColumn.Name = "aPARCDDataGridViewTextBoxColumn";
            // 
            // aPACTDTDataGridViewTextBoxColumn
            // 
            this.aPACTDTDataGridViewTextBoxColumn.DataPropertyName = "APACTDT";
            this.aPACTDTDataGridViewTextBoxColumn.HeaderText = "APACTDT";
            this.aPACTDTDataGridViewTextBoxColumn.Name = "aPACTDTDataGridViewTextBoxColumn";
            // 
            // aPIACTDTDataGridViewTextBoxColumn
            // 
            this.aPIACTDTDataGridViewTextBoxColumn.DataPropertyName = "APIACTDT";
            this.aPIACTDTDataGridViewTextBoxColumn.HeaderText = "APIACTDT";
            this.aPIACTDTDataGridViewTextBoxColumn.Name = "aPIACTDTDataGridViewTextBoxColumn";
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            // 
            // dATEMAINTDataGridViewTextBoxColumn
            // 
            this.dATEMAINTDataGridViewTextBoxColumn.DataPropertyName = "DATEMAINT";
            this.dATEMAINTDataGridViewTextBoxColumn.HeaderText = "DATEMAINT";
            this.dATEMAINTDataGridViewTextBoxColumn.Name = "dATEMAINTDataGridViewTextBoxColumn";
            // 
            // aIRPLANEBindingSource
            // 
            this.aIRPLANEBindingSource.DataMember = "AIRPLANE";
            this.aIRPLANEBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aIRPLANETableAdapter
            // 
            this.aIRPLANETableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 103);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update Table";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(263, 11);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(151, 103);
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "Reload Table";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(508, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 103);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Data";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Airplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 527);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Airplane";
            this.Text = "Airplane";
            this.Load += new System.EventHandler(this.Airplane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPLANEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource aIRPLANEBindingSource;
        private DataSet2TableAdapters.AIRPLANETableAdapter aIRPLANETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANENODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAXDISTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCLASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCLASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAVAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAINTMILESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANEMODELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMAKEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPARCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPACTDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPIACTDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEMAINTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
    }
}