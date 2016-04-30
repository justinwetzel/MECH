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
            this.partsForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.projectPartsForm = new System.Windows.Forms.Button();
            this.projectsForm = new System.Windows.Forms.Button();
            this.eventsGrid = new System.Windows.Forms.DataGridView();
            this.filterEvents = new System.Windows.Forms.Button();
            this.deleteEvent = new System.Windows.Forms.Button();
            this.addEvent = new System.Windows.Forms.Button();
            this.mECHDatabaseDataSet = new MECHClubApp.MECHDatabaseDataSet();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTableAdapter = new MECHClubApp.MECHDatabaseDataSetTableAdapters.eventsTableAdapter();
            this.eventidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eventsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // partsForm
            // 
            this.partsForm.Location = new System.Drawing.Point(690, 278);
            this.partsForm.Name = "partsForm";
            this.partsForm.Size = new System.Drawing.Size(126, 43);
            this.partsForm.TabIndex = 15;
            this.partsForm.Text = "Parts";
            this.partsForm.UseVisualStyleBackColor = true;
            this.partsForm.Click += new System.EventHandler(this.partsForm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(809, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // projectPartsForm
            // 
            this.projectPartsForm.Location = new System.Drawing.Point(1050, 278);
            this.projectPartsForm.Name = "projectPartsForm";
            this.projectPartsForm.Size = new System.Drawing.Size(126, 43);
            this.projectPartsForm.TabIndex = 13;
            this.projectPartsForm.Text = "Project Parts";
            this.projectPartsForm.UseVisualStyleBackColor = true;
            this.projectPartsForm.Click += new System.EventHandler(this.projectPartsForm_Click);
            // 
            // projectsForm
            // 
            this.projectsForm.Location = new System.Drawing.Point(929, 278);
            this.projectsForm.Name = "projectsForm";
            this.projectsForm.Size = new System.Drawing.Size(126, 43);
            this.projectsForm.TabIndex = 12;
            this.projectsForm.Text = "Projects";
            this.projectsForm.UseVisualStyleBackColor = true;
            this.projectsForm.Click += new System.EventHandler(this.projectsForm_Click);
            // 
            // eventsGrid
            // 
            this.eventsGrid.AutoGenerateColumns = false;
            this.eventsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventidDataGridViewTextBoxColumn,
            this.projidDataGridViewTextBoxColumn,
            this.edateDataGridViewTextBoxColumn,
            this.eventnameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.eventcostDataGridViewTextBoxColumn});
            this.eventsGrid.DataSource = this.eventsBindingSource;
            this.eventsGrid.Location = new System.Drawing.Point(1, 318);
            this.eventsGrid.Name = "eventsGrid";
            this.eventsGrid.Size = new System.Drawing.Size(1173, 309);
            this.eventsGrid.TabIndex = 11;
            // 
            // filterEvents
            // 
            this.filterEvents.Location = new System.Drawing.Point(829, 116);
            this.filterEvents.Name = "filterEvents";
            this.filterEvents.Size = new System.Drawing.Size(158, 52);
            this.filterEvents.TabIndex = 10;
            this.filterEvents.Text = "Filter Events";
            this.filterEvents.UseVisualStyleBackColor = true;
            this.filterEvents.Click += new System.EventHandler(this.filterEvents_Click);
            // 
            // deleteEvent
            // 
            this.deleteEvent.Location = new System.Drawing.Point(498, 116);
            this.deleteEvent.Name = "deleteEvent";
            this.deleteEvent.Size = new System.Drawing.Size(158, 52);
            this.deleteEvent.TabIndex = 9;
            this.deleteEvent.Text = "Delete Event";
            this.deleteEvent.UseVisualStyleBackColor = true;
            this.deleteEvent.Click += new System.EventHandler(this.deleteEvent_Click);
            // 
            // addEvent
            // 
            this.addEvent.Location = new System.Drawing.Point(152, 116);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(158, 52);
            this.addEvent.TabIndex = 8;
            this.addEvent.Text = "Add Event";
            this.addEvent.UseVisualStyleBackColor = true;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
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
            this.eventidDataGridViewTextBoxColumn.HeaderText = "Event Id";
            this.eventidDataGridViewTextBoxColumn.Name = "eventidDataGridViewTextBoxColumn";
            this.eventidDataGridViewTextBoxColumn.Width = 175;
            // 
            // projidDataGridViewTextBoxColumn
            // 
            this.projidDataGridViewTextBoxColumn.DataPropertyName = "proj_id";
            this.projidDataGridViewTextBoxColumn.HeaderText = "Project Id";
            this.projidDataGridViewTextBoxColumn.Name = "projidDataGridViewTextBoxColumn";
            this.projidDataGridViewTextBoxColumn.Width = 175;
            // 
            // edateDataGridViewTextBoxColumn
            // 
            this.edateDataGridViewTextBoxColumn.DataPropertyName = "e_date";
            this.edateDataGridViewTextBoxColumn.HeaderText = "Event Date";
            this.edateDataGridViewTextBoxColumn.Name = "edateDataGridViewTextBoxColumn";
            this.edateDataGridViewTextBoxColumn.Width = 180;
            // 
            // eventnameDataGridViewTextBoxColumn
            // 
            this.eventnameDataGridViewTextBoxColumn.DataPropertyName = "event_name";
            this.eventnameDataGridViewTextBoxColumn.HeaderText = "Event Name";
            this.eventnameDataGridViewTextBoxColumn.Name = "eventnameDataGridViewTextBoxColumn";
            this.eventnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 200;
            // 
            // eventcostDataGridViewTextBoxColumn
            // 
            this.eventcostDataGridViewTextBoxColumn.DataPropertyName = "event_cost";
            this.eventcostDataGridViewTextBoxColumn.HeaderText = "Event Cost";
            this.eventcostDataGridViewTextBoxColumn.Name = "eventcostDataGridViewTextBoxColumn";
            this.eventcostDataGridViewTextBoxColumn.Width = 200;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 626);
            this.Controls.Add(this.partsForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.projectPartsForm);
            this.Controls.Add(this.projectsForm);
            this.Controls.Add(this.eventsGrid);
            this.Controls.Add(this.filterEvents);
            this.Controls.Add(this.deleteEvent);
            this.Controls.Add(this.addEvent);
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button partsForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button projectPartsForm;
        private System.Windows.Forms.Button projectsForm;
        private System.Windows.Forms.DataGridView eventsGrid;
        private System.Windows.Forms.Button filterEvents;
        private System.Windows.Forms.Button deleteEvent;
        private System.Windows.Forms.Button addEvent;
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