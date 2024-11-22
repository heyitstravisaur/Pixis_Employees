namespace Pixis_Employees
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
            this.lblPlaneNo = new System.Windows.Forms.Label();
            this.txtbxPlaneNo = new System.Windows.Forms.TextBox();
            this.lblMaxDist = new System.Windows.Forms.Label();
            this.lblAvail = new System.Windows.Forms.Label();
            this.lblCClass = new System.Windows.Forms.Label();
            this.lblPlaneMod = new System.Windows.Forms.Label();
            this.lblMSLM = new System.Windows.Forms.Label();
            this.lblPlaneMan = new System.Windows.Forms.Label();
            this.lblPAirpCode = new System.Windows.Forms.Label();
            this.lblAirpActDate = new System.Windows.Forms.Label();
            this.lblFClass = new System.Windows.Forms.Label();
            this.lblPlaceStat = new System.Windows.Forms.Label();
            this.lblDateLastMaint = new System.Windows.Forms.Label();
            this.txtbxMaxDist = new System.Windows.Forms.TextBox();
            this.txtbxFClass = new System.Windows.Forms.TextBox();
            this.txtbxCClass = new System.Windows.Forms.TextBox();
            this.txtbxAvail = new System.Windows.Forms.TextBox();
            this.txtbxMSLM = new System.Windows.Forms.TextBox();
            this.txtbxPlaneMod = new System.Windows.Forms.TextBox();
            this.txtbxPlaneMan = new System.Windows.Forms.TextBox();
            this.txtbxPAirpCode = new System.Windows.Forms.TextBox();
            this.txtbxAirActDate = new System.Windows.Forms.TextBox();
            this.txtbxStatus = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1113, 273);
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
            this.btnUpdate.Location = new System.Drawing.Point(682, 89);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 54);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update Table";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(559, 11);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "Reload List";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(640, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Data";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPlaneNo
            // 
            this.lblPlaneNo.AutoSize = true;
            this.lblPlaneNo.Location = new System.Drawing.Point(24, 6);
            this.lblPlaneNo.Name = "lblPlaneNo";
            this.lblPlaneNo.Size = new System.Drawing.Size(74, 13);
            this.lblPlaneNo.TabIndex = 15;
            this.lblPlaneNo.Text = "Plane Number";
            // 
            // txtbxPlaneNo
            // 
            this.txtbxPlaneNo.Location = new System.Drawing.Point(12, 22);
            this.txtbxPlaneNo.Name = "txtbxPlaneNo";
            this.txtbxPlaneNo.Size = new System.Drawing.Size(100, 20);
            this.txtbxPlaneNo.TabIndex = 16;
            // 
            // lblMaxDist
            // 
            this.lblMaxDist.AutoSize = true;
            this.lblMaxDist.Location = new System.Drawing.Point(11, 45);
            this.lblMaxDist.Name = "lblMaxDist";
            this.lblMaxDist.Size = new System.Drawing.Size(100, 13);
            this.lblMaxDist.TabIndex = 17;
            this.lblMaxDist.Text = "Max Flight Distance";
            // 
            // lblAvail
            // 
            this.lblAvail.AutoSize = true;
            this.lblAvail.Location = new System.Drawing.Point(22, 162);
            this.lblAvail.Name = "lblAvail";
            this.lblAvail.Size = new System.Drawing.Size(79, 13);
            this.lblAvail.TabIndex = 18;
            this.lblAvail.Text = "Avail for Sched";
            // 
            // lblCClass
            // 
            this.lblCClass.AutoSize = true;
            this.lblCClass.Location = new System.Drawing.Point(8, 123);
            this.lblCClass.Name = "lblCClass";
            this.lblCClass.Size = new System.Drawing.Size(106, 13);
            this.lblCClass.TabIndex = 19;
            this.lblCClass.Text = "# Coach Class Seats";
            // 
            // lblPlaneMod
            // 
            this.lblPlaneMod.AutoSize = true;
            this.lblPlaneMod.Location = new System.Drawing.Point(153, 6);
            this.lblPlaneMod.Name = "lblPlaneMod";
            this.lblPlaneMod.Size = new System.Drawing.Size(66, 13);
            this.lblPlaneMod.TabIndex = 20;
            this.lblPlaneMod.Text = "Plane Model";
            // 
            // lblMSLM
            // 
            this.lblMSLM.AutoSize = true;
            this.lblMSLM.Location = new System.Drawing.Point(5, 201);
            this.lblMSLM.Name = "lblMSLM";
            this.lblMSLM.Size = new System.Drawing.Size(113, 13);
            this.lblMSLM.TabIndex = 21;
            this.lblMSLM.Text = "Miles Since Last Maint";
            // 
            // lblPlaneMan
            // 
            this.lblPlaneMan.AutoSize = true;
            this.lblPlaneMan.Location = new System.Drawing.Point(136, 45);
            this.lblPlaneMan.Name = "lblPlaneMan";
            this.lblPlaneMan.Size = new System.Drawing.Size(100, 13);
            this.lblPlaneMan.TabIndex = 22;
            this.lblPlaneMan.Text = "Plane Manufacturer";
            // 
            // lblPAirpCode
            // 
            this.lblPAirpCode.AutoSize = true;
            this.lblPAirpCode.Location = new System.Drawing.Point(135, 84);
            this.lblPAirpCode.Name = "lblPAirpCode";
            this.lblPAirpCode.Size = new System.Drawing.Size(102, 13);
            this.lblPAirpCode.TabIndex = 23;
            this.lblPAirpCode.Text = "Primary Airport Code";
            // 
            // lblAirpActDate
            // 
            this.lblAirpActDate.AutoSize = true;
            this.lblAirpActDate.Location = new System.Drawing.Point(134, 123);
            this.lblAirpActDate.Name = "lblAirpActDate";
            this.lblAirpActDate.Size = new System.Drawing.Size(104, 13);
            this.lblAirpActDate.TabIndex = 24;
            this.lblAirpActDate.Text = "Airplane Active Date";
            // 
            // lblFClass
            // 
            this.lblFClass.AutoSize = true;
            this.lblFClass.Location = new System.Drawing.Point(14, 84);
            this.lblFClass.Name = "lblFClass";
            this.lblFClass.Size = new System.Drawing.Size(94, 13);
            this.lblFClass.TabIndex = 26;
            this.lblFClass.Text = "# First Class Seats";
            // 
            // lblPlaceStat
            // 
            this.lblPlaceStat.AutoSize = true;
            this.lblPlaceStat.Location = new System.Drawing.Point(113, 162);
            this.lblPlaceStat.Name = "lblPlaceStat";
            this.lblPlaceStat.Size = new System.Drawing.Size(147, 13);
            this.lblPlaceStat.TabIndex = 27;
            this.lblPlaceStat.Text = "Status (Active, Inactive, Sold)";
            // 
            // lblDateLastMaint
            // 
            this.lblDateLastMaint.AutoSize = true;
            this.lblDateLastMaint.Location = new System.Drawing.Point(139, 201);
            this.lblDateLastMaint.Name = "lblDateLastMaint";
            this.lblDateLastMaint.Size = new System.Drawing.Size(94, 13);
            this.lblDateLastMaint.TabIndex = 28;
            this.lblDateLastMaint.Text = "Date of Last Maint";
            // 
            // txtbxMaxDist
            // 
            this.txtbxMaxDist.Location = new System.Drawing.Point(12, 61);
            this.txtbxMaxDist.Name = "txtbxMaxDist";
            this.txtbxMaxDist.Size = new System.Drawing.Size(100, 20);
            this.txtbxMaxDist.TabIndex = 29;
            // 
            // txtbxFClass
            // 
            this.txtbxFClass.Location = new System.Drawing.Point(12, 100);
            this.txtbxFClass.Name = "txtbxFClass";
            this.txtbxFClass.Size = new System.Drawing.Size(100, 20);
            this.txtbxFClass.TabIndex = 30;
            // 
            // txtbxCClass
            // 
            this.txtbxCClass.Location = new System.Drawing.Point(12, 139);
            this.txtbxCClass.Name = "txtbxCClass";
            this.txtbxCClass.Size = new System.Drawing.Size(100, 20);
            this.txtbxCClass.TabIndex = 31;
            // 
            // txtbxAvail
            // 
            this.txtbxAvail.Location = new System.Drawing.Point(12, 178);
            this.txtbxAvail.Name = "txtbxAvail";
            this.txtbxAvail.Size = new System.Drawing.Size(100, 20);
            this.txtbxAvail.TabIndex = 32;
            // 
            // txtbxMSLM
            // 
            this.txtbxMSLM.Location = new System.Drawing.Point(11, 216);
            this.txtbxMSLM.Name = "txtbxMSLM";
            this.txtbxMSLM.Size = new System.Drawing.Size(100, 20);
            this.txtbxMSLM.TabIndex = 33;
            // 
            // txtbxPlaneMod
            // 
            this.txtbxPlaneMod.Location = new System.Drawing.Point(135, 22);
            this.txtbxPlaneMod.Name = "txtbxPlaneMod";
            this.txtbxPlaneMod.Size = new System.Drawing.Size(100, 20);
            this.txtbxPlaneMod.TabIndex = 34;
            // 
            // txtbxPlaneMan
            // 
            this.txtbxPlaneMan.Location = new System.Drawing.Point(135, 61);
            this.txtbxPlaneMan.Name = "txtbxPlaneMan";
            this.txtbxPlaneMan.Size = new System.Drawing.Size(100, 20);
            this.txtbxPlaneMan.TabIndex = 35;
            // 
            // txtbxPAirpCode
            // 
            this.txtbxPAirpCode.Location = new System.Drawing.Point(135, 100);
            this.txtbxPAirpCode.Name = "txtbxPAirpCode";
            this.txtbxPAirpCode.Size = new System.Drawing.Size(100, 20);
            this.txtbxPAirpCode.TabIndex = 36;
            // 
            // txtbxAirActDate
            // 
            this.txtbxAirActDate.Location = new System.Drawing.Point(135, 139);
            this.txtbxAirActDate.Name = "txtbxAirActDate";
            this.txtbxAirActDate.Size = new System.Drawing.Size(100, 20);
            this.txtbxAirActDate.TabIndex = 37;
            // 
            // txtbxStatus
            // 
            this.txtbxStatus.Location = new System.Drawing.Point(135, 178);
            this.txtbxStatus.Name = "txtbxStatus";
            this.txtbxStatus.Size = new System.Drawing.Size(100, 20);
            this.txtbxStatus.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 39;
            // 
            // Airplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 527);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtbxStatus);
            this.Controls.Add(this.txtbxAirActDate);
            this.Controls.Add(this.txtbxPAirpCode);
            this.Controls.Add(this.txtbxPlaneMan);
            this.Controls.Add(this.txtbxPlaneMod);
            this.Controls.Add(this.txtbxMSLM);
            this.Controls.Add(this.txtbxAvail);
            this.Controls.Add(this.txtbxCClass);
            this.Controls.Add(this.txtbxFClass);
            this.Controls.Add(this.txtbxMaxDist);
            this.Controls.Add(this.lblDateLastMaint);
            this.Controls.Add(this.lblPlaceStat);
            this.Controls.Add(this.lblFClass);
            this.Controls.Add(this.lblAirpActDate);
            this.Controls.Add(this.lblPAirpCode);
            this.Controls.Add(this.lblPlaneMan);
            this.Controls.Add(this.lblMSLM);
            this.Controls.Add(this.lblPlaneMod);
            this.Controls.Add(this.lblCClass);
            this.Controls.Add(this.lblAvail);
            this.Controls.Add(this.lblMaxDist);
            this.Controls.Add(this.txtbxPlaneNo);
            this.Controls.Add(this.lblPlaneNo);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblPlaneNo;
        private System.Windows.Forms.TextBox txtbxPlaneNo;
        private System.Windows.Forms.Label lblMaxDist;
        private System.Windows.Forms.Label lblAvail;
        private System.Windows.Forms.Label lblCClass;
        private System.Windows.Forms.Label lblPlaneMod;
        private System.Windows.Forms.Label lblMSLM;
        private System.Windows.Forms.Label lblPlaneMan;
        private System.Windows.Forms.Label lblPAirpCode;
        private System.Windows.Forms.Label lblAirpActDate;
        private System.Windows.Forms.Label lblFClass;
        private System.Windows.Forms.Label lblPlaceStat;
        private System.Windows.Forms.Label lblDateLastMaint;
        private System.Windows.Forms.TextBox txtbxMaxDist;
        private System.Windows.Forms.TextBox txtbxFClass;
        private System.Windows.Forms.TextBox txtbxCClass;
        private System.Windows.Forms.TextBox txtbxAvail;
        private System.Windows.Forms.TextBox txtbxMSLM;
        private System.Windows.Forms.TextBox txtbxPlaneMod;
        private System.Windows.Forms.TextBox txtbxPlaneMan;
        private System.Windows.Forms.TextBox txtbxPAirpCode;
        private System.Windows.Forms.TextBox txtbxAirActDate;
        private System.Windows.Forms.TextBox txtbxStatus;
        private System.Windows.Forms.TextBox textBox1;
    }
}