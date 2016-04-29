namespace MECHClubApp
{
    partial class ProjectParts
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.projectPartsGrid = new System.Windows.Forms.DataGridView();
            this.proj_parts_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_need = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectpartsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mECHDatabaseDataSet = new MECHClubApp.MECHDatabaseDataSet();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTableAdapter = new MECHClubApp.MECHDatabaseDataSetTableAdapters.eventsTableAdapter();
            this.projectpartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_partsTableAdapter = new MECHClubApp.MECHDatabaseDataSetTableAdapters.project_partsTableAdapter();
            this.eventsForm = new System.Windows.Forms.Button();
            this.ordersForm = new System.Windows.Forms.Button();
            this.partsForm = new System.Windows.Forms.Button();
            this.projectsForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectpartsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectpartsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Project Part";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete Project Part";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(866, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Filter Project Parts";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // projectPartsGrid
            // 
            this.projectPartsGrid.AllowUserToOrderColumns = true;
            this.projectPartsGrid.AutoGenerateColumns = false;
            this.projectPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectPartsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proj_parts_id,
            this.projidDataGridViewTextBoxColumn,
            this.part_id,
            this.quantity_need});
            this.projectPartsGrid.DataSource = this.projectpartsBindingSource1;
            this.projectPartsGrid.Location = new System.Drawing.Point(1, 293);
            this.projectPartsGrid.Name = "projectPartsGrid";
            this.projectPartsGrid.Size = new System.Drawing.Size(1173, 335);
            this.projectPartsGrid.TabIndex = 3;
            // 
            // proj_parts_id
            // 
            this.proj_parts_id.DataPropertyName = "proj_parts_id";
            this.proj_parts_id.HeaderText = "Project Part Id";
            this.proj_parts_id.Name = "proj_parts_id";
            this.proj_parts_id.Width = 200;
            // 
            // projidDataGridViewTextBoxColumn
            // 
            this.projidDataGridViewTextBoxColumn.DataPropertyName = "proj_id";
            this.projidDataGridViewTextBoxColumn.HeaderText = "Project Id";
            this.projidDataGridViewTextBoxColumn.Name = "projidDataGridViewTextBoxColumn";
            this.projidDataGridViewTextBoxColumn.Width = 300;
            // 
            // part_id
            // 
            this.part_id.DataPropertyName = "part_id";
            this.part_id.HeaderText = "Part Id";
            this.part_id.Name = "part_id";
            this.part_id.Width = 300;
            // 
            // quantity_need
            // 
            this.quantity_need.DataPropertyName = "quantity_need";
            this.quantity_need.HeaderText = "Quantity Needed";
            this.quantity_need.Name = "quantity_need";
            this.quantity_need.Width = 330;
            // 
            // projectpartsBindingSource1
            // 
            this.projectpartsBindingSource1.DataMember = "project_parts";
            this.projectpartsBindingSource1.DataSource = this.mECHDatabaseDataSet;
            // 
            // mECHDatabaseDataSet
            // 
            this.mECHDatabaseDataSet.DataSetName = "MECHDatabaseDataSet";
            this.mECHDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "events";
            this.eventsBindingSource.DataSource = this.mECHDatabaseDataSet;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // projectpartsBindingSource
            // 
            this.projectpartsBindingSource.DataMember = "project_parts";
            this.projectpartsBindingSource.DataSource = this.mECHDatabaseDataSet;
            // 
            // project_partsTableAdapter
            // 
            this.project_partsTableAdapter.ClearBeforeFill = true;
            // 
            // eventsForm
            // 
            this.eventsForm.Location = new System.Drawing.Point(689, 254);
            this.eventsForm.Name = "eventsForm";
            this.eventsForm.Size = new System.Drawing.Size(126, 43);
            this.eventsForm.TabIndex = 11;
            this.eventsForm.Text = "Events";
            this.eventsForm.UseVisualStyleBackColor = true;
            this.eventsForm.Click += new System.EventHandler(this.eventsForm_Click);
            // 
            // ordersForm
            // 
            this.ordersForm.Location = new System.Drawing.Point(808, 254);
            this.ordersForm.Name = "ordersForm";
            this.ordersForm.Size = new System.Drawing.Size(126, 43);
            this.ordersForm.TabIndex = 10;
            this.ordersForm.Text = "Orders";
            this.ordersForm.UseVisualStyleBackColor = true;
            this.ordersForm.Click += new System.EventHandler(this.ordersForm_Click);
            // 
            // partsForm
            // 
            this.partsForm.Location = new System.Drawing.Point(1049, 254);
            this.partsForm.Name = "partsForm";
            this.partsForm.Size = new System.Drawing.Size(126, 43);
            this.partsForm.TabIndex = 9;
            this.partsForm.Text = "Parts";
            this.partsForm.UseVisualStyleBackColor = true;
            this.partsForm.Click += new System.EventHandler(this.partsForm_Click);
            // 
            // projectsForm
            // 
            this.projectsForm.Location = new System.Drawing.Point(928, 254);
            this.projectsForm.Name = "projectsForm";
            this.projectsForm.Size = new System.Drawing.Size(126, 43);
            this.projectsForm.TabIndex = 8;
            this.projectsForm.Text = "Projects";
            this.projectsForm.UseVisualStyleBackColor = true;
            this.projectsForm.Click += new System.EventHandler(this.projectsForm_Click);
            // 
            // ProjectParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 626);
            this.Controls.Add(this.eventsForm);
            this.Controls.Add(this.ordersForm);
            this.Controls.Add(this.partsForm);
            this.Controls.Add(this.projectsForm);
            this.Controls.Add(this.projectPartsGrid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ProjectParts";
            this.Text = "ProjectParts";
            this.Load += new System.EventHandler(this.ProjectParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectpartsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectpartsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView projectPartsGrid;
        private MECHDatabaseDataSet mECHDatabaseDataSet;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private MECHDatabaseDataSetTableAdapters.eventsTableAdapter eventsTableAdapter;
        private System.Windows.Forms.BindingSource projectpartsBindingSource;
        private MECHDatabaseDataSetTableAdapters.project_partsTableAdapter project_partsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn proj_parts_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn projidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn part_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_need;
        private System.Windows.Forms.BindingSource projectpartsBindingSource1;
        private System.Windows.Forms.Button eventsForm;
        private System.Windows.Forms.Button ordersForm;
        private System.Windows.Forms.Button partsForm;
        private System.Windows.Forms.Button projectsForm;
    }
}