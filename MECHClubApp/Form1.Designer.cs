namespace MECHClubApp
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
            this.components = new System.ComponentModel.Container();
            this.add_part_button = new System.Windows.Forms.Button();
            this.delete_part_button = new System.Windows.Forms.Button();
            this.filter_part_button = new System.Windows.Forms.Button();
            this.partsGrid = new System.Windows.Forms.DataGridView();
            this.partidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorurlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mECHDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mECHDatabaseDataSet = new MECHClubApp.MECHDatabaseDataSet();
            this.partsTableAdapter = new MECHClubApp.MECHDatabaseDataSetTableAdapters.partsTableAdapter();
            this.projectsForm = new System.Windows.Forms.Button();
            this.projectPartsForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // add_part_button
            // 
            this.add_part_button.Location = new System.Drawing.Point(151, 62);
            this.add_part_button.Name = "add_part_button";
            this.add_part_button.Size = new System.Drawing.Size(158, 52);
            this.add_part_button.TabIndex = 0;
            this.add_part_button.Text = "Add Part";
            this.add_part_button.UseVisualStyleBackColor = true;
            this.add_part_button.Click += new System.EventHandler(this.add_part_button_Click);
            // 
            // delete_part_button
            // 
            this.delete_part_button.Location = new System.Drawing.Point(497, 62);
            this.delete_part_button.Name = "delete_part_button";
            this.delete_part_button.Size = new System.Drawing.Size(158, 52);
            this.delete_part_button.TabIndex = 1;
            this.delete_part_button.Text = "Delete Part";
            this.delete_part_button.UseVisualStyleBackColor = true;
            this.delete_part_button.Click += new System.EventHandler(this.delete_part_button_Click);
            // 
            // filter_part_button
            // 
            this.filter_part_button.Location = new System.Drawing.Point(828, 62);
            this.filter_part_button.Name = "filter_part_button";
            this.filter_part_button.Size = new System.Drawing.Size(158, 52);
            this.filter_part_button.TabIndex = 2;
            this.filter_part_button.Text = "Filter Parts";
            this.filter_part_button.UseVisualStyleBackColor = true;
            this.filter_part_button.Click += new System.EventHandler(this.filter_part_button_Click);
            // 
            // partsGrid
            // 
            this.partsGrid.AutoGenerateColumns = false;
            this.partsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partidDataGridViewTextBoxColumn,
            this.partnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.vendorDataGridViewTextBoxColumn,
            this.vendorurlDataGridViewTextBoxColumn});
            this.partsGrid.DataSource = this.partsBindingSource;
            this.partsGrid.Location = new System.Drawing.Point(0, 264);
            this.partsGrid.Name = "partsGrid";
            this.partsGrid.Size = new System.Drawing.Size(1173, 309);
            this.partsGrid.TabIndex = 3;
            // 
            // partidDataGridViewTextBoxColumn
            // 
            this.partidDataGridViewTextBoxColumn.DataPropertyName = "part_id";
            this.partidDataGridViewTextBoxColumn.HeaderText = "Part Id";
            this.partidDataGridViewTextBoxColumn.Name = "partidDataGridViewTextBoxColumn";
            // 
            // partnameDataGridViewTextBoxColumn
            // 
            this.partnameDataGridViewTextBoxColumn.DataPropertyName = "part_name";
            this.partnameDataGridViewTextBoxColumn.HeaderText = "Part Name";
            this.partnameDataGridViewTextBoxColumn.Name = "partnameDataGridViewTextBoxColumn";
            this.partnameDataGridViewTextBoxColumn.Width = 160;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 160;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 175;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 175;
            // 
            // vendorDataGridViewTextBoxColumn
            // 
            this.vendorDataGridViewTextBoxColumn.DataPropertyName = "vendor";
            this.vendorDataGridViewTextBoxColumn.HeaderText = "Vendor";
            this.vendorDataGridViewTextBoxColumn.Name = "vendorDataGridViewTextBoxColumn";
            this.vendorDataGridViewTextBoxColumn.Width = 175;
            // 
            // vendorurlDataGridViewTextBoxColumn
            // 
            this.vendorurlDataGridViewTextBoxColumn.DataPropertyName = "vendor_url";
            this.vendorurlDataGridViewTextBoxColumn.HeaderText = "Vendor URL";
            this.vendorurlDataGridViewTextBoxColumn.Name = "vendorurlDataGridViewTextBoxColumn";
            this.vendorurlDataGridViewTextBoxColumn.Width = 185;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "parts";
            this.partsBindingSource.DataSource = this.mECHDatabaseDataSetBindingSource;
            // 
            // mECHDatabaseDataSetBindingSource
            // 
            this.mECHDatabaseDataSetBindingSource.DataSource = this.mECHDatabaseDataSet;
            this.mECHDatabaseDataSetBindingSource.Position = 0;
            // 
            // mECHDatabaseDataSet
            // 
            this.mECHDatabaseDataSet.DataSetName = "MECHDatabaseDataSet";
            this.mECHDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // projectsForm
            // 
            this.projectsForm.Location = new System.Drawing.Point(928, 224);
            this.projectsForm.Name = "projectsForm";
            this.projectsForm.Size = new System.Drawing.Size(126, 43);
            this.projectsForm.TabIndex = 4;
            this.projectsForm.Text = "Projects";
            this.projectsForm.UseVisualStyleBackColor = true;
            this.projectsForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // projectPartsForm
            // 
            this.projectPartsForm.Location = new System.Drawing.Point(1049, 224);
            this.projectPartsForm.Name = "projectPartsForm";
            this.projectPartsForm.Size = new System.Drawing.Size(126, 43);
            this.projectPartsForm.TabIndex = 5;
            this.projectPartsForm.Text = "Project Parts";
            this.projectPartsForm.UseVisualStyleBackColor = true;
            this.projectPartsForm.Click += new System.EventHandler(this.projectPartsForm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(808, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(689, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Events";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 626);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.projectPartsForm);
            this.Controls.Add(this.projectsForm);
            this.Controls.Add(this.partsGrid);
            this.Controls.Add(this.filter_part_button);
            this.Controls.Add(this.delete_part_button);
            this.Controls.Add(this.add_part_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_part_button;
        private System.Windows.Forms.Button delete_part_button;
        private System.Windows.Forms.Button filter_part_button;
        private System.Windows.Forms.DataGridView partsGrid;
        private System.Windows.Forms.BindingSource mECHDatabaseDataSetBindingSource;
        private MECHDatabaseDataSet mECHDatabaseDataSet;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private MECHDatabaseDataSetTableAdapters.partsTableAdapter partsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorurlDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button projectsForm;
        private System.Windows.Forms.Button projectPartsForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

