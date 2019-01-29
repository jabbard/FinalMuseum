using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCBarcelonaMuseum
{
    public partial class WeeklyReport : Form
    {
        public List<WeeklyReportData> ListReport = new List<WeeklyReportData>();

        public WeeklyReport()
        {
            InitializeComponent();
            chartWeekly.Titles.Add("Weekly Report");
            chartWeekly.Series["Days"].IsValueShownAsLabel = true;
        }   
 
        private void LoadToGrid()
        {
            if (ListReport.Count != 0)
            {

                dataGridViewWeeks.Rows.Clear();
                chartWeekly.Series["Days"].Points.Clear();
                foreach (WeeklyReportData a in ListReport)
                {

                    int rowNum = dataGridViewWeeks.Rows.Add();
                    DataGridViewRow row = dataGridViewWeeks.Rows[rowNum];

                    row.Cells["ColnDay"].Value = a.Day;
                    row.Cells["ColnTotal"].Value = a.Total;
                    if (a.Total > 0)
                    {
                        chartWeekly.Series["Days"].Points.AddXY(a.Day, a.TotalDuration);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("First pick a date.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void AscendingSort()
        {
            for (int i = 0; i < ListReport.Count; i++)
            {
                for(int j = i+1; j<ListReport.Count; j++)
                {
                    if (ListReport[i].Total > ListReport[j].Total)
                    {
                        int tempTotal = ListReport[i].Total;
                        String tempDay = ListReport[i].Day;
                        int tempDuration = ListReport[i].TotalDuration;
                        ListReport[i].Total = ListReport[j].Total;
                        ListReport[i].Day = ListReport[j].Day;
                        ListReport[i].TotalDuration = ListReport[j].TotalDuration;
                        ListReport[j].Total = tempTotal;
                        ListReport[j].Day = tempDay;
                        ListReport[j].TotalDuration = tempDuration;
                    }
                }
            }
        }

        private void DescendingSort()
        {
            for (int i = 0; i < ListReport.Count; i++)
            {
                for (int j = i+1; j < ListReport.Count; j++)
                {
                    if (ListReport[i].Total < ListReport[j].Total)
                    {
                        int tempTotal = ListReport[i].Total;
                        String tempDay = ListReport[i].Day;
                        int tempDuration = ListReport[i].TotalDuration;
                        ListReport[i].Total = ListReport[j].Total;
                        ListReport[i].Day = ListReport[j].Day;
                        ListReport[i].TotalDuration = ListReport[j].TotalDuration;
                        ListReport[j].Total = tempTotal;
                        ListReport[j].Day = tempDay;
                        ListReport[j].TotalDuration = tempDuration;
                    }
                }
            }
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dataGridViewWeeks.Rows.Clear();
            ListReport.Clear();

            DateTime today = monthCalendar1.SelectionStart;
            monthCalendar1.SelectionStart = today.AddDays(1 - (int)today.DayOfWeek);
            monthCalendar1.SelectionEnd = today.AddDays(6 - (int)today.DayOfWeek);

            using (StreamReader reader = new StreamReader(@"Data.csv"))
            {
                String line = "";
                if (!File.Exists(@"Data.csv"))
                {
                    MessageBox.Show("The file is missing.", "Error!");
                }
                int[] count = { 0, 0, 0, 0, 0 };
                int[] totalDuration = { 0, 0, 0, 0, 0 };
                
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    String[] rowData = line.Split(',');

                    DateTime inTime = DateTime.Parse(rowData[6]);
                    if (inTime >= monthCalendar1.SelectionStart && inTime <= monthCalendar1.SelectionEnd)
                    {
                        DateTime a = DateTime.Parse(rowData[6]);
                        int d = (int)a.DayOfWeek;
                        switch (d)
                        {
                            case 1:
                                count[0] = count[0] + 1;
                                totalDuration[0] = totalDuration[0] + Duration(inTime, DateTime.Parse(rowData[7]));
                                break;

                            case 2:
                                count[1] = count[1] + 1;
                                totalDuration[1] = totalDuration[1] + Duration(inTime, DateTime.Parse(rowData[7]));
                                break;

                            case 3:
                                count[2] = count[2] + 1;
                                totalDuration[2] = totalDuration[2] + Duration(inTime, DateTime.Parse(rowData[7]));
                                break;

                            case 4:
                                count[3] = count[3] + 1;
                                totalDuration[3] = totalDuration[3] + Duration(inTime, DateTime.Parse(rowData[7]));
                                break;

                            case 5:
                                count[4] = count[4] + 1;
                                totalDuration[4] = totalDuration[4] + Duration(inTime, DateTime.Parse(rowData[7]));
                                break;
                        }

                    }

                }

                for (int i = 0; i < count.Length; i++)
                {

                    String day = "";
                    switch (i + 1)
                    {
                        case 1:
                            day = "Monday";
                            break;
                        case 2:
                            day = "Tuesday";
                            break;
                        case 3:
                            day = "Wednesday";
                            break;
                        case 4:
                            day = "Thursday";
                            break;
                        case 5:
                            day = "Friday";
                            break;
                    }
                    int total = count[i];
                    int totalTime = totalDuration[i];
                    WeeklyReportData weeklyReportData = new WeeklyReportData(day, total, totalTime);
                    

                    ListReport.Add(weeklyReportData);

                }


            }
            LoadToGrid();
            
        }

        private int Duration(DateTime inTime, DateTime outTime)
        {
            return (int)Math.Round(outTime.Subtract(inTime).TotalMinutes);
        }

        private void CmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSort.SelectedItem != null)
            {
                if (cmbSort.Text.Equals("Ascending"))
                {
                    AscendingSort();
                    LoadToGrid();
                    MessageBox.Show("Ascending Order", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    DescendingSort();
                    LoadToGrid();
                    MessageBox.Show("Descending Order", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
    }
}
