namespace MECHClubApp
{
    partial class EventsPage
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
            this.filter_events_button = new System.Windows.Forms.Button();
            this.delete_event_button = new System.Windows.Forms.Button();
            this.add_event_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mECHDatabaseDataSet = new MECHClubApp.MECHDatabaseDataSet();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTableAdapter = new MECHClubApp.MECHDatabaseDataSetTableAdapters.eventsTableAdapter();
            this.eventidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // filter_events_button
            // 
            this.filter_events_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.filter_events_button.Location = new System.Drawing.Point(847, 62);
            this.filter_events_button.Name = "filter_events_button";
            this.filter_events_button.Size = new System.Drawing.Size(158, 52);
            this.filter_events_button.TabIndex = 5;
            this.filter_events_button.Text = "Search Events";
            this.filter_events_button.UseVisualStyleBackColor = true;
            this.filter_events_button.Click += new System.EventHandler(this.filter_part_button_Click);
            // 
            // delete_event_button
            // 
            this.delete_event_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.delete_event_button.Location = new System.Drawing.Point(516, 62);
            this.delete_event_button.Name = "delete_event_button";
            this.delete_event_button.Size = new System.Drawing.Size(158, 52);
            this.delete_event_button.TabIndex = 4;
            this.delete_event_button.Text = "Remove Event";
            this.delete_event_button.UseVisualStyleBackColor = true;
            this.delete_event_button.Click += new System.EventHandler(this.delete_part_button_Click);
            // 
            // add_event_button
            // 
            this.add_event_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.add_event_button.Location = new System.Drawing.Point(170, 62);
            this.add_event_button.Name = "add_event_button";
            this.add_event_button.Size = new System.Drawing.Size(158, 52);
            this.add_event_button.TabIndex = 3;
            this.add_event_button.Text = "Create Event";
            this.add_event_button.UseVisualStyleBackColor = true;
            this.add_event_button.Click += new System.EventHandler(this.add_part_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventidDataGridViewTextBoxColumn,
            this.projidDataGridViewTextBoxColumn,
            this.edateDataGridViewTextBoxColumn,
            this.eventnameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.eventcostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eventsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1151, 298);
            this.dataGridView1.TabIndex = 6;
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
            // eventidDataGridViewTextBoxColumn
            // 
            this.eventidDataGridViewTextBoxColumn.DataPropertyName = "event_id";
            this.eventidDataGridViewTextBoxColumn.HeaderText = "event_id";
            this.eventidDataGridViewTextBoxColumn.Name = "eventidDataGridViewTextBoxColumn";
            // 
            // projidDataGridViewTextBoxColumn
            // 
            this.projidDataGridViewTextBoxColumn.DataPropertyName = "proj_id";
            this.projidDataGridViewTextBoxColumn.HeaderText = "proj_id";
            this.projidDataGridViewTextBoxColumn.Name = "projidDataGridViewTextBoxColumn";
            // 
            // edateDataGridViewTextBoxColumn
            // 
            this.edateDataGridViewTextBoxColumn.DataPropertyName = "e_date";
            this.edateDataGridViewTextBoxColumn.HeaderText = "e_date";
            this.edateDataGridViewTextBoxColumn.Name = "edateDataGridViewTextBoxColumn";
            // 
            // eventnameDataGridViewTextBoxColumn
            // 
            this.eventnameDataGridViewTextBoxColumn.DataPropertyName = "event_name";
            this.eventnameDataGridViewTextBoxColumn.HeaderText = "event_name";
            this.eventnameDataGridViewTextBoxColumn.Name = "eventnameDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // eventcostDataGridViewTextBoxColumn
            // 
            this.eventcostDataGridViewTextBoxColumn.DataPropertyName = "event_cost";
            this.eventcostDataGridViewTextBoxColumn.HeaderText = "event_cost";
            this.eventcostDataGridViewTextBoxColumn.Name = "eventcostDataGridViewTextBoxColumn";
            // 
            // EventsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 626);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filter_events_button);
            this.Controls.Add(this.delete_event_button);
            this.Controls.Add(this.add_event_button);
            this.Name = "EventsPage";
            this.Text = "EventsPage";
            this.Load += new System.EventHandler(this.EventsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button filter_events_button;
        private System.Windows.Forms.Button delete_event_button;
        private System.Windows.Forms.Button add_event_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MECHDatabaseDataSet mECHDatabaseDataSet;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private MECHDatabaseDataSetTableAdapters.eventsTableAdapter eventsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventcostDataGridViewTextBoxColumn;
    }
}