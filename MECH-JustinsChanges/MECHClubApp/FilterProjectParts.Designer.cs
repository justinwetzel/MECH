namespace MECHClubApp
{
    partial class FilterProjectParts
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
            this.leastFilter = new System.Windows.Forms.RadioButton();
            this.mostFilter = new System.Windows.Forms.RadioButton();
            this.partFilter = new System.Windows.Forms.RadioButton();
            this.projectFilter = new System.Windows.Forms.RadioButton();
            this.projectCombo = new System.Windows.Forms.ComboBox();
            this.partCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 55);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.partCombo);
            this.groupBox1.Controls.Add(this.projectCombo);
            this.groupBox1.Controls.Add(this.leastFilter);
            this.groupBox1.Controls.Add(this.mostFilter);
            this.groupBox1.Controls.Add(this.partFilter);
            this.groupBox1.Controls.Add(this.projectFilter);
            this.groupBox1.Location = new System.Drawing.Point(25, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 304);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose your Filter";
            // 
            // leastFilter
            // 
            this.leastFilter.AutoSize = true;
            this.leastFilter.Location = new System.Drawing.Point(27, 161);
            this.leastFilter.Name = "leastFilter";
            this.leastFilter.Size = new System.Drawing.Size(119, 17);
            this.leastFilter.TabIndex = 13;
            this.leastFilter.TabStop = true;
            this.leastFilter.Text = "Least Needed Parts";
            this.leastFilter.UseVisualStyleBackColor = true;
            // 
            // mostFilter
            // 
            this.mostFilter.AutoSize = true;
            this.mostFilter.Location = new System.Drawing.Point(27, 120);
            this.mostFilter.Name = "mostFilter";
            this.mostFilter.Size = new System.Drawing.Size(116, 17);
            this.mostFilter.TabIndex = 12;
            this.mostFilter.TabStop = true;
            this.mostFilter.Text = "Most Needed Parts";
            this.mostFilter.UseVisualStyleBackColor = true;
            this.mostFilter.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // partFilter
            // 
            this.partFilter.AutoSize = true;
            this.partFilter.Location = new System.Drawing.Point(27, 78);
            this.partFilter.Name = "partFilter";
            this.partFilter.Size = new System.Drawing.Size(119, 17);
            this.partFilter.TabIndex = 11;
            this.partFilter.TabStop = true;
            this.partFilter.Text = "Filter by Project Part";
            this.partFilter.UseVisualStyleBackColor = true;
            // 
            // projectFilter
            // 
            this.projectFilter.AutoSize = true;
            this.projectFilter.Location = new System.Drawing.Point(27, 37);
            this.projectFilter.Name = "projectFilter";
            this.projectFilter.Size = new System.Drawing.Size(97, 17);
            this.projectFilter.TabIndex = 10;
            this.projectFilter.TabStop = true;
            this.projectFilter.Text = "Filter by Project";
            this.projectFilter.UseVisualStyleBackColor = true;
            this.projectFilter.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // projectCombo
            // 
            this.projectCombo.FormattingEnabled = true;
            this.projectCombo.Location = new System.Drawing.Point(200, 37);
            this.projectCombo.Name = "projectCombo";
            this.projectCombo.Size = new System.Drawing.Size(121, 21);
            this.projectCombo.TabIndex = 18;
            // 
            // partCombo
            // 
            this.partCombo.FormattingEnabled = true;
            this.partCombo.Location = new System.Drawing.Point(200, 78);
            this.partCombo.Name = "partCombo";
            this.partCombo.Size = new System.Drawing.Size(121, 21);
            this.partCombo.TabIndex = 19;
            // 
            // FilterProjectParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FilterProjectParts";
            this.Text = "FilterProjectParts";
            this.Load += new System.EventHandler(this.FilterProjectParts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton leastFilter;
        private System.Windows.Forms.RadioButton mostFilter;
        private System.Windows.Forms.RadioButton partFilter;
        private System.Windows.Forms.RadioButton projectFilter;
        private System.Windows.Forms.ComboBox partCombo;
        private System.Windows.Forms.ComboBox projectCombo;
    }
}