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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(377, 79);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 31);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 23);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Airport Code";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(135, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 23);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Airport Name";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(13, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 23);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Airport City";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(135, 75);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(117, 23);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Airport Country";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(266, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 47);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add Airport";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(266, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 47);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update Airport";
            this.btnUpdate.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(977, 150);
            this.dataGridView1.TabIndex = 17;
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
            // Airport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 295);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Airport";
            this.Text = "Aiport";
            this.Load += new System.EventHandler(this.Airport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
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
    }
}
