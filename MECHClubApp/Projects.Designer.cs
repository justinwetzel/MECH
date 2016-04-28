namespace MECHClubApp
{
    partial class Projects
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mECHDatabaseDataSet = new MECHClubApp.MECHDatabaseDataSet();
            this.ordersTableAdapter = new MECHClubApp.MECHDatabaseDataSetTableAdapters.ordersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new MECHClubApp.MECHDatabaseDataSetTableAdapters.projectsTableAdapter();
            this.projidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contributorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageurlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projidDataGridViewTextBoxColumn,
            this.projnameDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.contributorsDataGridViewTextBoxColumn,
            this.imageurlDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.projectsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1174, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.mECHDatabaseDataSet;
            // 
            // mECHDatabaseDataSet
            // 
            this.mECHDatabaseDataSet.DataSetName = "MECHDatabaseDataSet";
            this.mECHDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete Project";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(834, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "Filter Projects";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "projects";
            this.projectsBindingSource.DataSource = this.mECHDatabaseDataSet;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // projidDataGridViewTextBoxColumn
            // 
            this.projidDataGridViewTextBoxColumn.DataPropertyName = "proj_id";
            this.projidDataGridViewTextBoxColumn.HeaderText = "Project Id";
            this.projidDataGridViewTextBoxColumn.Name = "projidDataGridViewTextBoxColumn";
            this.projidDataGridViewTextBoxColumn.Width = 185;
            // 
            // projnameDataGridViewTextBoxColumn
            // 
            this.projnameDataGridViewTextBoxColumn.DataPropertyName = "proj_name";
            this.projnameDataGridViewTextBoxColumn.HeaderText = "Project Name";
            this.projnameDataGridViewTextBoxColumn.Name = "projnameDataGridViewTextBoxColumn";
            this.projnameDataGridViewTextBoxColumn.Width = 175;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.Width = 175;
            // 
            // contributorsDataGridViewTextBoxColumn
            // 
            this.contributorsDataGridViewTextBoxColumn.DataPropertyName = "contributors";
            this.contributorsDataGridViewTextBoxColumn.HeaderText = "Contributors";
            this.contributorsDataGridViewTextBoxColumn.Name = "contributorsDataGridViewTextBoxColumn";
            this.contributorsDataGridViewTextBoxColumn.Width = 200;
            // 
            // imageurlDataGridViewTextBoxColumn
            // 
            this.imageurlDataGridViewTextBoxColumn.DataPropertyName = "image_url";
            this.imageurlDataGridViewTextBoxColumn.HeaderText = "Image URL";
            this.imageurlDataGridViewTextBoxColumn.Name = "imageurlDataGridViewTextBoxColumn";
            this.imageurlDataGridViewTextBoxColumn.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 626);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Projects";
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.Projects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MECHDatabaseDataSet mECHDatabaseDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private MECHDatabaseDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private MECHDatabaseDataSetTableAdapters.projectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn projidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contributorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageurlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}