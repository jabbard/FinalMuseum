namespace FCBarcelonaMuseum
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.labelMuseumName = new System.Windows.Forms.Label();
            this.groupBoxNewVisitor = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.labelGender = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbOccupation = new System.Windows.Forms.ComboBox();
            this.txtPhNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelPhNo = new System.Windows.Forms.Label();
            this.labelOccupation = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridTable = new System.Windows.Forms.DataGridView();
            this.ColnCardNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnPhNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnOccupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.labelCardNo = new System.Windows.Forms.Label();
            this.grpCheckOut = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtCardNoOut = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxNewVisitor.SuspendLayout();
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpCheckOut.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMuseumName
            // 
            this.labelMuseumName.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuseumName.Location = new System.Drawing.Point(694, 38);
            this.labelMuseumName.Name = "labelMuseumName";
            this.labelMuseumName.Size = new System.Drawing.Size(400, 50);
            this.labelMuseumName.TabIndex = 1;
            this.labelMuseumName.Text = "FC BARCELONA";
            // 
            // groupBoxNewVisitor
            // 
            this.groupBoxNewVisitor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxNewVisitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxNewVisitor.Controls.Add(this.txtEmail);
            this.groupBoxNewVisitor.Controls.Add(this.labelEmail);
            this.groupBoxNewVisitor.Controls.Add(this.btnClearAll);
            this.groupBoxNewVisitor.Controls.Add(this.labelGender);
            this.groupBoxNewVisitor.Controls.Add(this.grpGender);
            this.groupBoxNewVisitor.Controls.Add(this.btnSave);
            this.groupBoxNewVisitor.Controls.Add(this.cmbOccupation);
            this.groupBoxNewVisitor.Controls.Add(this.txtPhNo);
            this.groupBoxNewVisitor.Controls.Add(this.txtName);
            this.groupBoxNewVisitor.Controls.Add(this.labelPhNo);
            this.groupBoxNewVisitor.Controls.Add(this.labelOccupation);
            this.groupBoxNewVisitor.Controls.Add(this.labelName);
            this.groupBoxNewVisitor.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNewVisitor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxNewVisitor.Location = new System.Drawing.Point(19, 91);
            this.groupBoxNewVisitor.Name = "groupBoxNewVisitor";
            this.groupBoxNewVisitor.Size = new System.Drawing.Size(547, 396);
            this.groupBoxNewVisitor.TabIndex = 15;
            this.groupBoxNewVisitor.TabStop = false;
            this.groupBoxNewVisitor.Text = "Visitor\'s data";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(245, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 34);
            this.txtEmail.TabIndex = 31;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(17, 169);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(64, 23);
            this.labelEmail.TabIndex = 30;
            this.labelEmail.Text = "Email:";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(284, 343);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(139, 35);
            this.btnClearAll.TabIndex = 29;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(17, 289);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(82, 23);
            this.labelGender.TabIndex = 28;
            this.labelGender.Text = "Gender:";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.radMale);
            this.grpGender.Controls.Add(this.radFemale);
            this.grpGender.Location = new System.Drawing.Point(245, 265);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(280, 59);
            this.grpGender.TabIndex = 27;
            this.grpGender.TabStop = false;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.Location = new System.Drawing.Point(6, 25);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(64, 26);
            this.radMale.TabIndex = 23;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.Location = new System.Drawing.Point(170, 27);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(80, 26);
            this.radFemale.TabIndex = 24;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(76, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 35);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // cmbOccupation
            // 
            this.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOccupation.FormattingEnabled = true;
            this.cmbOccupation.Items.AddRange(new object[] {
            "Doctor",
            "Pilot",
            "Engineer",
            "Teacher",
            "IT Professional ",
            "Accountant",
            "Athlete",
            "Politician",
            "Actor",
            "Other"});
            this.cmbOccupation.Location = new System.Drawing.Point(245, 219);
            this.cmbOccupation.Name = "cmbOccupation";
            this.cmbOccupation.Size = new System.Drawing.Size(280, 34);
            this.cmbOccupation.TabIndex = 21;
            // 
            // txtPhNo
            // 
            this.txtPhNo.Location = new System.Drawing.Point(245, 106);
            this.txtPhNo.Name = "txtPhNo";
            this.txtPhNo.Size = new System.Drawing.Size(280, 34);
            this.txtPhNo.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(245, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 34);
            this.txtName.TabIndex = 18;
            // 
            // labelPhNo
            // 
            this.labelPhNo.AutoSize = true;
            this.labelPhNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhNo.Location = new System.Drawing.Point(17, 113);
            this.labelPhNo.Name = "labelPhNo";
            this.labelPhNo.Size = new System.Drawing.Size(107, 23);
            this.labelPhNo.TabIndex = 17;
            this.labelPhNo.Text = "Phone No.:";
            // 
            // labelOccupation
            // 
            this.labelOccupation.AutoSize = true;
            this.labelOccupation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOccupation.Location = new System.Drawing.Point(17, 222);
            this.labelOccupation.Name = "labelOccupation";
            this.labelOccupation.Size = new System.Drawing.Size(115, 23);
            this.labelOccupation.TabIndex = 15;
            this.labelOccupation.Text = "Occupation:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(17, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 23);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name:";
            // 
            // dataGridTable
            // 
            this.dataGridTable.AllowUserToAddRows = false;
            this.dataGridTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.dataGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColnCardNum,
            this.ColnFullName,
            this.ColnPhNum,
            this.ColnEmail,
            this.ColnOccupation,
            this.ColnGender,
            this.ColnInTime,
            this.ColnOutTime,
            this.ColnDay});
            this.dataGridTable.Location = new System.Drawing.Point(597, 181);
            this.dataGridTable.Name = "dataGridTable";
            this.dataGridTable.RowTemplate.Height = 24;
            this.dataGridTable.Size = new System.Drawing.Size(934, 507);
            this.dataGridTable.TabIndex = 29;
            // 
            // ColnCardNum
            // 
            this.ColnCardNum.HeaderText = "Card No.";
            this.ColnCardNum.Name = "ColnCardNum";
            // 
            // ColnFullName
            // 
            this.ColnFullName.HeaderText = "Full Name";
            this.ColnFullName.Name = "ColnFullName";
            // 
            // ColnPhNum
            // 
            this.ColnPhNum.HeaderText = "Phone No.";
            this.ColnPhNum.Name = "ColnPhNum";
            // 
            // ColnEmail
            // 
            this.ColnEmail.HeaderText = "Email";
            this.ColnEmail.Name = "ColnEmail";
            // 
            // ColnOccupation
            // 
            this.ColnOccupation.HeaderText = "Occupation";
            this.ColnOccupation.Name = "ColnOccupation";
            // 
            // ColnGender
            // 
            this.ColnGender.HeaderText = "Gender";
            this.ColnGender.Name = "ColnGender";
            // 
            // ColnInTime
            // 
            this.ColnInTime.HeaderText = "InTime";
            this.ColnInTime.Name = "ColnInTime";
            // 
            // ColnOutTime
            // 
            this.ColnOutTime.HeaderText = "Out Time";
            this.ColnOutTime.Name = "ColnOutTime";
            // 
            // ColnDay
            // 
            this.ColnDay.HeaderText = "Day";
            this.ColnDay.Name = "ColnDay";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCheckIn);
            this.groupBox1.Controls.Add(this.txtCardNo);
            this.groupBox1.Controls.Add(this.labelCardNo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(19, 501);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 187);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Old Visitor";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(176, 126);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(139, 35);
            this.btnCheckIn.TabIndex = 30;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.BtnCheckIn_Click);
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(204, 59);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(280, 34);
            this.txtCardNo.TabIndex = 29;
            // 
            // labelCardNo
            // 
            this.labelCardNo.AutoSize = true;
            this.labelCardNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardNo.Location = new System.Drawing.Point(17, 62);
            this.labelCardNo.Name = "labelCardNo";
            this.labelCardNo.Size = new System.Drawing.Size(89, 23);
            this.labelCardNo.TabIndex = 0;
            this.labelCardNo.Text = "Card No.";
            // 
            // grpCheckOut
            // 
            this.grpCheckOut.Controls.Add(this.label1);
            this.grpCheckOut.Controls.Add(this.btnCheckOut);
            this.grpCheckOut.Controls.Add(this.txtCardNoOut);
            this.grpCheckOut.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCheckOut.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpCheckOut.Location = new System.Drawing.Point(782, 91);
            this.grpCheckOut.Name = "grpCheckOut";
            this.grpCheckOut.Size = new System.Drawing.Size(749, 84);
            this.grpCheckOut.TabIndex = 31;
            this.grpCheckOut.TabStop = false;
            this.grpCheckOut.Text = "Checkout";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Card No.";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(591, 36);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(139, 35);
            this.btnCheckOut.TabIndex = 30;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // txtCardNoOut
            // 
            this.txtCardNoOut.Location = new System.Drawing.Point(202, 37);
            this.txtCardNoOut.Name = "txtCardNoOut";
            this.txtCardNoOut.Size = new System.Drawing.Size(336, 34);
            this.txtCardNoOut.TabIndex = 29;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1538, 31);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weeklyReportToolStripMenuItem,
            this.dailyReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(79, 27);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // weeklyReportToolStripMenuItem
            // 
            this.weeklyReportToolStripMenuItem.Name = "weeklyReportToolStripMenuItem";
            this.weeklyReportToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
            this.weeklyReportToolStripMenuItem.Text = "Weekly Report";
            this.weeklyReportToolStripMenuItem.Click += new System.EventHandler(this.WeeklyReportToolStripMenuItem_Click);
            // 
            // dailyReportToolStripMenuItem
            // 
            this.dailyReportToolStripMenuItem.Name = "dailyReportToolStripMenuItem";
            this.dailyReportToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
            this.dailyReportToolStripMenuItem.Text = "Daily Report";
            this.dailyReportToolStripMenuItem.Click += new System.EventHandler(this.DailyReportToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1558, 725);
            this.Controls.Add(this.grpCheckOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridTable);
            this.Controls.Add(this.groupBoxNewVisitor);
            this.Controls.Add(this.labelMuseumName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.Text = "Barca Museum";
            this.groupBoxNewVisitor.ResumeLayout(false);
            this.groupBoxNewVisitor.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCheckOut.ResumeLayout(false);
            this.grpCheckOut.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMuseumName;
        private System.Windows.Forms.GroupBox groupBoxNewVisitor;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPhNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelPhNo;
        private System.Windows.Forms.Label labelOccupation;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label labelCardNo;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnCardNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnPhNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnOccupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnOutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnDay;
        private System.Windows.Forms.ComboBox cmbOccupation;
        private System.Windows.Forms.GroupBox grpCheckOut;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtCardNoOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReportToolStripMenuItem;
    }
}

