namespace MECHClubApp
{
    partial class FilterEvents
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
            this.eventDate = new System.Windows.Forms.DateTimePicker();
            this.eventName = new System.Windows.Forms.ComboBox();
            this.locationFilter = new System.Windows.Forms.RadioButton();
            this.projectFilter = new System.Windows.Forms.RadioButton();
            this.dateFilter = new System.Windows.Forms.RadioButton();
            this.nameFilter = new System.Windows.Forms.RadioButton();
            this.cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idCombo = new System.Windows.Forms.ComboBox();
            this.locationCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.locationCombo);
            this.groupBox1.Controls.Add(this.idCombo);
            this.groupBox1.Controls.Add(this.eventDate);
            this.groupBox1.Controls.Add(this.eventName);
            this.groupBox1.Controls.Add(this.locationFilter);
            this.groupBox1.Controls.Add(this.projectFilter);
            this.groupBox1.Controls.Add(this.dateFilter);
            this.groupBox1.Controls.Add(this.nameFilter);
            this.groupBox1.Location = new System.Drawing.Point(37, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 304);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose your Filter";
            // 
            // eventDate
            // 
            this.eventDate.Location = new System.Drawing.Point(150, 88);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(200, 20);
            this.eventDate.TabIndex = 18;
            // 
            // eventName
            // 
            this.eventName.FormattingEnabled = true;
            this.eventName.Location = new System.Drawing.Point(199, 52);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(121, 21);
            this.eventName.TabIndex = 17;
            this.eventName.SelectedIndexChanged += new System.EventHandler(this.eventName_SelectedIndexChanged);
            // 
            // locationFilter
            // 
            this.locationFilter.AutoSize = true;
            this.locationFilter.Location = new System.Drawing.Point(27, 198);
            this.locationFilter.Name = "locationFilter";
            this.locationFilter.Size = new System.Drawing.Size(105, 17);
            this.locationFilter.TabIndex = 13;
            this.locationFilter.TabStop = true;
            this.locationFilter.Text = "Filter by Location";
            this.locationFilter.UseVisualStyleBackColor = true;
            // 
            // projectFilter
            // 
            this.projectFilter.AutoSize = true;
            this.projectFilter.Location = new System.Drawing.Point(27, 154);
            this.projectFilter.Name = "projectFilter";
            this.projectFilter.Size = new System.Drawing.Size(109, 17);
            this.projectFilter.TabIndex = 12;
            this.projectFilter.TabStop = true;
            this.projectFilter.Text = "Filter by Project Id";
            this.projectFilter.UseVisualStyleBackColor = true;
            // 
            // dateFilter
            // 
            this.dateFilter.AutoSize = true;
            this.dateFilter.Location = new System.Drawing.Point(27, 104);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(202, 30);
            this.dateFilter.TabIndex = 11;
            this.dateFilter.TabStop = true;
            this.dateFilter.Text = "Filter by Date\r\n(Only orders before the selected date)\r\n";
            this.dateFilter.UseVisualStyleBackColor = true;
            // 
            // nameFilter
            // 
            this.nameFilter.AutoSize = true;
            this.nameFilter.Location = new System.Drawing.Point(27, 52);
            this.nameFilter.Name = "nameFilter";
            this.nameFilter.Size = new System.Drawing.Size(123, 17);
            this.nameFilter.TabIndex = 10;
            this.nameFilter.TabStop = true;
            this.nameFilter.Text = "Filter by Event Name";
            this.nameFilter.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(245, 388);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(112, 55);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 55);
            this.button1.TabIndex = 13;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idCombo
            // 
            this.idCombo.FormattingEnabled = true;
            this.idCombo.Location = new System.Drawing.Point(199, 154);
            this.idCombo.Name = "idCombo";
            this.idCombo.Size = new System.Drawing.Size(121, 21);
            this.idCombo.TabIndex = 19;
            // 
            // locationCombo
            // 
            this.locationCombo.FormattingEnabled = true;
            this.locationCombo.Location = new System.Drawing.Point(199, 198);
            this.locationCombo.Name = "locationCombo";
            this.locationCombo.Size = new System.Drawing.Size(121, 21);
            this.locationCombo.TabIndex = 20;
            // 
            // FilterEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.button1);
            this.Name = "FilterEvents";
            this.Text = "FilterEvents";
            this.Load += new System.EventHandler(this.FilterEvents_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker eventDate;
        private System.Windows.Forms.ComboBox eventName;
        private System.Windows.Forms.RadioButton locationFilter;
        private System.Windows.Forms.RadioButton projectFilter;
        private System.Windows.Forms.RadioButton dateFilter;
        private System.Windows.Forms.RadioButton nameFilter;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox locationCombo;
        private System.Windows.Forms.ComboBox idCombo;
    }
}