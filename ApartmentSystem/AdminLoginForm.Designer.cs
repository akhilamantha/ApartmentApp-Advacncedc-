namespace ApartmentSystem
{
    partial class AdminLoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ExitLoginButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorMessagelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN LOGIN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "USERNAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD:";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(555, 188);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(361, 38);
            this.UserNameTextBox.TabIndex = 3;
            this.UserNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.UserNameTextBox_Validating);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(555, 305);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(361, 38);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTextBox_Validating);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(467, 484);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(200, 55);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ExitLoginButton
            // 
            this.ExitLoginButton.Location = new System.Drawing.Point(749, 484);
            this.ExitLoginButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ExitLoginButton.Name = "ExitLoginButton";
            this.ExitLoginButton.Size = new System.Drawing.Size(200, 55);
            this.ExitLoginButton.TabIndex = 6;
            this.ExitLoginButton.Text = "EXIT";
            this.ExitLoginButton.UseVisualStyleBackColor = true;
            this.ExitLoginButton.Click += new System.EventHandler(this.ExitLoginButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ErrorMessagelabel
            // 
            this.ErrorMessagelabel.AutoSize = true;
            this.ErrorMessagelabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessagelabel.Location = new System.Drawing.Point(459, 413);
            this.ErrorMessagelabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ErrorMessagelabel.Name = "ErrorMessagelabel";
            this.ErrorMessagelabel.Size = new System.Drawing.Size(494, 32);
            this.ErrorMessagelabel.TabIndex = 7;
            this.ErrorMessagelabel.Text = "Username and Password not matched";
            this.ErrorMessagelabel.Visible = false;
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 622);
            this.Controls.Add(this.ErrorMessagelabel);
            this.Controls.Add(this.ExitLoginButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AdminLoginForm";
            this.Text = "Admin Login";
            this.Load += new System.EventHandler(this.AdminLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ExitLoginButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label ErrorMessagelabel;
    }
}

