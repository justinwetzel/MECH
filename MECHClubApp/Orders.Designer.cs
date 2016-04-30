namespace MECHClubApp
{
    partial class Orders
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
            this.projectsForm = new System.Windows.Forms.Button();
            this.projectPartsForm = new System.Windows.Forms.Button();
            this.partsForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.deleteOrder = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.ordersGrid = new System.Windows.Forms.DataGridView();
            this.mECHDatabaseDataSet = new MECHClubApp.MECHDatabaseDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new MECHClubApp.MECHDatabaseDataSetTableAdapters.ordersTableAdapter();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eventsForm
            // 
            this.eventsForm.Location = new System.Drawing.Point(688, 263);
            this.eventsForm.Name = "eventsForm";
            this.eventsForm.Size = new System.Drawing.Size(126, 43);
            this.eventsForm.TabIndex = 19;
            this.eventsForm.Text = "Events";
            this.eventsForm.UseVisualStyleBackColor = true;
            this.eventsForm.Click += new System.EventHandler(this.eventsForm_Click);
            // 
            // projectsForm
            // 
            this.projectsForm.Location = new System.Drawing.Point(807, 263);
            this.projectsForm.Name = "projectsForm";
            this.projectsForm.Size = new System.Drawing.Size(126, 43);
            this.projectsForm.TabIndex = 18;
            this.projectsForm.Text = "Projects";
            this.projectsForm.UseVisualStyleBackColor = true;
            this.projectsForm.Click += new System.EventHandler(this.projectsForm_Click);
            // 
            // projectPartsForm
            // 
            this.projectPartsForm.Location = new System.Drawing.Point(1048, 263);
            this.projectPartsForm.Name = "projectPartsForm";
            this.projectPartsForm.Size = new System.Drawing.Size(126, 43);
            this.projectPartsForm.TabIndex = 17;
            this.projectPartsForm.Text = "Project Parts";
            this.projectPartsForm.UseVisualStyleBackColor = true;
            this.projectPartsForm.Click += new System.EventHandler(this.projectPartsForm_Click);
            // 
            // partsForm
            // 
            this.partsForm.Location = new System.Drawing.Point(927, 263);
            this.partsForm.Name = "partsForm";
            this.partsForm.Size = new System.Drawing.Size(126, 43);
            this.partsForm.TabIndex = 16;
            this.partsForm.Text = "Parts";
            this.partsForm.UseVisualStyleBackColor = true;
            this.partsForm.Click += new System.EventHandler(this.partsForm_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(833, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 56);
            this.button3.TabIndex = 15;
            this.button3.Text = "Filter Orders";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleteOrder
            // 
            this.deleteOrder.Location = new System.Drawing.Point(484, 75);
            this.deleteOrder.Name = "deleteOrder";
            this.deleteOrder.Size = new System.Drawing.Size(156, 56);
            this.deleteOrder.TabIndex = 14;
            this.deleteOrder.Text = "Delete Order";
            this.deleteOrder.UseVisualStyleBackColor = true;
            this.deleteOrder.Click += new System.EventHandler(this.deleteOrder_Click);
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(135, 75);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(156, 56);
            this.addOrder.TabIndex = 13;
            this.addOrder.Text = "Add Order";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // ordersGrid
            // 
            this.ordersGrid.AutoGenerateColumns = false;
            this.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.ordernumberDataGridViewTextBoxColumn,
            this.partidDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.costsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.odateDataGridViewTextBoxColumn});
            this.ordersGrid.DataSource = this.ordersBindingSource;
            this.ordersGrid.Location = new System.Drawing.Point(-1, 303);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.Size = new System.Drawing.Size(1174, 324);
            this.ordersGrid.TabIndex = 12;
            // 
            // mECHDatabaseDataSet
            // 
            this.mECHDatabaseDataSet.DataSetName = "MECHDatabaseDataSet";
            this.mECHDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.mECHDatabaseDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "Order Id";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.Width = 175;
            // 
            // ordernumberDataGridViewTextBoxColumn
            // 
            this.ordernumberDataGridViewTextBoxColumn.DataPropertyName = "order_number";
            this.ordernumberDataGridViewTextBoxColumn.HeaderText = "Order Number";
            this.ordernumberDataGridViewTextBoxColumn.Name = "ordernumberDataGridViewTextBoxColumn";
            this.ordernumberDataGridViewTextBoxColumn.Width = 175;
            // 
            // partidDataGridViewTextBoxColumn
            // 
            this.partidDataGridViewTextBoxColumn.DataPropertyName = "part_id";
            this.partidDataGridViewTextBoxColumn.HeaderText = "Part Id";
            this.partidDataGridViewTextBoxColumn.Name = "partidDataGridViewTextBoxColumn";
            this.partidDataGridViewTextBoxColumn.Width = 175;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // costsDataGridViewTextBoxColumn
            // 
            this.costsDataGridViewTextBoxColumn.DataPropertyName = "costs";
            this.costsDataGridViewTextBoxColumn.HeaderText = "Costs";
            this.costsDataGridViewTextBoxColumn.Name = "costsDataGridViewTextBoxColumn";
            this.costsDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // odateDataGridViewTextBoxColumn
            // 
            this.odateDataGridViewTextBoxColumn.DataPropertyName = "o_date";
            this.odateDataGridViewTextBoxColumn.HeaderText = "Order Date";
            this.odateDataGridViewTextBoxColumn.Name = "odateDataGridViewTextBoxColumn";
            this.odateDataGridViewTextBoxColumn.Width = 160;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 626);
            this.Controls.Add(this.eventsForm);
            this.Controls.Add(this.projectsForm);
            this.Controls.Add(this.projectPartsForm);
            this.Controls.Add(this.partsForm);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.deleteOrder);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.ordersGrid);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mECHDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eventsForm;
        private System.Windows.Forms.Button projectsForm;
        private System.Windows.Forms.Button projectPartsForm;
        private System.Windows.Forms.Button partsForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button deleteOrder;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.DataGridView ordersGrid;
        private MECHDatabaseDataSet mECHDatabaseDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private MECHDatabaseDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odateDataGridViewTextBoxColumn;
    }
}