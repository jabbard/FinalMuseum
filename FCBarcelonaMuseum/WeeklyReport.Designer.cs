namespace FCBarcelonaMuseum
{
    partial class WeeklyReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridViewWeeks = new System.Windows.Forms.DataGridView();
            this.ColnDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.chartWeekly = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeekly)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(39, 50);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateSelected);
            // 
            // dataGridViewWeeks
            // 
            this.dataGridViewWeeks.AllowUserToAddRows = false;
            this.dataGridViewWeeks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWeeks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.dataGridViewWeeks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeeks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColnDay,
            this.ColnTotal});
            this.dataGridViewWeeks.Location = new System.Drawing.Point(348, 50);
            this.dataGridViewWeeks.Name = "dataGridViewWeeks";
            this.dataGridViewWeeks.RowTemplate.Height = 24;
            this.dataGridViewWeeks.Size = new System.Drawing.Size(411, 207);
            this.dataGridViewWeeks.TabIndex = 2;
            // 
            // ColnDay
            // 
            this.ColnDay.HeaderText = "Day";
            this.ColnDay.Name = "ColnDay";
            // 
            // ColnTotal
            // 
            this.ColnTotal.HeaderText = "Total Days";
            this.ColnTotal.Name = "ColnTotal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sort by:";
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cmbSort.Location = new System.Drawing.Point(594, 18);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(165, 24);
            this.cmbSort.TabIndex = 4;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.CmbSort_SelectedIndexChanged);
            // 
            // chartWeekly
            // 
            chartArea1.Name = "ChartArea1";
            this.chartWeekly.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartWeekly.Legends.Add(legend1);
            this.chartWeekly.Location = new System.Drawing.Point(39, 281);
            this.chartWeekly.Name = "chartWeekly";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Days";
            this.chartWeekly.Series.Add(series1);
            this.chartWeekly.Size = new System.Drawing.Size(720, 322);
            this.chartWeekly.TabIndex = 5;
            // 
            // WeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.chartWeekly);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewWeeks);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "WeeklyReport";
            this.Text = "WeeklyReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeekly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridViewWeeks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeekly;
    }
}