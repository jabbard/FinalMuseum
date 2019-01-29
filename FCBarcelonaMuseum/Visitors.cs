using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCBarcelonaMuseum
{
    public class Visitors
    {
        public int CardNo { get; set; }
        public String Name { get; set; }
        public String PhNo { get; set; }
        public String Email { get; set; }
        public String Occupation { get; set; }
        public String Gender { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public DayOfWeek Day { get; set; }

        public Visitors(int cardNo, String name, String phNo, String email, String occupation, String gender, DateTime inTime, DateTime outTime, DayOfWeek day)
        {
            this.CardNo = cardNo;
            this.Name = name;
            this.PhNo = phNo;
            this.Email = email;
            this.Occupation = occupation;
            this.Gender = gender;
            this.InTime = inTime;
            this.OutTime = outTime;
            this.Day = day;
        }

    }     
}

