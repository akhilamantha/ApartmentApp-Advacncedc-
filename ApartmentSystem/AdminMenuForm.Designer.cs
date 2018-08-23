namespace ApartmentSystem
{
    partial class AdminMenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FutureTenantApplicationButton = new System.Windows.Forms.Button();
            this.AvailabilityButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReviewFormButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GoBackAdminMenuButton = new System.Windows.Forms.Button();
            this.ExitAdminMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(821, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HELLO ADMIN, WHAT CAN I DO FOR YOU?";
            // 
            // FutureTenantApplicationButton
            // 
            this.FutureTenantApplicationButton.Location = new System.Drawing.Point(96, 274);
            this.FutureTenantApplicationButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.FutureTenantApplicationButton.Name = "FutureTenantApplicationButton";
            this.FutureTenantApplicationButton.Size = new System.Drawing.Size(539, 55);
            this.FutureTenantApplicationButton.TabIndex = 1;
            this.FutureTenantApplicationButton.Text = "FUTURE TENANT APPLICATION";
            this.FutureTenantApplicationButton.UseVisualStyleBackColor = true;
            this.FutureTenantApplicationButton.Click += new System.EventHandler(this.FutureTenantApplicationButton_Click);
            // 
            // AvailabilityButton
            // 
            this.AvailabilityButton.Location = new System.Drawing.Point(1531, 274);
            this.AvailabilityButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AvailabilityButton.Name = "AvailabilityButton";
            this.AvailabilityButton.Size = new System.Drawing.Size(365, 55);
            this.AvailabilityButton.TabIndex = 2;
            this.AvailabilityButton.Text = "AVAILABILITY";
            this.AvailabilityButton.UseVisualStyleBackColor = true;
            this.AvailabilityButton.Click += new System.EventHandler(this.AvailabilityButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "FILL APPLICATION:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(907, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "REVIEW APPLICATION:";
            // 
            // ReviewFormButton
            // 
            this.ReviewFormButton.Location = new System.Drawing.Point(869, 274);
            this.ReviewFormButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ReviewFormButton.Name = "ReviewFormButton";
            this.ReviewFormButton.Size = new System.Drawing.Size(341, 55);
            this.ReviewFormButton.TabIndex = 5;
            this.ReviewFormButton.Text = "REVIEW FORM";
            this.ReviewFormButton.UseVisualStyleBackColor = true;
            this.ReviewFormButton.Click += new System.EventHandler(this.ReviewFormButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1523, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "CHECK AVAILABILITY:";
            // 
            // GoBackAdminMenuButton
            // 
            this.GoBackAdminMenuButton.Location = new System.Drawing.Point(608, 553);
            this.GoBackAdminMenuButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GoBackAdminMenuButton.Name = "GoBackAdminMenuButton";
            this.GoBackAdminMenuButton.Size = new System.Drawing.Size(200, 55);
            this.GoBackAdminMenuButton.TabIndex = 7;
            this.GoBackAdminMenuButton.Text = "GO BACK";
            this.GoBackAdminMenuButton.UseVisualStyleBackColor = true;
            this.GoBackAdminMenuButton.Click += new System.EventHandler(this.GoBackAdminMenuButton_Click);
            // 
            // ExitAdminMenuButton
            // 
            this.ExitAdminMenuButton.Location = new System.Drawing.Point(1240, 553);
            this.ExitAdminMenuButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ExitAdminMenuButton.Name = "ExitAdminMenuButton";
            this.ExitAdminMenuButton.Size = new System.Drawing.Size(200, 55);
            this.ExitAdminMenuButton.TabIndex = 8;
            this.ExitAdminMenuButton.Text = "EXIT";
            this.ExitAdminMenuButton.UseVisualStyleBackColor = true;
            this.ExitAdminMenuButton.Click += new System.EventHandler(this.ExitAdminMenuButton_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2053, 758);
            this.Controls.Add(this.ExitAdminMenuButton);
            this.Controls.Add(this.GoBackAdminMenuButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReviewFormButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AvailabilityButton);
            this.Controls.Add(this.FutureTenantApplicationButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AdminMenuForm";
            this.Text = "AdminMenuForm";
            this.Load += new System.EventHandler(this.AdminMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FutureTenantApplicationButton;
        private System.Windows.Forms.Button AvailabilityButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReviewFormButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GoBackAdminMenuButton;
        private System.Windows.Forms.Button ExitAdminMenuButton;
    }
}