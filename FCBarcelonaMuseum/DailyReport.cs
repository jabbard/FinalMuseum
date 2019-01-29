using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCBarcelonaMuseum
{
    public partial class DailyReport : Form
    {
        public List<DailyReportData> Report = new List<DailyReportData>();
        public DailyReport()
        {
            InitializeComponent();

        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Report.Clear();
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;

            
            using (StreamReader reader = new StreamReader(@"Data.csv"))
            {
                String line = "";
                if (!File.Exists(@"Data.csv"))
                {
                    MessageBox.Show("The file is missing.", "Error!");
                }
                while (!reader.EndOfStream)
                {

                    line = reader.ReadLine();
                    String[] rowData = line.Split(',');
                    DateTime inTime = DateTime.Parse(rowData[6]);
                    DateTime outTime = DateTime.Parse(rowData[7]);
                    if (!outTime.Equals(default(DateTime))){
                        if (inTime>selectedDate && inTime<selectedDate.AddDays(1))
                        {
                            int cNo = int.Parse(rowData[0]);
                            String name = rowData[1];
                            int duration = Duration(inTime, outTime);

                            DailyReportData data = new DailyReportData(cNo, name, duration);
                            Report.Add(data);
                        }
                    }
                }
            }
            LoadToGrid();
            TotalDuration();
        }

        public void TotalDuration()
        {
            int total = 0;
            foreach (DailyReportData d in Report)
            {
                total = total + d.Duration;
            }
            labelDuration.Text = total.ToString()+" mins";
        }

        public void LoadToGrid()
        {
            if (Report.Count != 0)
            {

                dataGridDailyReport.Rows.Clear();
                foreach (DailyReportData a in Report)
                {

                    int rowNum = dataGridDailyReport.Rows.Add();
                    DataGridViewRow row = dataGridDailyReport.Rows[rowNum];

                    row.Cells["ColnCardNo"].Value = a.CardNo;
                    row.Cells["ColnFullName"].Value = a.Name;
                    row.Cells["ColnTotalDuration"].Value = a.Duration;
                }
            }
            else
            {
                MessageBox.Show("There is no data for the given date!", "Alert!");
            }
        }

        public int Duration(DateTime inTime, DateTime outTime)
        {
           return (int)Math.Round(outTime.Subtract(inTime).TotalMinutes);
        }
    }
}
