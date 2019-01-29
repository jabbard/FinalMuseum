using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCBarcelonaMuseum
{
    public class WeeklyReportData
    {
        public String Day { get; set; }
        public int Total { get; set; }
        public int TotalDuration { get; set; }
        public WeeklyReportData() { }

        public WeeklyReportData(String day, int total, int totalDuration)
        {
            this.Day = day;
            this.Total = total;
            this.TotalDuration = totalDuration;
        }
    }
}
