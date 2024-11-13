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
            this.btnCheckStaff = new System.Windows.Forms.Button();
            this.txtboxFlightNum = new System.Windows.Forms.TextBox();
            this.lboxStaff = new System.Windows.Forms.ListBox();
            this.cREWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Pixis_Employees.DataSet1();
            this.cREWTableAdapter = new Pixis_Employees.DataSet1TableAdapters.CREWTableAdapter();
            this.dataSet2 = new Pixis_Employees.DataSet2();
            this.cREWBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cREWTableAdapter1 = new Pixis_Employees.DataSet2TableAdapters.CREWTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cREWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREWBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(315, 303);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 66);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCheckStaff
            // 
            this.btnCheckStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckStaff.Location = new System.Drawing.Point(315, 11);
            this.btnCheckStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckStaff.Name = "btnCheckStaff";
            this.btnCheckStaff.Size = new System.Drawing.Size(103, 67);
            this.btnCheckStaff.TabIndex = 12;
            this.btnCheckStaff.Text = "Check Staff on Flight";
            this.btnCheckStaff.UseVisualStyleBackColor = true;
            this.btnCheckStaff.Click += new System.EventHandler(this.btnCheckStaff_Click);
            // 
            // txtboxFlightNum
            // 
            this.txtboxFlightNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFlightNum.Location = new System.Drawing.Point(53, 31);
            this.txtboxFlightNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxFlightNum.Name = "txtboxFlightNum";
            this.txtboxFlightNum.Size = new System.Drawing.Size(195, 26);
            this.txtboxFlightNum.TabIndex = 13;
            this.txtboxFlightNum.Text = "Enter Flight Number";
            // 
            // lboxStaff
            // 
            this.lboxStaff.FormattingEnabled = true;
            this.lboxStaff.Location = new System.Drawing.Point(12, 92);
            this.lboxStaff.Name = "lboxStaff";
            this.lboxStaff.Size = new System.Drawing.Size(268, 277);
            this.lboxStaff.TabIndex = 14;
            // 
            // cREWBindingSource
            // 
            this.cREWBindingSource.DataMember = "CREW";
            this.cREWBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cREWTableAdapter
            // 
            this.cREWTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cREWBindingSource1
            // 
            this.cREWBindingSource1.DataMember = "CREW";
            this.cREWBindingSource1.DataSource = this.dataSet2;
            // 
            // cREWTableAdapter1
            // 
            this.cREWTableAdapter1.ClearBeforeFill = true;
            // 
            // FlightStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 381);
            this.Controls.Add(this.lboxStaff);
            this.Controls.Add(this.txtboxFlightNum);
            this.Controls.Add(this.btnCheckStaff);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FlightStaff";
            this.Text = "FlightStaff";
            this.Load += new System.EventHandler(this.FlightStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cREWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREWBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCheckStaff;
        private System.Windows.Forms.TextBox txtboxFlightNum;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cREWBindingSource;
        private DataSet1TableAdapters.CREWTableAdapter cREWTableAdapter;
        private System.Windows.Forms.ListBox lboxStaff;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource cREWBindingSource1;
        private DataSet2TableAdapters.CREWTableAdapter cREWTableAdapter1;
    }
}
