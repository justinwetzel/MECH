namespace MECHClubApp
{
    partial class FilterParts
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lowestQuantity = new System.Windows.Forms.RadioButton();
            this.highestQuantity = new System.Windows.Forms.RadioButton();
            this.leastExpFilter = new System.Windows.Forms.RadioButton();
            this.expensiveFilter = new System.Windows.Forms.RadioButton();
            this.vendorFilter = new System.Windows.Forms.RadioButton();
            this.typeFilter = new System.Windows.Forms.RadioButton();
            this.vendorCombo = new System.Windows.Forms.ComboBox();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 55);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.typeCombo);
            this.groupBox1.Controls.Add(this.vendorCombo);
            this.groupBox1.Controls.Add(this.lowestQuantity);
            this.groupBox1.Controls.Add(this.highestQuantity);
            this.groupBox1.Controls.Add(this.leastExpFilter);
            this.groupBox1.Controls.Add(this.expensiveFilter);
            this.groupBox1.Controls.Add(this.vendorFilter);
            this.groupBox1.Controls.Add(this.typeFilter);
            this.groupBox1.Location = new System.Drawing.Point(34, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 304);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose your Filter";
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
            this.leastExpFilter.Size = new System.Drawing.Size(130, 17);
            this.leastExpFilter.TabIndex = 13;
            this.leastExpFilter.TabStop = true;
            this.leastExpFilter.Text = "Least Expensive Parts";
            this.leastExpFilter.UseVisualStyleBackColor = true;
            // 
            // expensiveFilter
            // 
            this.expensiveFilter.AutoSize = true;
            this.expensiveFilter.Location = new System.Drawing.Point(27, 120);
            this.expensiveFilter.Name = "expensiveFilter";
            this.expensiveFilter.Size = new System.Drawing.Size(127, 17);
            this.expensiveFilter.TabIndex = 12;
            this.expensiveFilter.TabStop = true;
            this.expensiveFilter.Text = "Most Expensive Parts";
            this.expensiveFilter.UseVisualStyleBackColor = true;
            // 
            // vendorFilter
            // 
            this.vendorFilter.AutoSize = true;
            this.vendorFilter.Location = new System.Drawing.Point(27, 78);
            this.vendorFilter.Name = "vendorFilter";
            this.vendorFilter.Size = new System.Drawing.Size(98, 17);
            this.vendorFilter.TabIndex = 11;
            this.vendorFilter.TabStop = true;
            this.vendorFilter.Text = "Filter by Vendor";
            this.vendorFilter.UseVisualStyleBackColor = true;
            // 
            // typeFilter
            // 
            this.typeFilter.AutoSize = true;
            this.typeFilter.Location = new System.Drawing.Point(27, 37);
            this.typeFilter.Name = "typeFilter";
            this.typeFilter.Size = new System.Drawing.Size(88, 17);
            this.typeFilter.TabIndex = 10;
            this.typeFilter.TabStop = true;
            this.typeFilter.Text = "Filter by Type";
            this.typeFilter.UseVisualStyleBackColor = true;
            // 
            // vendorCombo
            // 
            this.vendorCombo.FormattingEnabled = true;
            this.vendorCombo.Location = new System.Drawing.Point(199, 78);
            this.vendorCombo.Name = "vendorCombo";
            this.vendorCombo.Size = new System.Drawing.Size(121, 21);
            this.vendorCombo.TabIndex = 16;
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Location = new System.Drawing.Point(199, 37);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(121, 21);
            this.typeCombo.TabIndex = 17;
            // 
            // FilterParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FilterParts";
            this.Text = "FilterParts";
            this.Load += new System.EventHandler(this.FilterParts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton lowestQuantity;
        private System.Windows.Forms.RadioButton highestQuantity;
        private System.Windows.Forms.RadioButton leastExpFilter;
        private System.Windows.Forms.RadioButton expensiveFilter;
        private System.Windows.Forms.RadioButton vendorFilter;
        private System.Windows.Forms.RadioButton typeFilter;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.ComboBox vendorCombo;
    }
}