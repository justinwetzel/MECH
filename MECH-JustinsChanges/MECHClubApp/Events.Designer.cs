namespace MECHClubApp
{
    partial class Events
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
            this.eventsForm = new System.Windows.Forms.Button();
            this.ordersForm = new System.Windows.Forms.Button();
            this.partsForm = new System.Windows.Forms.Button();
            this.projectsTableAdapter = new MECHClubApp.MECHDatabaseDataSetTableAdapters.projectsTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ordersTableAdapter = new MECHClubApp.MECHDatabaseDataSetTableAdapters.ordersTableAdapter();
            this.projectPartsForm = new System.Windows.Forms.Button();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mECHDatabaseDataSet = new MECHClubApp.MECHDatabaseDataSet();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTableAdapter = new MECHClubApp.MECHDatabaseDataSetTableAdapters.eventsTableAdapter();
            this.database1DataSet = new MECHClubApp.Database1DataSet();
            this.eventsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTableAdapter1 = new MECHClubApp.Database1DataSetTableAdapters.eventsTableAdapter();
            this.tableAdapterManager = new MECHClubApp.Database1DataSetTableAdapters.TableAdapterManager();
            this.eventsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eventsForm
            // 
            this.eventsForm.Location = new System.Drawing.Point(689, 225);
            this.eventsForm.Name = "eventsForm";
            this.eventsForm.Size = new System.Drawing.Size(126, 43);
            this.eventsForm.TabIndex = 19;
            this.eventsForm.Text = "Events";
            this.eventsForm.UseVisualStyleBackColor = true;
            this.eventsForm.Click += new System.EventHandler(this.eventsForm_Click);
            // 
            // ordersForm
            // 
            this.ordersForm.Location = new System.Drawing.Point(808, 225);
            this.ordersForm.Name = "ordersForm";
            this.ordersForm.Size = new System.Drawing.Size(126, 43);
            this.ordersForm.TabIndex = 18;
            this.ordersForm.Text = "Orders";
            this.ordersForm.UseVisualStyleBackColor = true;
            this.ordersForm.Click += new System.EventHandler(this.ordersForm_Click);
            // 
            // partsForm
            // 
            this.partsForm.Location = new System.Drawing.Point(928, 225);
            this.partsForm.Name = "partsForm";
            this.partsForm.Size = new System.Drawing.Size(126, 43);
            this.partsForm.TabIndex = 16;
            this.partsForm.Text = "Parts";
            this.partsForm.UseVisualStyleBackColor = true;
            this.partsForm.Click += new System.EventHandler(this.partsForm_Click);
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(834, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 56);
            this.button3.TabIndex = 15;
            this.button3.Text = "Filter Events";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 56);
            this.button2.TabIndex = 14;
            this.button2.Text = "Delete Event";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add Event";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // projectPartsForm
            // 
            this.projectPartsForm.Location = new System.Drawing.Point(1049, 225);
            this.projectPartsForm.Name = "projectPartsForm";
            this.projectPartsForm.Size = new System.Drawing.Size(126, 43);
            this.projectPartsForm.TabIndex = 17;
            this.projectPartsForm.Text = "Project Parts";
            this.projectPartsForm.UseVisualStyleBackColor = true;
            this.projectPartsForm.Click += new System.EventHandler(this.projectPartsForm_Click);
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
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "projects";
            this.projectsBindingSource.DataSource = this.mECHDatabaseDataSet;
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
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsBindingSource1
            // 
            this.eventsBindingSource1.DataMember = "events";
            this.eventsBindingSource1.DataSource = this.database1DataSet;
            // 
            // eventsTableAdapter1
            // 
            this.eventsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.eventsTableAdapter = this.eventsTableAdapter1;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.partsTableAdapter = null;
            this.tableAdapterManager.project_partsTableAdapter = null;
            this.tableAdapterManager.projectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MECHClubApp.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eventsDataGridView
            // 
            this.eventsDataGridView.AutoGenerateColumns = false;
            this.eventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.eventsDataGridView.DataSource = this.eventsBindingSource1;
            this.eventsDataGridView.Location = new System.Drawing.Point(12, 267);
            this.eventsDataGridView.Name = "eventsDataGridView";
            this.eventsDataGridView.Size = new System.Drawing.Size(1163, 347);
            this.eventsDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "event_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "event_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "proj_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "proj_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "e_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "e_date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "event_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "event_name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "location";
            this.dataGridViewTextBoxColumn5.HeaderText = "location";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "event_cost";
            this.dataGridViewTextBoxColumn6.HeaderText = "event_cost";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 626);
            this.Controls.Add(this.eventsDataGridView);
            this.Controls.Add(this.eventsForm);
            this.Controls.Add(this.ordersForm);
            this.Controls.Add(this.partsForm);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.projectPartsForm);
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eventsForm;
        private System.Windows.Forms.Button ordersForm;
        private System.Windows.Forms.Button partsForm;
        private MECHDatabaseDataSetTableAdapters.projectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private MECHDatabaseDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Button projectPartsForm;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private MECHDatabaseDataSet mECHDatabaseDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private MECHDatabaseDataSetTableAdapters.eventsTableAdapter eventsTableAdapter;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource eventsBindingSource1;
        private Database1DataSetTableAdapters.eventsTableAdapter eventsTableAdapter1;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView eventsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}