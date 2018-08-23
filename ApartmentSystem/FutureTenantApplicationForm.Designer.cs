namespace ApartmentSystem
{
    partial class FutureTenantApplicationForm
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
            this.ApplNumberlabel = new System.Windows.Forms.Label();
            this.FirstNamelabel = new System.Windows.Forms.Label();
            this.LastNamelabel = new System.Windows.Forms.Label();
            this.SSNlabel = new System.Windows.Forms.Label();
            this.TypeOfFlatlabel = new System.Windows.Forms.Label();
            this.NoOfResidentlabel = new System.Windows.Forms.Label();
            this.Petlabel = new System.Windows.Forms.Label();
            this.textBoxApplicationNumber = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxLast4DigitsSSN = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfResidents = new System.Windows.Forms.TextBox();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.radioButtonDoubleBedroom = new System.Windows.Forms.RadioButton();
            this.radioButtonTrippleBedroom = new System.Windows.Forms.RadioButton();
            this.radioButtonPetsYes = new System.Windows.Forms.RadioButton();
            this.radioButtonPetsNo = new System.Windows.Forms.RadioButton();
            this.radioButtonStudio = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FutureTenantFormErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FutureTenantFormErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplNumberlabel
            // 
            this.ApplNumberlabel.AutoSize = true;
            this.ApplNumberlabel.Location = new System.Drawing.Point(149, 98);
            this.ApplNumberlabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ApplNumberlabel.Name = "ApplNumberlabel";
            this.ApplNumberlabel.Size = new System.Drawing.Size(336, 32);
            this.ApplNumberlabel.TabIndex = 0;
            this.ApplNumberlabel.Text = "APPLICATION NUMBER:";
            // 
            // FirstNamelabel
            // 
            this.FirstNamelabel.AutoSize = true;
            this.FirstNamelabel.Location = new System.Drawing.Point(149, 215);
            this.FirstNamelabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.FirstNamelabel.Name = "FirstNamelabel";
            this.FirstNamelabel.Size = new System.Drawing.Size(191, 32);
            this.FirstNamelabel.TabIndex = 1;
            this.FirstNamelabel.Text = "FIRST NAME:";
            // 
            // LastNamelabel
            // 
            this.LastNamelabel.AutoSize = true;
            this.LastNamelabel.Location = new System.Drawing.Point(160, 315);
            this.LastNamelabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LastNamelabel.Name = "LastNamelabel";
            this.LastNamelabel.Size = new System.Drawing.Size(182, 32);
            this.LastNamelabel.TabIndex = 2;
            this.LastNamelabel.Text = "LAST NAME:";
            // 
            // SSNlabel
            // 
            this.SSNlabel.AutoSize = true;
            this.SSNlabel.Location = new System.Drawing.Point(149, 436);
            this.SSNlabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.SSNlabel.Name = "SSNlabel";
            this.SSNlabel.Size = new System.Drawing.Size(343, 32);
            this.SSNlabel.TabIndex = 3;
            this.SSNlabel.Text = "LAST 4 DIGITS OF S.S.N:";
            // 
            // TypeOfFlatlabel
            // 
            this.TypeOfFlatlabel.AutoSize = true;
            this.TypeOfFlatlabel.Location = new System.Drawing.Point(149, 525);
            this.TypeOfFlatlabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.TypeOfFlatlabel.Name = "TypeOfFlatlabel";
            this.TypeOfFlatlabel.Size = new System.Drawing.Size(219, 32);
            this.TypeOfFlatlabel.TabIndex = 5;
            this.TypeOfFlatlabel.Text = "TYPE OF FLAT:";
            // 
            // NoOfResidentlabel
            // 
            this.NoOfResidentlabel.AutoSize = true;
            this.NoOfResidentlabel.Location = new System.Drawing.Point(133, 646);
            this.NoOfResidentlabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.NoOfResidentlabel.Name = "NoOfResidentlabel";
            this.NoOfResidentlabel.Size = new System.Drawing.Size(357, 32);
            this.NoOfResidentlabel.TabIndex = 6;
            this.NoOfResidentlabel.Text = "NUMBER OF RESIDENTS:";
            // 
            // Petlabel
            // 
            this.Petlabel.AutoSize = true;
            this.Petlabel.Location = new System.Drawing.Point(149, 742);
            this.Petlabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Petlabel.Name = "Petlabel";
            this.Petlabel.Size = new System.Drawing.Size(97, 32);
            this.Petlabel.TabIndex = 7;
            this.Petlabel.Text = "PETS:";
            // 
            // textBoxApplicationNumber
            // 
            this.textBoxApplicationNumber.Location = new System.Drawing.Point(629, 98);
            this.textBoxApplicationNumber.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxApplicationNumber.Name = "textBoxApplicationNumber";
            this.textBoxApplicationNumber.Size = new System.Drawing.Size(665, 38);
            this.textBoxApplicationNumber.TabIndex = 8;
            this.textBoxApplicationNumber.TextChanged += new System.EventHandler(this.textBoxApplicationNumber_TextChanged);
            this.textBoxApplicationNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApplicationNumber_KeyPress);
            this.textBoxApplicationNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxApplicationNumber_Validating);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(629, 215);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(665, 38);
            this.textBoxFirstName.TabIndex = 9;
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            this.textBoxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFirstName_Validating);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(629, 315);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(665, 38);
            this.textBoxLastName.TabIndex = 10;
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastName_KeyPress);
            this.textBoxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLastName_Validating);
            // 
            // textBoxLast4DigitsSSN
            // 
            this.textBoxLast4DigitsSSN.Location = new System.Drawing.Point(629, 420);
            this.textBoxLast4DigitsSSN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxLast4DigitsSSN.MaxLength = 4;
            this.textBoxLast4DigitsSSN.Name = "textBoxLast4DigitsSSN";
            this.textBoxLast4DigitsSSN.Size = new System.Drawing.Size(180, 38);
            this.textBoxLast4DigitsSSN.TabIndex = 11;
            this.textBoxLast4DigitsSSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLast4DigitsSSN_KeyPress);
            this.textBoxLast4DigitsSSN.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLast4DigitsSSN_Validating);
            // 
            // textBoxNumberOfResidents
            // 
            this.textBoxNumberOfResidents.Location = new System.Drawing.Point(629, 639);
            this.textBoxNumberOfResidents.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxNumberOfResidents.Name = "textBoxNumberOfResidents";
            this.textBoxNumberOfResidents.Size = new System.Drawing.Size(665, 38);
            this.textBoxNumberOfResidents.TabIndex = 14;
            this.textBoxNumberOfResidents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberOfResidents_KeyPress);
            this.textBoxNumberOfResidents.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumberOfResidents_Validating);
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.Location = new System.Drawing.Point(11, 31);
            this.radioButtonSingle.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(307, 36);
            this.radioButtonSingle.TabIndex = 15;
            this.radioButtonSingle.TabStop = true;
            this.radioButtonSingle.Text = "SINGLE BEDROOM";
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            // 
            // radioButtonDoubleBedroom
            // 
            this.radioButtonDoubleBedroom.AutoSize = true;
            this.radioButtonDoubleBedroom.Location = new System.Drawing.Point(344, 31);
            this.radioButtonDoubleBedroom.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonDoubleBedroom.Name = "radioButtonDoubleBedroom";
            this.radioButtonDoubleBedroom.Size = new System.Drawing.Size(320, 36);
            this.radioButtonDoubleBedroom.TabIndex = 16;
            this.radioButtonDoubleBedroom.TabStop = true;
            this.radioButtonDoubleBedroom.Text = "DOUBLE BEDROOM";
            this.radioButtonDoubleBedroom.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrippleBedroom
            // 
            this.radioButtonTrippleBedroom.AutoSize = true;
            this.radioButtonTrippleBedroom.Location = new System.Drawing.Point(712, 29);
            this.radioButtonTrippleBedroom.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonTrippleBedroom.Name = "radioButtonTrippleBedroom";
            this.radioButtonTrippleBedroom.Size = new System.Drawing.Size(302, 36);
            this.radioButtonTrippleBedroom.TabIndex = 17;
            this.radioButtonTrippleBedroom.TabStop = true;
            this.radioButtonTrippleBedroom.Text = "TRIPLE BEDROOM";
            this.radioButtonTrippleBedroom.UseVisualStyleBackColor = true;
            // 
            // radioButtonPetsYes
            // 
            this.radioButtonPetsYes.AutoSize = true;
            this.radioButtonPetsYes.Location = new System.Drawing.Point(629, 742);
            this.radioButtonPetsYes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonPetsYes.Name = "radioButtonPetsYes";
            this.radioButtonPetsYes.Size = new System.Drawing.Size(109, 36);
            this.radioButtonPetsYes.TabIndex = 18;
            this.radioButtonPetsYes.TabStop = true;
            this.radioButtonPetsYes.Text = "YES";
            this.radioButtonPetsYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonPetsNo
            // 
            this.radioButtonPetsNo.AutoSize = true;
            this.radioButtonPetsNo.Location = new System.Drawing.Point(1019, 732);
            this.radioButtonPetsNo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonPetsNo.Name = "radioButtonPetsNo";
            this.radioButtonPetsNo.Size = new System.Drawing.Size(94, 36);
            this.radioButtonPetsNo.TabIndex = 19;
            this.radioButtonPetsNo.TabStop = true;
            this.radioButtonPetsNo.Text = "NO";
            this.radioButtonPetsNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonStudio
            // 
            this.radioButtonStudio.AutoSize = true;
            this.radioButtonStudio.Location = new System.Drawing.Point(11, 81);
            this.radioButtonStudio.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonStudio.Name = "radioButtonStudio";
            this.radioButtonStudio.Size = new System.Drawing.Size(157, 36);
            this.radioButtonStudio.TabIndex = 20;
            this.radioButtonStudio.TabStop = true;
            this.radioButtonStudio.Text = "STUDIO";
            this.radioButtonStudio.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(629, 832);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 55);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "&SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1019, 832);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 55);
            this.buttonExit.TabIndex = 22;
            this.buttonExit.Text = "E&XIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSingle);
            this.groupBox1.Controls.Add(this.radioButtonDoubleBedroom);
            this.groupBox1.Controls.Add(this.radioButtonStudio);
            this.groupBox1.Controls.Add(this.radioButtonTrippleBedroom);
            this.groupBox1.Location = new System.Drawing.Point(629, 494);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1296, 126);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // FutureTenantFormErrorProvider
            // 
            this.FutureTenantFormErrorProvider.ContainerControl = this;
            // 
            // FutureTenantApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 940);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.radioButtonPetsNo);
            this.Controls.Add(this.radioButtonPetsYes);
            this.Controls.Add(this.textBoxNumberOfResidents);
            this.Controls.Add(this.textBoxLast4DigitsSSN);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxApplicationNumber);
            this.Controls.Add(this.Petlabel);
            this.Controls.Add(this.NoOfResidentlabel);
            this.Controls.Add(this.TypeOfFlatlabel);
            this.Controls.Add(this.SSNlabel);
            this.Controls.Add(this.LastNamelabel);
            this.Controls.Add(this.FirstNamelabel);
            this.Controls.Add(this.ApplNumberlabel);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FutureTenantApplicationForm";
            this.Text = "FutureTenantApplicationForm";
            this.Load += new System.EventHandler(this.FutureTenantApplicationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FutureTenantFormErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ApplNumberlabel;
        private System.Windows.Forms.Label FirstNamelabel;
        private System.Windows.Forms.Label LastNamelabel;
        private System.Windows.Forms.Label SSNlabel;
        private System.Windows.Forms.Label TypeOfFlatlabel;
        private System.Windows.Forms.Label NoOfResidentlabel;
        private System.Windows.Forms.Label Petlabel;
        private System.Windows.Forms.TextBox textBoxApplicationNumber;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxLast4DigitsSSN;
        private System.Windows.Forms.TextBox textBoxNumberOfResidents;
        private System.Windows.Forms.RadioButton radioButtonSingle;
        private System.Windows.Forms.RadioButton radioButtonDoubleBedroom;
        private System.Windows.Forms.RadioButton radioButtonTrippleBedroom;
        private System.Windows.Forms.RadioButton radioButtonPetsYes;
        private System.Windows.Forms.RadioButton radioButtonPetsNo;
        private System.Windows.Forms.RadioButton radioButtonStudio;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider FutureTenantFormErrorProvider;
    }
}