using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProgrammingChallenges.Model
{
    class AgeModel
    {
        public DateTime BirthDay { get; set; }


        private int years;

        public int Years
        {
            get { return DateTime.Now.Year - BirthDay.Year; }
            //set { years = value; }
        }

        private int months;

        public int Months
        {
            get
            {
                months = DateTime.Now.Month - BirthDay.Month;
                if (months < 0)
                {
                    months = 12 + months;
                }
                return months;
            }
            //get { return months; }
            //set { months = value; }
        }

        private int days;

        public int Days
        {
            get
            {
                days = DateTime.Now.Day - BirthDay.Day;
                if (days < 0)
                {
                    days = 30 + days;
                }
                return days;
            }
            //get { return days; }
            //set { days = value; }
        }

        private int hours;

        public int Hours
        {
            get { hours = DateTime.Now.Hour - BirthDay.Hour;
            if (hours <0)
            {
                hours = 24 + hours;
            }
            return hours;
            }
            //get { return hours; }
            //set { hours = value; }
        }

        private int minutes;

        public int Minutes
        {
            get { minutes = DateTime.Now.Minute - BirthDay.Minute;
            if (minutes < 0)
            {
                minutes = 60 + minutes;
            }
            return minutes;
            }
            //get { return minutes; }
            //set { minutes = value; }
        }

        private int seconds;

        public int Seconds
        {
            get { 
                seconds = DateTime.Now.Second - BirthDay.Second;
                if (seconds< 0)
                {
                    seconds = 60 + seconds;
                }
                return seconds;
            }
            //get { return seconds; }
            //set { seconds = value; }
        }





    }
}
