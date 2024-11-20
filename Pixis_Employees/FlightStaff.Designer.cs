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
            this.lboxStaff = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(11, 349);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 31);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lboxStaff
            // 
            this.lboxStaff.FormattingEnabled = true;
            this.lboxStaff.Location = new System.Drawing.Point(12, 12);
            this.lboxStaff.Name = "lboxStaff";
            this.lboxStaff.Size = new System.Drawing.Size(236, 264);
            this.lboxStaff.TabIndex = 12;
            this.lboxStaff.SelectedIndexChanged += new System.EventHandler(this.lboxStaff_SelectedIndexChanged_1);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(11, 288);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 56);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FlightStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 391);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lboxStaff);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FlightStaff";
            this.Text = "FlightStaff";
            this.Load += new System.EventHandler(this.FlightStaff_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lboxStaff;
        private System.Windows.Forms.Button btnReset;
    }
}