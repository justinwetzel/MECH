namespace MECHClubApp
{
    partial class AddEvent
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
            this.eventCost = new System.Windows.Forms.TextBox();
            this.eventLocation = new System.Windows.Forms.TextBox();
            this.eventName = new System.Windows.Forms.TextBox();
            this.projectID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.eventDate = new System.Windows.Forms.DateTimePicker();
            this.projIdBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // eventCost
            // 
            this.eventCost.Location = new System.Drawing.Point(205, 200);
            this.eventCost.Name = "eventCost";
            this.eventCost.Size = new System.Drawing.Size(121, 20);
            this.eventCost.TabIndex = 35;
            // 
            // eventLocation
            // 
            this.eventLocation.Location = new System.Drawing.Point(205, 158);
            this.eventLocation.Name = "eventLocation";
            this.eventLocation.Size = new System.Drawing.Size(121, 20);
            this.eventLocation.TabIndex = 34;
            // 
            // eventName
            // 
            this.eventName.Location = new System.Drawing.Point(205, 42);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(121, 20);
            this.eventName.TabIndex = 33;
            // 
            // projectID
            // 
            this.projectID.FormattingEnabled = true;
            this.projectID.Location = new System.Drawing.Point(205, 76);
            this.projectID.Name = "projectID";
            this.projectID.Size = new System.Drawing.Size(121, 21);
            this.projectID.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Date Scheduled";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Project ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Event Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 53);
            this.button2.TabIndex = 26;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 53);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eventDate
            // 
            this.eventDate.Location = new System.Drawing.Point(205, 110);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(121, 20);
            this.eventDate.TabIndex = 37;
            this.eventDate.Value = new System.DateTime(2016, 4, 28, 0, 0, 0, 0);
            // 
            // projIdBox
            // 
            this.projIdBox.Location = new System.Drawing.Point(180, 77);
            this.projIdBox.Name = "projIdBox";
            this.projIdBox.Size = new System.Drawing.Size(121, 20);
            this.projIdBox.TabIndex = 38;
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 406);
            this.Controls.Add(this.projIdBox);
            this.Controls.Add(this.eventDate);
            this.Controls.Add(this.eventCost);
            this.Controls.Add(this.eventLocation);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.projectID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox eventCost;
        private System.Windows.Forms.TextBox eventLocation;
        private System.Windows.Forms.TextBox eventName;
        private System.Windows.Forms.ComboBox projectID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker eventDate;
        private System.Windows.Forms.TextBox projIdBox;
    }
}