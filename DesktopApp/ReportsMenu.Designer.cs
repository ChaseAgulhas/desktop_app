namespace DesktopApp
{
    partial class ReportsMenu
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
            this.btnCompletedOrders = new System.Windows.Forms.Button();
            this.btnListAppUsers = new System.Windows.Forms.Button();
            this.btnListDrivers = new System.Windows.Forms.Button();
            this.btnComments = new System.Windows.Forms.Button();
            this.btnCloseReportsMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompletedOrders
            // 
            this.btnCompletedOrders.Location = new System.Drawing.Point(97, 12);
            this.btnCompletedOrders.Name = "btnCompletedOrders";
            this.btnCompletedOrders.Size = new System.Drawing.Size(132, 47);
            this.btnCompletedOrders.TabIndex = 1;
            this.btnCompletedOrders.Text = "Completed Orders";
            this.btnCompletedOrders.UseVisualStyleBackColor = true;
            this.btnCompletedOrders.Click += new System.EventHandler(this.btnCompletedOrders_Click);
            // 
            // btnListAppUsers
            // 
            this.btnListAppUsers.Location = new System.Drawing.Point(97, 65);
            this.btnListAppUsers.Name = "btnListAppUsers";
            this.btnListAppUsers.Size = new System.Drawing.Size(132, 47);
            this.btnListAppUsers.TabIndex = 2;
            this.btnListAppUsers.Text = "App users";
            this.btnListAppUsers.UseVisualStyleBackColor = true;
            this.btnListAppUsers.Click += new System.EventHandler(this.btnListAppUsers_Click);
            // 
            // btnListDrivers
            // 
            this.btnListDrivers.Location = new System.Drawing.Point(97, 118);
            this.btnListDrivers.Name = "btnListDrivers";
            this.btnListDrivers.Size = new System.Drawing.Size(132, 47);
            this.btnListDrivers.TabIndex = 3;
            this.btnListDrivers.Text = "Drivers";
            this.btnListDrivers.UseVisualStyleBackColor = true;
            this.btnListDrivers.Click += new System.EventHandler(this.btnListDrivers_Click);
            // 
            // btnComments
            // 
            this.btnComments.Location = new System.Drawing.Point(97, 171);
            this.btnComments.Name = "btnComments";
            this.btnComments.Size = new System.Drawing.Size(132, 47);
            this.btnComments.TabIndex = 4;
            this.btnComments.Text = "Reviews or Complaints";
            this.btnComments.UseVisualStyleBackColor = true;
            this.btnComments.Click += new System.EventHandler(this.btnComments_Click);
            // 
            // btnCloseReportsMenu
            // 
            this.btnCloseReportsMenu.Location = new System.Drawing.Point(97, 224);
            this.btnCloseReportsMenu.Name = "btnCloseReportsMenu";
            this.btnCloseReportsMenu.Size = new System.Drawing.Size(132, 47);
            this.btnCloseReportsMenu.TabIndex = 5;
            this.btnCloseReportsMenu.Text = "Close";
            this.btnCloseReportsMenu.UseVisualStyleBackColor = true;
            this.btnCloseReportsMenu.Click += new System.EventHandler(this.btnCloseReportsMenu_Click);
            // 
            // ReportsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 389);
            this.Controls.Add(this.btnCloseReportsMenu);
            this.Controls.Add(this.btnComments);
            this.Controls.Add(this.btnListDrivers);
            this.Controls.Add(this.btnListAppUsers);
            this.Controls.Add(this.btnCompletedOrders);
            this.Name = "ReportsMenu";
            this.Text = "D\'elite Takeaways - Reports Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompletedOrders;
        private System.Windows.Forms.Button btnListAppUsers;
        private System.Windows.Forms.Button btnListDrivers;
        private System.Windows.Forms.Button btnComments;
        private System.Windows.Forms.Button btnCloseReportsMenu;
    }
}