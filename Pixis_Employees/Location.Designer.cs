namespace Pixis_Employees
{
    partial class Location
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
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.listBoxZipCodeTable = new System.Windows.Forms.ListBox();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.buttonAddUpdate = new System.Windows.Forms.Button();
            this.labelZip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(0, 241);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(318, 31);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(0, 0);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(318, 23);
            this.buttonDisplay.TabIndex = 11;
            this.buttonDisplay.Text = "&Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // listBoxZipCodeTable
            // 
            this.listBoxZipCodeTable.FormattingEnabled = true;
            this.listBoxZipCodeTable.Location = new System.Drawing.Point(-1, 29);
            this.listBoxZipCodeTable.Name = "listBoxZipCodeTable";
            this.listBoxZipCodeTable.Size = new System.Drawing.Size(319, 134);
            this.listBoxZipCodeTable.TabIndex = 12;
            // 
            // textBoxZip
            // 
            this.textBoxZip.Location = new System.Drawing.Point(0, 187);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(74, 20);
            this.textBoxZip.TabIndex = 13;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(80, 187);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(191, 20);
            this.textBoxCity.TabIndex = 14;
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(277, 187);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(41, 20);
            this.textBoxState.TabIndex = 15;
            // 
            // buttonAddUpdate
            // 
            this.buttonAddUpdate.Location = new System.Drawing.Point(0, 213);
            this.buttonAddUpdate.Name = "buttonAddUpdate";
            this.buttonAddUpdate.Size = new System.Drawing.Size(318, 23);
            this.buttonAddUpdate.TabIndex = 16;
            this.buttonAddUpdate.Text = "Add/Update";
            this.buttonAddUpdate.UseVisualStyleBackColor = true;
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(12, 171);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(50, 13);
            this.labelZip.TabIndex = 17;
            this.labelZip.Text = "Zip Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "City";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(286, 171);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(32, 13);
            this.labelState.TabIndex = 19;
            this.labelState.Text = "State";
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 292);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.buttonAddUpdate);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.listBoxZipCodeTable);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Location";
            this.Text = "Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.ListBox listBoxZipCodeTable;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Button buttonAddUpdate;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelState;
    }
}