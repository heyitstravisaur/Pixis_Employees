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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtboxFlightNum = new System.Windows.Forms.TextBox();
            this.lboxStaff = new System.Windows.Forms.ListBox();
            this.btnFlightStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(294, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 31);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtboxFlightNum
            // 
            this.txtboxFlightNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFlightNum.Location = new System.Drawing.Point(12, 19);
            this.txtboxFlightNum.Name = "txtboxFlightNum";
            this.txtboxFlightNum.Size = new System.Drawing.Size(124, 23);
            this.txtboxFlightNum.TabIndex = 11;
            this.txtboxFlightNum.Text = "Enter Flight Number";
            // 
            // lboxStaff
            // 
            this.lboxStaff.FormattingEnabled = true;
            this.lboxStaff.Location = new System.Drawing.Point(12, 73);
            this.lboxStaff.Name = "lboxStaff";
            this.lboxStaff.Size = new System.Drawing.Size(390, 134);
            this.lboxStaff.TabIndex = 12;
            // 
            // btnFlightStaff
            // 
            this.btnFlightStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlightStaff.Location = new System.Drawing.Point(151, 2);
            this.btnFlightStaff.Name = "btnFlightStaff";
            this.btnFlightStaff.Size = new System.Drawing.Size(125, 56);
            this.btnFlightStaff.TabIndex = 13;
            this.btnFlightStaff.Text = "Check Flight Staff";
            this.btnFlightStaff.UseVisualStyleBackColor = true;
            this.btnFlightStaff.Click += new System.EventHandler(this.btnFlightStaff_Click);
            // 
            // FlightStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 274);
            this.Controls.Add(this.btnFlightStaff);
            this.Controls.Add(this.lboxStaff);
            this.Controls.Add(this.txtboxFlightNum);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FlightStaff";
            this.Text = "FlightStaff";
            this.Load += new System.EventHandler(this.FlightStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtboxFlightNum;
        private System.Windows.Forms.ListBox lboxStaff;
        private System.Windows.Forms.Button btnFlightStaff;
    }
}