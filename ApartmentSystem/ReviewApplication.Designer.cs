namespace ApartmentSystem
{
    partial class ReviewApplication
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tenantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDBDataSet = new ApartmentSystem.ApartmentDBDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tenantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aptTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfResidentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petYNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.tenantTableAdapter = new ApartmentSystem.ApartmentDBDataSetTableAdapters.TenantTableAdapter();
            this.apartmentDBDataSet1 = new ApartmentSystem.ApartmentDBDataSet();
            this.submitToolStrip = new System.Windows.Forms.ToolStrip();
            this.tenantIDToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tenantIDToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.submitToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDBDataSet1)).BeginInit();
            this.submitToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "REVIEW APPLICATION FORM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "REVIEW INFORMATION:";
            // 
            // tenantBindingSource1
            // 
            this.tenantBindingSource1.DataMember = "Tenant";
            this.tenantBindingSource1.DataSource = this.apartmentDBDataSetBindingSource;
            // 
            // apartmentDBDataSetBindingSource
            // 
            this.apartmentDBDataSetBindingSource.DataSource = this.apartmentDBDataSet;
            this.apartmentDBDataSetBindingSource.Position = 0;
            // 
            // apartmentDBDataSet
            // 
            this.apartmentDBDataSet.DataSetName = "ApartmentDBDataSet";
            this.apartmentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenantIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.sSNDataGridViewTextBoxColumn,
            this.aptTypeDataGridViewTextBoxColumn,
            this.numOfResidentsDataGridViewTextBoxColumn,
            this.petYNDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tenantBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(72, 175);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(618, 158);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tenantIDDataGridViewTextBoxColumn
            // 
            this.tenantIDDataGridViewTextBoxColumn.DataPropertyName = "TenantID";
            this.tenantIDDataGridViewTextBoxColumn.HeaderText = "TenantID";
            this.tenantIDDataGridViewTextBoxColumn.Name = "tenantIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // sSNDataGridViewTextBoxColumn
            // 
            this.sSNDataGridViewTextBoxColumn.DataPropertyName = "SSN";
            this.sSNDataGridViewTextBoxColumn.HeaderText = "SSN";
            this.sSNDataGridViewTextBoxColumn.Name = "sSNDataGridViewTextBoxColumn";
            // 
            // aptTypeDataGridViewTextBoxColumn
            // 
            this.aptTypeDataGridViewTextBoxColumn.DataPropertyName = "AptType";
            this.aptTypeDataGridViewTextBoxColumn.HeaderText = "AptType";
            this.aptTypeDataGridViewTextBoxColumn.Name = "aptTypeDataGridViewTextBoxColumn";
            // 
            // numOfResidentsDataGridViewTextBoxColumn
            // 
            this.numOfResidentsDataGridViewTextBoxColumn.DataPropertyName = "NumOfResidents";
            this.numOfResidentsDataGridViewTextBoxColumn.HeaderText = "NumOfResidents";
            this.numOfResidentsDataGridViewTextBoxColumn.Name = "numOfResidentsDataGridViewTextBoxColumn";
            // 
            // petYNDataGridViewTextBoxColumn
            // 
            this.petYNDataGridViewTextBoxColumn.DataPropertyName = "Pet_YN";
            this.petYNDataGridViewTextBoxColumn.HeaderText = "Pet_YN";
            this.petYNDataGridViewTextBoxColumn.Name = "petYNDataGridViewTextBoxColumn";
            // 
            // tenantBindingSource
            // 
            this.tenantBindingSource.DataMember = "Tenant";
            this.tenantBindingSource.DataSource = this.apartmentDBDataSet;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(845, 25);
            this.fillBy1ToolStrip.TabIndex = 7;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // tenantTableAdapter
            // 
            this.tenantTableAdapter.ClearBeforeFill = true;
            // 
            // apartmentDBDataSet1
            // 
            this.apartmentDBDataSet1.DataSetName = "ApartmentDBDataSet";
            this.apartmentDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // submitToolStrip
            // 
            this.submitToolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.submitToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tenantIDToolStripLabel1,
            this.tenantIDToolStripTextBox1,
            this.submitToolStripButton});
            this.submitToolStrip.Location = new System.Drawing.Point(0, 25);
            this.submitToolStrip.Name = "submitToolStrip";
            this.submitToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.submitToolStrip.Size = new System.Drawing.Size(845, 25);
            this.submitToolStrip.TabIndex = 8;
            this.submitToolStrip.Text = "submitToolStrip";
            // 
            // tenantIDToolStripLabel1
            // 
            this.tenantIDToolStripLabel1.Name = "tenantIDToolStripLabel1";
            this.tenantIDToolStripLabel1.Size = new System.Drawing.Size(57, 22);
            this.tenantIDToolStripLabel1.Text = "TenantID:";
            // 
            // tenantIDToolStripTextBox1
            // 
            this.tenantIDToolStripTextBox1.Name = "tenantIDToolStripTextBox1";
            this.tenantIDToolStripTextBox1.Size = new System.Drawing.Size(40, 25);
            this.tenantIDToolStripTextBox1.Click += new System.EventHandler(this.tenantIDToolStripTextBox1_Click);
            // 
            // submitToolStripButton
            // 
            this.submitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.submitToolStripButton.Name = "submitToolStripButton";
            this.submitToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.submitToolStripButton.Text = "Submit";
            this.submitToolStripButton.Click += new System.EventHandler(this.submitToolStripButton_Click);
            // 
            // ReviewApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 366);
            this.Controls.Add(this.submitToolStrip);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ReviewApplication";
            this.Text = "ReviewApplication";
            this.Load += new System.EventHandler(this.ReviewApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDBDataSet1)).EndInit();
            this.submitToolStrip.ResumeLayout(false);
            this.submitToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource apartmentDBDataSetBindingSource;
        private ApartmentDBDataSet apartmentDBDataSet;
        private System.Windows.Forms.BindingSource tenantBindingSource;
        private ApartmentDBDataSetTableAdapters.TenantTableAdapter tenantTableAdapter;
        private System.Windows.Forms.BindingSource tenantBindingSource1;
        private ApartmentDBDataSet apartmentDBDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aptTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfResidentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petYNDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStrip submitToolStrip;
        private System.Windows.Forms.ToolStripLabel tenantIDToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tenantIDToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton submitToolStripButton;
    }
}