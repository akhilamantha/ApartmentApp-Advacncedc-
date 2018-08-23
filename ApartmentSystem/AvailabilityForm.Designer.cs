using System;

namespace ApartmentSystem
{
    partial class AvailabilityForm
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
            this.SingleBedroomButton = new System.Windows.Forms.Button();
            this.DoubleBedroomButton = new System.Windows.Forms.Button();
            this.TripleBedRoomButton = new System.Windows.Forms.Button();
            this.StudioButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.textBoxRoomDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHECK AVAILABILITY";
            // 
            // SingleBedroomButton
            // 
            this.SingleBedroomButton.Location = new System.Drawing.Point(47, 88);
            this.SingleBedroomButton.Name = "SingleBedroomButton";
            this.SingleBedroomButton.Size = new System.Drawing.Size(133, 23);
            this.SingleBedroomButton.TabIndex = 1;
            this.SingleBedroomButton.Text = "SINGLE BEDROOM";
            this.SingleBedroomButton.UseVisualStyleBackColor = true;
            this.SingleBedroomButton.Click += new System.EventHandler(this.SingleBedroomButton_Click);
            // 
            // DoubleBedroomButton
            // 
            this.DoubleBedroomButton.Location = new System.Drawing.Point(228, 88);
            this.DoubleBedroomButton.Name = "DoubleBedroomButton";
            this.DoubleBedroomButton.Size = new System.Drawing.Size(123, 23);
            this.DoubleBedroomButton.TabIndex = 2;
            this.DoubleBedroomButton.Text = "DOUBLE BEDROOM";
            this.DoubleBedroomButton.UseVisualStyleBackColor = true;
            this.DoubleBedroomButton.Click += new System.EventHandler(this.DoubleBedroomButton_Click);
            // 
            // TripleBedRoomButton
            // 
            this.TripleBedRoomButton.Location = new System.Drawing.Point(426, 88);
            this.TripleBedRoomButton.Name = "TripleBedRoomButton";
            this.TripleBedRoomButton.Size = new System.Drawing.Size(117, 23);
            this.TripleBedRoomButton.TabIndex = 3;
            this.TripleBedRoomButton.Text = "TRIPLE BEDROOM";
            this.TripleBedRoomButton.UseVisualStyleBackColor = true;
            this.TripleBedRoomButton.Click += new System.EventHandler(this.TripleBedRoomButton_Click);
            // 
            // StudioButton
            // 
            this.StudioButton.Location = new System.Drawing.Point(626, 88);
            this.StudioButton.Name = "StudioButton";
            this.StudioButton.Size = new System.Drawing.Size(75, 23);
            this.StudioButton.TabIndex = 4;
            this.StudioButton.Text = "STUDIO";
            this.StudioButton.UseVisualStyleBackColor = true;
            this.StudioButton.Click += new System.EventHandler(this.StudioButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(255, 322);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(75, 23);
            this.GoBackButton.TabIndex = 5;
            this.GoBackButton.Text = "GO BACK";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(451, 322);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // textBoxRoomDetails
            // 
            this.textBoxRoomDetails.Location = new System.Drawing.Point(47, 135);
            this.textBoxRoomDetails.Multiline = true;
            this.textBoxRoomDetails.Name = "textBoxRoomDetails";
            this.textBoxRoomDetails.Size = new System.Drawing.Size(685, 172);
            this.textBoxRoomDetails.TabIndex = 7;
            // 
            // AvailabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 364);
            this.Controls.Add(this.textBoxRoomDetails);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.StudioButton);
            this.Controls.Add(this.TripleBedRoomButton);
            this.Controls.Add(this.DoubleBedroomButton);
            this.Controls.Add(this.SingleBedroomButton);
            this.Controls.Add(this.label1);
            this.Name = "AvailabilityForm";
            this.Text = "AvailabilityForm";
            this.Load += new System.EventHandler(this.AvailabilityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SingleBedroomButton;
        private System.Windows.Forms.Button DoubleBedroomButton;
        private System.Windows.Forms.Button TripleBedRoomButton;
        private System.Windows.Forms.Button StudioButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox textBoxRoomDetails;
    }
}