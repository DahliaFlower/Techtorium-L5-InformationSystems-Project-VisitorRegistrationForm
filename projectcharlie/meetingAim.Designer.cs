namespace projectcharlie
{
    partial class meetingAimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(meetingAimForm));
            this.meetingRBtn = new System.Windows.Forms.RadioButton();
            this.salesApRBtn = new System.Windows.Forms.RadioButton();
            this.siteVisitRBtn = new System.Windows.Forms.RadioButton();
            this.studentIntRBtn = new System.Windows.Forms.RadioButton();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.mtgAimOkBtn = new System.Windows.Forms.Button();
            this.mgtAimLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // meetingRBtn
            // 
            this.meetingRBtn.AutoSize = true;
            this.meetingRBtn.Checked = true;
            this.meetingRBtn.Location = new System.Drawing.Point(45, 88);
            this.meetingRBtn.Name = "meetingRBtn";
            this.meetingRBtn.Size = new System.Drawing.Size(117, 26);
            this.meetingRBtn.TabIndex = 0;
            this.meetingRBtn.TabStop = true;
            this.meetingRBtn.Text = "Mtg-General";
            this.meetingRBtn.UseCompatibleTextRendering = true;
            this.meetingRBtn.UseVisualStyleBackColor = true;
            // 
            // salesApRBtn
            // 
            this.salesApRBtn.AutoSize = true;
            this.salesApRBtn.Location = new System.Drawing.Point(231, 88);
            this.salesApRBtn.Name = "salesApRBtn";
            this.salesApRBtn.Size = new System.Drawing.Size(105, 23);
            this.salesApRBtn.TabIndex = 1;
            this.salesApRBtn.Text = "Sales Appt";
            this.salesApRBtn.UseVisualStyleBackColor = true;
            this.salesApRBtn.CheckedChanged += new System.EventHandler(this.salesApRBtn_CheckedChanged);
            // 
            // siteVisitRBtn
            // 
            this.siteVisitRBtn.AutoSize = true;
            this.siteVisitRBtn.Location = new System.Drawing.Point(45, 164);
            this.siteVisitRBtn.Name = "siteVisitRBtn";
            this.siteVisitRBtn.Size = new System.Drawing.Size(90, 23);
            this.siteVisitRBtn.TabIndex = 2;
            this.siteVisitRBtn.Text = "Site Visit";
            this.siteVisitRBtn.UseVisualStyleBackColor = true;
            this.siteVisitRBtn.CheckedChanged += new System.EventHandler(this.siteVisitRBtn_CheckedChanged);
            // 
            // studentIntRBtn
            // 
            this.studentIntRBtn.AutoSize = true;
            this.studentIntRBtn.Location = new System.Drawing.Point(231, 164);
            this.studentIntRBtn.Name = "studentIntRBtn";
            this.studentIntRBtn.Size = new System.Drawing.Size(154, 23);
            this.studentIntRBtn.TabIndex = 3;
            this.studentIntRBtn.Text = "Student Interview";
            this.studentIntRBtn.UseVisualStyleBackColor = true;
            this.studentIntRBtn.CheckedChanged += new System.EventHandler(this.studentIntRBtn_CheckedChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(79)))));
            this.cancelBtn.FlatAppearance.BorderSize = 2;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(15)))));
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(15)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(39, 227);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(121, 51);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // mtgAimOkBtn
            // 
            this.mtgAimOkBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(79)))));
            this.mtgAimOkBtn.FlatAppearance.BorderSize = 4;
            this.mtgAimOkBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(15)))));
            this.mtgAimOkBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(15)))));
            this.mtgAimOkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mtgAimOkBtn.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtgAimOkBtn.Location = new System.Drawing.Point(241, 227);
            this.mtgAimOkBtn.Name = "mtgAimOkBtn";
            this.mtgAimOkBtn.Size = new System.Drawing.Size(133, 51);
            this.mtgAimOkBtn.TabIndex = 5;
            this.mtgAimOkBtn.Text = "Ok";
            this.mtgAimOkBtn.UseVisualStyleBackColor = true;
            this.mtgAimOkBtn.Click += new System.EventHandler(this.mtgAimOkBtn_Click);
            // 
            // mgtAimLabel
            // 
            this.mgtAimLabel.AutoSize = true;
            this.mgtAimLabel.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mgtAimLabel.Location = new System.Drawing.Point(39, 23);
            this.mgtAimLabel.Name = "mgtAimLabel";
            this.mgtAimLabel.Size = new System.Drawing.Size(170, 33);
            this.mgtAimLabel.TabIndex = 6;
            this.mgtAimLabel.Text = "Meeting Aim";
            // 
            // meetingAimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.mgtAimLabel);
            this.Controls.Add(this.mtgAimOkBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.studentIntRBtn);
            this.Controls.Add(this.siteVisitRBtn);
            this.Controls.Add(this.salesApRBtn);
            this.Controls.Add(this.meetingRBtn);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(79)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "meetingAimForm";
            this.Text = "Aim of Meeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mgtAimLabel;
        public System.Windows.Forms.Button cancelBtn;
        public System.Windows.Forms.Button mtgAimOkBtn;
        public System.Windows.Forms.RadioButton meetingRBtn;
        public System.Windows.Forms.RadioButton salesApRBtn;
        public System.Windows.Forms.RadioButton siteVisitRBtn;
        public System.Windows.Forms.RadioButton studentIntRBtn;
    }
}