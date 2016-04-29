namespace MECHClubApp
{
    partial class FilterOrders
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderStatus = new System.Windows.Forms.ComboBox();
            this.lowestQuantity = new System.Windows.Forms.RadioButton();
            this.highestQuantity = new System.Windows.Forms.RadioButton();
            this.leastExpFilter = new System.Windows.Forms.RadioButton();
            this.expensiveFilter = new System.Windows.Forms.RadioButton();
            this.dateFilter = new System.Windows.Forms.RadioButton();
            this.statusFilter = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderDate);
            this.groupBox1.Controls.Add(this.orderStatus);
            this.groupBox1.Controls.Add(this.lowestQuantity);
            this.groupBox1.Controls.Add(this.highestQuantity);
            this.groupBox1.Controls.Add(this.leastExpFilter);
            this.groupBox1.Controls.Add(this.expensiveFilter);
            this.groupBox1.Controls.Add(this.dateFilter);
            this.groupBox1.Controls.Add(this.statusFilter);
            this.groupBox1.Location = new System.Drawing.Point(33, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 304);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose your Filter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // orderStatus
            // 
            this.orderStatus.FormattingEnabled = true;
            this.orderStatus.Location = new System.Drawing.Point(199, 37);
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.Size = new System.Drawing.Size(121, 21);
            this.orderStatus.TabIndex = 17;
            // 
            // lowestQuantity
            // 
            this.lowestQuantity.AutoSize = true;
            this.lowestQuantity.Location = new System.Drawing.Point(27, 249);
            this.lowestQuantity.Name = "lowestQuantity";
            this.lowestQuantity.Size = new System.Drawing.Size(101, 17);
            this.lowestQuantity.TabIndex = 15;
            this.lowestQuantity.TabStop = true;
            this.lowestQuantity.Text = "Lowest Quantity";
            this.lowestQuantity.UseVisualStyleBackColor = true;
            // 
            // highestQuantity
            // 
            this.highestQuantity.AutoSize = true;
            this.highestQuantity.Location = new System.Drawing.Point(27, 203);
            this.highestQuantity.Name = "highestQuantity";
            this.highestQuantity.Size = new System.Drawing.Size(103, 17);
            this.highestQuantity.TabIndex = 14;
            this.highestQuantity.TabStop = true;
            this.highestQuantity.Text = "Highest Quantity";
            this.highestQuantity.UseVisualStyleBackColor = true;
            // 
            // leastExpFilter
            // 
            this.leastExpFilter.AutoSize = true;
            this.leastExpFilter.Location = new System.Drawing.Point(27, 161);
            this.leastExpFilter.Name = "leastExpFilter";
            this.leastExpFilter.Size = new System.Drawing.Size(137, 17);
            this.leastExpFilter.TabIndex = 13;
            this.leastExpFilter.TabStop = true;
            this.leastExpFilter.Text = "Least Expensive Orders";
            this.leastExpFilter.UseVisualStyleBackColor = true;
            // 
            // expensiveFilter
            // 
            this.expensiveFilter.AutoSize = true;
            this.expensiveFilter.Location = new System.Drawing.Point(27, 120);
            this.expensiveFilter.Name = "expensiveFilter";
            this.expensiveFilter.Size = new System.Drawing.Size(134, 17);
            this.expensiveFilter.TabIndex = 12;
            this.expensiveFilter.TabStop = true;
            this.expensiveFilter.Text = "Most Expensive Orders";
            this.expensiveFilter.UseVisualStyleBackColor = true;
            // 
            // dateFilter
            // 
            this.dateFilter.AutoSize = true;
            this.dateFilter.Location = new System.Drawing.Point(27, 78);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(87, 17);
            this.dateFilter.TabIndex = 11;
            this.dateFilter.TabStop = true;
            this.dateFilter.Text = "Filter by Date\r\n";
            this.dateFilter.UseVisualStyleBackColor = true;
            // 
            // statusFilter
            // 
            this.statusFilter.AutoSize = true;
            this.statusFilter.Location = new System.Drawing.Point(27, 37);
            this.statusFilter.Name = "statusFilter";
            this.statusFilter.Size = new System.Drawing.Size(94, 17);
            this.statusFilter.TabIndex = 10;
            this.statusFilter.TabStop = true;
            this.statusFilter.Text = "Filter by Status";
            this.statusFilter.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 55);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderDate
            // 
            this.orderDate.Location = new System.Drawing.Point(150, 78);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(200, 20);
            this.orderDate.TabIndex = 18;
            // 
            // FilterOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FilterOrders";
            this.Text = "FilterOrders";
            this.Load += new System.EventHandler(this.FilterOrders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox orderStatus;
        private System.Windows.Forms.RadioButton lowestQuantity;
        private System.Windows.Forms.RadioButton highestQuantity;
        private System.Windows.Forms.RadioButton leastExpFilter;
        private System.Windows.Forms.RadioButton expensiveFilter;
        private System.Windows.Forms.RadioButton dateFilter;
        private System.Windows.Forms.RadioButton statusFilter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker orderDate;
    }
}