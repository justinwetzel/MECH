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
            this.endingDate = new System.Windows.Forms.DateTimePicker();
            this.startingDate = new System.Windows.Forms.DateTimePicker();
            this.nameCombo = new System.Windows.Forms.ComboBox();
            this.locationCombo = new System.Windows.Forms.ComboBox();
            this.lowestCost = new System.Windows.Forms.RadioButton();
            this.highestCost = new System.Windows.Forms.RadioButton();
            this.endDateFilter = new System.Windows.Forms.RadioButton();
            this.startDateFilter = new System.Windows.Forms.RadioButton();
            this.locationFilter = new System.Windows.Forms.RadioButton();
            this.eventNameFilter = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.endingDate);
            this.groupBox1.Controls.Add(this.startingDate);
            this.groupBox1.Controls.Add(this.nameCombo);
            this.groupBox1.Controls.Add(this.locationCombo);
            this.groupBox1.Controls.Add(this.lowestCost);
            this.groupBox1.Controls.Add(this.highestCost);
            this.groupBox1.Controls.Add(this.endDateFilter);
            this.groupBox1.Controls.Add(this.startDateFilter);
            this.groupBox1.Controls.Add(this.locationFilter);
            this.groupBox1.Controls.Add(this.eventNameFilter);
            this.groupBox1.Location = new System.Drawing.Point(37, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 304);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose your Filter";
            // 
            // endingDate
            // 
            this.endingDate.Location = new System.Drawing.Point(199, 157);
            this.endingDate.Name = "endingDate";
            this.endingDate.Size = new System.Drawing.Size(121, 20);
            this.endingDate.TabIndex = 39;
            this.endingDate.Value = new System.DateTime(2016, 4, 28, 0, 0, 0, 0);
            // 
            // startingDate
            // 
            this.startingDate.Location = new System.Drawing.Point(199, 116);
            this.startingDate.Name = "startingDate";
            this.startingDate.Size = new System.Drawing.Size(121, 20);
            this.startingDate.TabIndex = 38;
            this.startingDate.Value = new System.DateTime(2016, 4, 28, 0, 0, 0, 0);
            // 
            // nameCombo
            // 
            this.nameCombo.FormattingEnabled = true;
            this.nameCombo.Location = new System.Drawing.Point(199, 37);
            this.nameCombo.Name = "nameCombo";
            this.nameCombo.Size = new System.Drawing.Size(121, 21);
            this.nameCombo.TabIndex = 17;
            // 
            // locationCombo
            // 
            this.locationCombo.FormattingEnabled = true;
            this.locationCombo.Location = new System.Drawing.Point(199, 78);
            this.locationCombo.Name = "locationCombo";
            this.locationCombo.Size = new System.Drawing.Size(121, 21);
            this.locationCombo.TabIndex = 16;
            // 
            // lowestCost
            // 
            this.lowestCost.AutoSize = true;
            this.lowestCost.Location = new System.Drawing.Point(27, 249);
            this.lowestCost.Name = "lowestCost";
            this.lowestCost.Size = new System.Drawing.Size(83, 17);
            this.lowestCost.TabIndex = 15;
            this.lowestCost.TabStop = true;
            this.lowestCost.Text = "Lowest Cost";
            this.lowestCost.UseVisualStyleBackColor = true;
            // 
            // highestCost
            // 
            this.highestCost.AutoSize = true;
            this.highestCost.Location = new System.Drawing.Point(27, 203);
            this.highestCost.Name = "highestCost";
            this.highestCost.Size = new System.Drawing.Size(85, 17);
            this.highestCost.TabIndex = 14;
            this.highestCost.TabStop = true;
            this.highestCost.Text = "Highest Cost";
            this.highestCost.UseVisualStyleBackColor = true;
            // 
            // endDateFilter
            // 
            this.endDateFilter.AutoSize = true;
            this.endDateFilter.Location = new System.Drawing.Point(27, 161);
            this.endDateFilter.Name = "endDateFilter";
            this.endDateFilter.Size = new System.Drawing.Size(84, 17);
            this.endDateFilter.TabIndex = 13;
            this.endDateFilter.TabStop = true;
            this.endDateFilter.Text = "Ending Date";
            this.endDateFilter.UseVisualStyleBackColor = true;
            // 
            // startDateFilter
            // 
            this.startDateFilter.AutoSize = true;
            this.startDateFilter.Location = new System.Drawing.Point(27, 120);
            this.startDateFilter.Name = "startDateFilter";
            this.startDateFilter.Size = new System.Drawing.Size(87, 17);
            this.startDateFilter.TabIndex = 12;
            this.startDateFilter.TabStop = true;
            this.startDateFilter.Text = "Starting Date";
            this.startDateFilter.UseVisualStyleBackColor = true;
            // 
            // locationFilter
            // 
            this.locationFilter.AutoSize = true;
            this.locationFilter.Location = new System.Drawing.Point(27, 78);
            this.locationFilter.Name = "locationFilter";
            this.locationFilter.Size = new System.Drawing.Size(66, 17);
            this.locationFilter.TabIndex = 11;
            this.locationFilter.TabStop = true;
            this.locationFilter.Text = "Location";
            this.locationFilter.UseVisualStyleBackColor = true;
            // 
            // eventNameFilter
            // 
            this.eventNameFilter.AutoSize = true;
            this.eventNameFilter.Location = new System.Drawing.Point(27, 37);
            this.eventNameFilter.Name = "eventNameFilter";
            this.eventNameFilter.Size = new System.Drawing.Size(84, 17);
            this.eventNameFilter.TabIndex = 10;
            this.eventNameFilter.TabStop = true;
            this.eventNameFilter.Text = "Event Name";
            this.eventNameFilter.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 55);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilterEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FilterEvents";
            this.Text = "FilterEvents";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox nameCombo;
        private System.Windows.Forms.ComboBox locationCombo;
        private System.Windows.Forms.RadioButton lowestCost;
        private System.Windows.Forms.RadioButton highestCost;
        private System.Windows.Forms.RadioButton endDateFilter;
        private System.Windows.Forms.RadioButton startDateFilter;
        private System.Windows.Forms.RadioButton locationFilter;
        private System.Windows.Forms.RadioButton eventNameFilter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker endingDate;
        private System.Windows.Forms.DateTimePicker startingDate;
    }
}