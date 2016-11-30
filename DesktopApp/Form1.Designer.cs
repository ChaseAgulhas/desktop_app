namespace DesktopApp
{
    partial class Form1
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
            this.btnOutstandingOrders = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSpecials = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOutstandingOrders
            // 
            this.btnOutstandingOrders.Location = new System.Drawing.Point(114, 76);
            this.btnOutstandingOrders.Name = "btnOutstandingOrders";
            this.btnOutstandingOrders.Size = new System.Drawing.Size(132, 47);
            this.btnOutstandingOrders.TabIndex = 0;
            this.btnOutstandingOrders.Text = "Outstanding Orders";
            this.btnOutstandingOrders.UseVisualStyleBackColor = true;
            this.btnOutstandingOrders.Click += new System.EventHandler(this.btnOutstandingOrders_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(114, 182);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(132, 47);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnSpecials
            // 
            this.btnSpecials.Location = new System.Drawing.Point(114, 129);
            this.btnSpecials.Name = "btnSpecials";
            this.btnSpecials.Size = new System.Drawing.Size(132, 47);
            this.btnSpecials.TabIndex = 2;
            this.btnSpecials.Text = "Daily Specials";
            this.btnSpecials.UseVisualStyleBackColor = true;
            this.btnSpecials.Click += new System.EventHandler(this.btnSpecials_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(114, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 47);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 389);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSpecials);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnOutstandingOrders);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D\'elite Takeaways - Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOutstandingOrders;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSpecials;
        private System.Windows.Forms.Button btnExit;
    }
}

