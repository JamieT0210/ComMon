namespace ComMon.Screens
{
    partial class About
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
            this.lblComputerName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblUptime = new System.Windows.Forms.Label();
            this.lblUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Location = new System.Drawing.Point(147, 9);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(51, 20);
            this.lblComputerName.TabIndex = 0;
            this.lblComputerName.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Computer Name:";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(39, 39);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(102, 20);
            this.lblIPAddress.TabIndex = 2;
            this.lblIPAddress.Text = "Computer IP:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(147, 39);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(51, 20);
            this.lblIP.TabIndex = 3;
            this.lblIP.Text = "label2";
            // 
            // lblUptime
            // 
            this.lblUptime.AutoSize = true;
            this.lblUptime.Location = new System.Drawing.Point(77, 69);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(64, 20);
            this.lblUptime.TabIndex = 4;
            this.lblUptime.Text = "Uptime:";
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Location = new System.Drawing.Point(147, 69);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(51, 20);
            this.lblUp.TabIndex = 5;
            this.lblUp.Text = "label3";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 400);
            this.Controls.Add(this.lblUp);
            this.Controls.Add(this.lblUptime);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblComputerName);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblUptime;
        private System.Windows.Forms.Label lblUp;
    }
}