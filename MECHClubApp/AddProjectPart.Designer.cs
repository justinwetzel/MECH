namespace MECHClubApp
{
    partial class AddProjectPart
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
            this.partId = new System.Windows.Forms.ComboBox();
            this.projectId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityNeeded = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // partId
            // 
            this.partId.FormattingEnabled = true;
            this.partId.Location = new System.Drawing.Point(210, 96);
            this.partId.Name = "partId";
            this.partId.Size = new System.Drawing.Size(121, 21);
            this.partId.TabIndex = 19;
            // 
            // projectId
            // 
            this.projectId.FormattingEnabled = true;
            this.projectId.Location = new System.Drawing.Point(210, 56);
            this.projectId.Name = "projectId";
            this.projectId.Size = new System.Drawing.Size(121, 21);
            this.projectId.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Part Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Project Id";
            // 
            // quantityNeeded
            // 
            this.quantityNeeded.FormattingEnabled = true;
            this.quantityNeeded.Location = new System.Drawing.Point(210, 140);
            this.quantityNeeded.Name = "quantityNeeded";
            this.quantityNeeded.Size = new System.Drawing.Size(121, 21);
            this.quantityNeeded.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Quantity Needed";
            // 
            // AddProjectPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 406);
            this.Controls.Add(this.quantityNeeded);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partId);
            this.Controls.Add(this.projectId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AddProjectPart";
            this.Text = "AddProjectPart";
            this.Load += new System.EventHandler(this.AddProjectPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox partId;
        private System.Windows.Forms.ComboBox projectId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox quantityNeeded;
        private System.Windows.Forms.Label label1;
    }
}