using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProgrammingChallenges.Helpers;

namespace WPFProgrammingChallenges.ViewModel
{
    class CollatzConjectureVM : PropertyChangedHandler
    {

        private decimal startNumber;

        public decimal StartNumber
        {
            get { return startNumber; }
            set
            {
                startNumber = value;
                Coll();
            }
        }


        private string resultString;

        public string ResultString
        {
            get { return resultString; }
            set { resultString = value; }
        }



        static string AddNumberString(string toAdd, decimal number)
        {
            toAdd += number.ToString();
            toAdd += ", ";
            return toAdd;
        }

        private void Coll()
        {
            decimal c0;
            string result = string.Empty;


            c0 = startNumber;
            result = AddNumberString(result, c0);
            while (c0 != 1)
            {
                if (c0 % 2 == 0)
                {
                    c0 = c0 / 2;
                }
                else
                {
                    c0 = 3 * c0 + 1;
                }

                result = AddNumberString(result, c0);
            }

            resultString = result;
            RaisePropertyChangedEvent("ResultString");
        }
    }
}
