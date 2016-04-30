namespace MECHClubApp
{
    partial class FilterProjects
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
            this.versionCombo = new System.Windows.Forms.ComboBox();
            this.contributorCombo = new System.Windows.Forms.ComboBox();
            this.projectCombo = new System.Windows.Forms.ComboBox();
            this.versionFilter = new System.Windows.Forms.RadioButton();
            this.contributorFilter = new System.Windows.Forms.RadioButton();
            this.projectFilter = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 55);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.versionCombo);
            this.groupBox1.Controls.Add(this.contributorCombo);
            this.groupBox1.Controls.Add(this.projectCombo);
            this.groupBox1.Controls.Add(this.versionFilter);
            this.groupBox1.Controls.Add(this.contributorFilter);
            this.groupBox1.Controls.Add(this.projectFilter);
            this.groupBox1.Location = new System.Drawing.Point(32, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 304);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose your Filter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // versionCombo
            // 
            this.versionCombo.FormattingEnabled = true;
            this.versionCombo.Location = new System.Drawing.Point(203, 119);
            this.versionCombo.Name = "versionCombo";
            this.versionCombo.Size = new System.Drawing.Size(121, 21);
            this.versionCombo.TabIndex = 20;
            // 
            // contributorCombo
            // 
            this.contributorCombo.FormattingEnabled = true;
            this.contributorCombo.Location = new System.Drawing.Point(203, 77);
            this.contributorCombo.Name = "contributorCombo";
            this.contributorCombo.Size = new System.Drawing.Size(121, 21);
            this.contributorCombo.TabIndex = 19;
            // 
            // projectCombo
            // 
            this.projectCombo.FormattingEnabled = true;
            this.projectCombo.Location = new System.Drawing.Point(203, 36);
            this.projectCombo.Name = "projectCombo";
            this.projectCombo.Size = new System.Drawing.Size(121, 21);
            this.projectCombo.TabIndex = 18;
            // 
            // versionFilter
            // 
            this.versionFilter.AutoSize = true;
            this.versionFilter.Location = new System.Drawing.Point(27, 120);
            this.versionFilter.Name = "versionFilter";
            this.versionFilter.Size = new System.Drawing.Size(99, 17);
            this.versionFilter.TabIndex = 12;
            this.versionFilter.TabStop = true;
            this.versionFilter.Text = "Filter by Version";
            this.versionFilter.UseVisualStyleBackColor = true;
            // 
            // contributorFilter
            // 
            this.contributorFilter.AutoSize = true;
            this.contributorFilter.Location = new System.Drawing.Point(27, 78);
            this.contributorFilter.Name = "contributorFilter";
            this.contributorFilter.Size = new System.Drawing.Size(115, 17);
            this.contributorFilter.TabIndex = 11;
            this.contributorFilter.TabStop = true;
            this.contributorFilter.Text = "Filter by Contributor";
            this.contributorFilter.UseVisualStyleBackColor = true;
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
            // 
            // FilterProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FilterProjects";
            this.Text = "FilterProjects";
            this.Load += new System.EventHandler(this.FilterProjects_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton versionFilter;
        private System.Windows.Forms.RadioButton contributorFilter;
        private System.Windows.Forms.RadioButton projectFilter;
        private System.Windows.Forms.ComboBox versionCombo;
        private System.Windows.Forms.ComboBox contributorCombo;
        private System.Windows.Forms.ComboBox projectCombo;
    }
}