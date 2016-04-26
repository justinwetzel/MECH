namespace MECHClubApp
{
    partial class AddPart
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
                components.Dispose(); //testing github push
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.partQuantity = new System.Windows.Forms.ComboBox();
            this.partType = new System.Windows.Forms.ComboBox();
            this.partName = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.vendor = new System.Windows.Forms.TextBox();
            this.vendorUrl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Part Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vendor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vendor URL";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // partQuantity
            // 
            this.partQuantity.FormattingEnabled = true;
            this.partQuantity.Location = new System.Drawing.Point(198, 120);
            this.partQuantity.Name = "partQuantity";
            this.partQuantity.Size = new System.Drawing.Size(121, 21);
            this.partQuantity.TabIndex = 6;
            this.partQuantity.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // partType
            // 
            this.partType.FormattingEnabled = true;
            this.partType.Location = new System.Drawing.Point(198, 160);
            this.partType.Name = "partType";
            this.partType.Size = new System.Drawing.Size(121, 21);
            this.partType.TabIndex = 7;
            // 
            // partName
            // 
            this.partName.Location = new System.Drawing.Point(198, 39);
            this.partName.Name = "partName";
            this.partName.Size = new System.Drawing.Size(121, 20);
            this.partName.TabIndex = 8;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(198, 80);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(121, 20);
            this.price.TabIndex = 9;
            // 
            // vendor
            // 
            this.vendor.Location = new System.Drawing.Point(198, 202);
            this.vendor.Name = "vendor";
            this.vendor.Size = new System.Drawing.Size(121, 20);
            this.vendor.TabIndex = 10;
            // 
            // vendorUrl
            // 
            this.vendorUrl.Location = new System.Drawing.Point(198, 244);
            this.vendorUrl.Name = "vendorUrl";
            this.vendorUrl.Size = new System.Drawing.Size(121, 20);
            this.vendorUrl.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 47);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 404);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vendorUrl);
            this.Controls.Add(this.vendor);
            this.Controls.Add(this.price);
            this.Controls.Add(this.partName);
            this.Controls.Add(this.partType);
            this.Controls.Add(this.partQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPart";
            this.Text = "AddPart";
            this.Load += new System.EventHandler(this.AddPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox partQuantity;
        private System.Windows.Forms.ComboBox partType;
        private System.Windows.Forms.TextBox partName;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox vendor;
        private System.Windows.Forms.TextBox vendorUrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}