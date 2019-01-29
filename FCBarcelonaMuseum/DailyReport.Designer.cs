namespace FCBarcelonaMuseum
{
    partial class DailyReport
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridDailyReport = new System.Windows.Forms.DataGridView();
            this.ColnCardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnTotalDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDuration = new System.Windows.Forms.GroupBox();
            this.labelDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDailyReport)).BeginInit();
            this.groupBoxDuration.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(29, 18);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateChanged);
            // 
            // dataGridDailyReport
            // 
            this.dataGridDailyReport.AllowUserToAddRows = false;
            this.dataGridDailyReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDailyReport.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDailyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColnCardNo,
            this.ColnFullName,
            this.ColnTotalDuration});
            this.dataGridDailyReport.Location = new System.Drawing.Point(327, 18);
            this.dataGridDailyReport.Name = "dataGridDailyReport";
            this.dataGridDailyReport.RowTemplate.Height = 24;
            this.dataGridDailyReport.Size = new System.Drawing.Size(444, 478);
            this.dataGridDailyReport.TabIndex = 1;
            // 
            // ColnCardNo
            // 
            this.ColnCardNo.HeaderText = "Card No.";
            this.ColnCardNo.Name = "ColnCardNo";
            // 
            // ColnFullName
            // 
            this.ColnFullName.HeaderText = "Full Name";
            this.ColnFullName.Name = "ColnFullName";
            // 
            // ColnTotalDuration
            // 
            this.ColnTotalDuration.HeaderText = "Total Duration";
            this.ColnTotalDuration.Name = "ColnTotalDuration";
            // 
            // groupBoxDuration
            // 
            this.groupBoxDuration.Controls.Add(this.labelDuration);
            this.groupBoxDuration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDuration.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxDuration.Location = new System.Drawing.Point(29, 258);
            this.groupBoxDuration.Name = "groupBoxDuration";
            this.groupBoxDuration.Size = new System.Drawing.Size(262, 83);
            this.groupBoxDuration.TabIndex = 2;
            this.groupBoxDuration.TabStop = false;
            this.groupBoxDuration.Text = "Total Duration";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(37, 40);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(0, 23);
            this.labelDuration.TabIndex = 0;
            // 
            // DailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.groupBoxDuration);
            this.Controls.Add(this.dataGridDailyReport);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "DailyReport";
            this.Text = "DailyReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDailyReport)).EndInit();
            this.groupBoxDuration.ResumeLayout(false);
            this.groupBoxDuration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridDailyReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnCardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnTotalDuration;
        private System.Windows.Forms.GroupBox groupBoxDuration;
        private System.Windows.Forms.Label labelDuration;
    }
}