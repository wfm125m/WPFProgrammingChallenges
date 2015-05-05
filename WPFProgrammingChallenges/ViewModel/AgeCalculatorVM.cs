using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFProgrammingChallenges.Helpers;

namespace WPFProgrammingChallenges.ViewModel
{
    class AgeCalculatorVM : PropertyChangedHandler
    {
        Model.AgeModel age = new Model.AgeModel();

        private DateTime birthDate = DateTime.Now;

        private DateTime currentTime { get { return DateTime.Now; } }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; age.BirthDay = birthDate; }
        }


        private string fullAge;

        public string FullAge
        {
            get { return string.Format("You live {0} Years, {1} months, {2} days, {3} hours, {4} minutes, {5} seconds."
                , age.Years, age.Months, age.Days, age.Hours, age.Minutes, age.Seconds);
            }
           
        }

        private string ageDays;

        public string AgeDays
        {
            get { return  string.Format("You live {0} days", age.Days); }
            
        }

        private string ageHours;

        public string AgeHours
        {
            get { return string.Format("You live {0} hours", age.Hours); }
        }

        private string ageMinutes;

        public string AgeMinutes
        {
            get { return string.Format("You live {0} minutes", age.Minutes); }
            set { ageMinutes = value; }
        }

        private string ageSeconds;

        public string AgeSeconds
        {
            get { return string.Format("You live {0} days", age.Seconds); }
            set { ageSeconds = value; }
        }

        private Visibility visible = Visibility.Hidden;
        public Visibility ControlsVisible
        {
            get { return visible; }
            set { visible = value; }
        }



        private void StartAgeCounter()
        {
            visible = Visibility.Visible;
            RaisePropertyChangedEvent("ControlsVisible");
            RaisePropertyChangedEvent("FullAge");
        }


        #region Commands Declaration
        private ICommand _CalculateAgeCommand;

        public ICommand CalculateAgeCommand
        {
            get
            {
                if (_CalculateAgeCommand == null)
                {
                    _CalculateAgeCommand = new RelayCommand(
                        param => StartAgeCounter(),
                        param => true
                    );
                }
                return _CalculateAgeCommand;
            }
        }


        #endregion
    }
}
