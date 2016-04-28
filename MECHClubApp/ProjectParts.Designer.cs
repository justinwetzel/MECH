﻿namespace MECHClubApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mECHDatabaseDataSet = new MECHClubApp.MECHDatabaseDataSet();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTableAdapter = new MECHClubApp.MECHDatabaseDataSetTableAdapters.eventsTableAdapter();
            this.projectpartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_partsTableAdapter = new MECHClubApp.MECHDatabaseDataSetTableAdapters.project_partsTableAdapter();
            this.projectpartsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proj_parts_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_need = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectpartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectpartsBindingSource1)).BeginInit();
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
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete Project Part";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(866, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Filter Project Parts";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proj_parts_id,
            this.projidDataGridViewTextBoxColumn,
            this.part_id,
            this.quantity_need});
            this.dataGridView1.DataSource = this.projectpartsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1173, 335);
            this.dataGridView1.TabIndex = 3;
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
            // projectpartsBindingSource1
            // 
            this.projectpartsBindingSource1.DataMember = "project_parts";
            this.projectpartsBindingSource1.DataSource = this.mECHDatabaseDataSet;
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
            // ProjectParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 626);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ProjectParts";
            this.Text = "ProjectParts";
            this.Load += new System.EventHandler(this.ProjectParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectpartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectpartsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}