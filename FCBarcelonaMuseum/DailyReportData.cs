using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCBarcelonaMuseum
{
    public class DailyReportData
    {
        public int CardNo { get; set; }
        public String Name { get; set; }
        public int Duration { get; set; }

        public DailyReportData(int cardNo, String name, int duration)
        {
            this.CardNo = cardNo;
            this.Name = name;
            this.Duration = duration;
        }
    }
}
