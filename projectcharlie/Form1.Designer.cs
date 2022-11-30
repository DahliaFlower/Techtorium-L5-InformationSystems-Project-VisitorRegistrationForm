namespace projectcharlie
{
    partial class visitorRegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visitorRegForm));
            this.Box_VisitorDetails = new System.Windows.Forms.GroupBox();
            this.TB_emailAddress = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.TB_mobileNumber = new System.Windows.Forms.TextBox();
            this.mobileNumberLabel = new System.Windows.Forms.Label();
            this.TB_surname = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.TB_nameLabel = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.MeetingDetailsGB = new System.Windows.Forms.GroupBox();
            this.minutes = new System.Windows.Forms.NumericUpDown();
            this.hour = new System.Windows.Forms.NumericUpDown();
            this.timeLabel = new System.Windows.Forms.Label();
            this.meetingAim_Btn = new System.Windows.Forms.Button();
            this.meetingAimLabel = new System.Windows.Forms.Label();
            this.staffMemberCBX = new System.Windows.Forms.ComboBox();
            this.meetingWithLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.meetingDetailsLabel = new System.Windows.Forms.Label();
            this.onsiteVisitors_GB = new System.Windows.Forms.GroupBox();
            this.visitorsOnsiteListLB = new System.Windows.Forms.ListView();
            this.signIn_Btn = new System.Windows.Forms.Button();
            this.Box_VisitorDetails.SuspendLayout();
            this.MeetingDetailsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).BeginInit();
            this.onsiteVisitors_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box_VisitorDetails
            // 
            this.Box_VisitorDetails.Controls.Add(this.TB_emailAddress);
            this.Box_VisitorDetails.Controls.Add(this.emailLabel);
            this.Box_VisitorDetails.Controls.Add(this.TB_mobileNumber);
            this.Box_VisitorDetails.Controls.Add(this.mobileNumberLabel);
            this.Box_VisitorDetails.Controls.Add(this.TB_surname);
            this.Box_VisitorDetails.Controls.Add(this.surnameLabel);
            this.Box_VisitorDetails.Controls.Add(this.TB_nameLabel);
            this.Box_VisitorDetails.Controls.Add(this.nameLabel);
            this.Box_VisitorDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Box_VisitorDetails.Location = new System.Drawing.Point(22, 24);
            this.Box_VisitorDetails.Name = "Box_VisitorDetails";
            this.Box_VisitorDetails.Size = new System.Drawing.Size(334, 358);
            this.Box_VisitorDetails.TabIndex = 0;
            this.Box_VisitorDetails.TabStop = false;
            this.Box_VisitorDetails.Text = "Visitor Details";
            this.Box_VisitorDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TB_emailAddress
            // 
            this.TB_emailAddress.Location = new System.Drawing.Point(18, 300);
            this.TB_emailAddress.Name = "TB_emailAddress";
            this.TB_emailAddress.Size = new System.Drawing.Size(289, 27);
            this.TB_emailAddress.TabIndex = 7;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(18, 268);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(113, 19);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email Address";
            // 
            // TB_mobileNumber
            // 
            this.TB_mobileNumber.Location = new System.Drawing.Point(18, 211);
            this.TB_mobileNumber.Name = "TB_mobileNumber";
            this.TB_mobileNumber.Size = new System.Drawing.Size(289, 27);
            this.TB_mobileNumber.TabIndex = 5;
            // 
            // mobileNumberLabel
            // 
            this.mobileNumberLabel.AutoSize = true;
            this.mobileNumberLabel.Location = new System.Drawing.Point(21, 180);
            this.mobileNumberLabel.Name = "mobileNumberLabel";
            this.mobileNumberLabel.Size = new System.Drawing.Size(120, 19);
            this.mobileNumberLabel.TabIndex = 4;
            this.mobileNumberLabel.Text = "Mobile Number";
            // 
            // TB_surname
            // 
            this.TB_surname.Location = new System.Drawing.Point(18, 129);
            this.TB_surname.Name = "TB_surname";
            this.TB_surname.Size = new System.Drawing.Size(289, 27);
            this.TB_surname.TabIndex = 3;
            this.TB_surname.TextChanged += new System.EventHandler(this.TB_surname_TextChanged);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(17, 107);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(75, 19);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Surname";
            // 
            // TB_nameLabel
            // 
            this.TB_nameLabel.Location = new System.Drawing.Point(18, 49);
            this.TB_nameLabel.Name = "TB_nameLabel";
            this.TB_nameLabel.Size = new System.Drawing.Size(289, 27);
            this.TB_nameLabel.TabIndex = 1;
            this.TB_nameLabel.TextChanged += new System.EventHandler(this.TB_nameLabel_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(17, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(88, 19);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "First Name";
            // 
            // MeetingDetailsGB
            // 
            this.MeetingDetailsGB.Controls.Add(this.minutes);
            this.MeetingDetailsGB.Controls.Add(this.hour);
            this.MeetingDetailsGB.Controls.Add(this.timeLabel);
            this.MeetingDetailsGB.Controls.Add(this.meetingAim_Btn);
            this.MeetingDetailsGB.Controls.Add(this.meetingAimLabel);
            this.MeetingDetailsGB.Controls.Add(this.staffMemberCBX);
            this.MeetingDetailsGB.Controls.Add(this.meetingWithLabel);
            this.MeetingDetailsGB.Controls.Add(this.dateTimePicker1);
            this.MeetingDetailsGB.Controls.Add(this.meetingDetailsLabel);
            this.MeetingDetailsGB.Location = new System.Drawing.Point(380, 24);
            this.MeetingDetailsGB.Name = "MeetingDetailsGB";
            this.MeetingDetailsGB.Size = new System.Drawing.Size(301, 358);
            this.MeetingDetailsGB.TabIndex = 1;
            this.MeetingDetailsGB.TabStop = false;
            this.MeetingDetailsGB.Text = "Meeting Details";
            // 
            // minutes
            // 
            this.minutes.AllowDrop = true;
            this.minutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(79)))));
            this.minutes.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.minutes.Location = new System.Drawing.Point(155, 130);
            this.minutes.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(135, 27);
            this.minutes.TabIndex = 12;
            this.minutes.ValueChanged += new System.EventHandler(this.minutes_ValueChanged);
            // 
            // hour
            // 
            this.hour.AllowDrop = true;
            this.hour.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(79)))));
            this.hour.Location = new System.Drawing.Point(24, 130);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(125, 27);
            this.hour.TabIndex = 10;
            this.hour.ValueChanged += new System.EventHandler(this.hour_ValueChanged);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(19, 107);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(109, 19);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "Meeting Time";
            // 
            // meetingAim_Btn
            // 
            this.meetingAim_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(79)))));
            this.meetingAim_Btn.FlatAppearance.BorderSize = 4;
            this.meetingAim_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(15)))));
            this.meetingAim_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(15)))));
            this.meetingAim_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.meetingAim_Btn.Location = new System.Drawing.Point(23, 300);
            this.meetingAim_Btn.Name = "meetingAim_Btn";
            this.meetingAim_Btn.Size = new System.Drawing.Size(267, 45);
            this.meetingAim_Btn.TabIndex = 5;
            this.meetingAim_Btn.Text = "Meeting Aim";
            this.meetingAim_Btn.UseVisualStyleBackColor = false;
            this.meetingAim_Btn.Click += new System.EventHandler(this.meetingAim_Btn_Click);
            // 
            // meetingAimLabel
            // 
            this.meetingAimLabel.AutoSize = true;
            this.meetingAimLabel.Location = new System.Drawing.Point(29, 268);
            this.meetingAimLabel.Name = "meetingAimLabel";
            this.meetingAimLabel.Size = new System.Drawing.Size(246, 19);
            this.meetingAimLabel.TabIndex = 4;
            this.meetingAimLabel.Text = "What is the aim of your meeting?";
            // 
            // staffMemberCBX
            // 
            this.staffMemberCBX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(79)))));
            this.staffMemberCBX.FormattingEnabled = true;
            this.staffMemberCBX.Items.AddRange(new object[] {
            "Annette Bigby",
            "Rosie Bigby",
            "Dahlia Flower",
            "Rhubarb Plant",
            "Swan Plant",
            "Tomato Tree"});
            this.staffMemberCBX.Location = new System.Drawing.Point(23, 216);
            this.staffMemberCBX.Name = "staffMemberCBX";
            this.staffMemberCBX.Size = new System.Drawing.Size(267, 27);
            this.staffMemberCBX.TabIndex = 3;
            // 
            // meetingWithLabel
            // 
            this.meetingWithLabel.AutoSize = true;
            this.meetingWithLabel.Location = new System.Drawing.Point(19, 187);
            this.meetingWithLabel.Name = "meetingWithLabel";
            this.meetingWithLabel.Size = new System.Drawing.Size(204, 19);
            this.meetingWithLabel.TabIndex = 2;
            this.meetingWithLabel.Text = "Who are you meeting with?";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(79)))));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(15)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(79)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(79)))));
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(15)))));
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 27);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // meetingDetailsLabel
            // 
            this.meetingDetailsLabel.AutoSize = true;
            this.meetingDetailsLabel.Location = new System.Drawing.Point(19, 32);
            this.meetingDetailsLabel.Name = "meetingDetailsLabel";
            this.meetingDetailsLabel.Size = new System.Drawing.Size(105, 19);
            this.meetingDetailsLabel.TabIndex = 0;
            this.meetingDetailsLabel.Text = "Meeting Date";
            // 
            // onsiteVisitors_GB
            // 
            this.onsiteVisitors_GB.Controls.Add(this.visitorsOnsiteListLB);
            this.onsiteVisitors_GB.Location = new System.Drawing.Point(704, 24);
            this.onsiteVisitors_GB.Name = "onsiteVisitors_GB";
            this.onsiteVisitors_GB.Size = new System.Drawing.Size(312, 477);
            this.onsiteVisitors_GB.TabIndex = 2;
            this.onsiteVisitors_GB.TabStop = false;
            this.onsiteVisitors_GB.Text = "Onsite Visitors";
            // 
            // visitorsOnsiteListLB
            // 
            this.visitorsOnsiteListLB.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.visitorsOnsiteListLB.AllowColumnReorder = true;
            this.visitorsOnsiteListLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(15)))));
            this.visitorsOnsiteListLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visitorsOnsiteListLB.CausesValidation = false;
            this.visitorsOnsiteListLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(79)))));
            this.visitorsOnsiteListLB.FullRowSelect = true;
            this.visitorsOnsiteListLB.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.visitorsOnsiteListLB.HideSelection = false;
            this.visitorsOnsiteListLB.HoverSelection = true;
            this.visitorsOnsiteListLB.Location = new System.Drawing.Point(7, 27);
            this.visitorsOnsiteListLB.Name = "visitorsOnsiteListLB";
            this.visitorsOnsiteListLB.ShowItemToolTips = true;
            this.visitorsOnsiteListLB.Size = new System.Drawing.Size(299, 444);
            this.visitorsOnsiteListLB.TabIndex = 0;
            this.visitorsOnsiteListLB.TileSize = new System.Drawing.Size(288, 21);
            this.visitorsOnsiteListLB.UseCompatibleStateImageBehavior = false;
            this.visitorsOnsiteListLB.View = System.Windows.Forms.View.Tile;
            this.visitorsOnsiteListLB.SelectedIndexChanged += new System.EventHandler(this.visitorsOnsiteListLB_SelectedIndexChanged);
            this.visitorsOnsiteListLB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.visitorsOnsiteListLB_KeyDown);
            // 
            // signIn_Btn
            // 
            this.signIn_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(79)))));
            this.signIn_Btn.FlatAppearance.BorderSize = 4;
            this.signIn_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(15)))));
            this.signIn_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(15)))));
            this.signIn_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signIn_Btn.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn_Btn.Location = new System.Drawing.Point(22, 419);
            this.signIn_Btn.Name = "signIn_Btn";
            this.signIn_Btn.Size = new System.Drawing.Size(659, 82);
            this.signIn_Btn.TabIndex = 3;
            this.signIn_Btn.Text = "Sign In";
            this.signIn_Btn.UseVisualStyleBackColor = true;
            this.signIn_Btn.Click += new System.EventHandler(this.signIn_Btn_Click);
            // 
            // visitorRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1022, 510);
            this.Controls.Add(this.signIn_Btn);
            this.Controls.Add(this.onsiteVisitors_GB);
            this.Controls.Add(this.MeetingDetailsGB);
            this.Controls.Add(this.Box_VisitorDetails);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(79)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "visitorRegForm";
            this.Text = "Visitor Registration";
            this.Box_VisitorDetails.ResumeLayout(false);
            this.Box_VisitorDetails.PerformLayout();
            this.MeetingDetailsGB.ResumeLayout(false);
            this.MeetingDetailsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).EndInit();
            this.onsiteVisitors_GB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Box_VisitorDetails;
        private System.Windows.Forms.TextBox TB_surname;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox TB_nameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox TB_emailAddress;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox TB_mobileNumber;
        private System.Windows.Forms.Label mobileNumberLabel;
        private System.Windows.Forms.GroupBox MeetingDetailsGB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label meetingDetailsLabel;
        private System.Windows.Forms.ComboBox staffMemberCBX;
        private System.Windows.Forms.Label meetingWithLabel;
        private System.Windows.Forms.Label meetingAimLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.GroupBox onsiteVisitors_GB;
        private System.Windows.Forms.Button signIn_Btn;
        private System.Windows.Forms.NumericUpDown minutes;
        private System.Windows.Forms.NumericUpDown hour;
        public System.Windows.Forms.Button meetingAim_Btn;
        public System.Windows.Forms.ListView visitorsOnsiteListLB;
    }
}

