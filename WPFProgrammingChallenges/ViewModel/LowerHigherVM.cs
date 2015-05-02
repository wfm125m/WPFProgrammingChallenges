using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFProgrammingChallenges.Helpers;

namespace WPFProgrammingChallenges.ViewModel
{
    class LowerHigherVM : PropertyChangedHandler
    {
        private int number;
        private int counter;
        private int randNumber = 1111;
        public int RandNumber
        {
            get { return randNumber; }
            set
            {
                randNumber = value;
            }
        }

        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                RaisePropertyChangedEvent("Number");
            }
        }

        private System.Windows.Media.Brush color;

        public System.Windows.Media.Brush TextColor
        {
            get { return color; }
            set
            {
                color = value;
                RaisePropertyChangedEvent("TextColor");
            }
        }


        private void Reset()
        {
            Random rand = new Random();
            RandNumber = rand.Next(100);
            counter = 0;
        }

        private void CheckNumber()
        {
            RaisePropertyChangedEvent("Result");
        }


        public string Result
        {
            get
            {
                counter++;
                var converter = new System.Windows.Media.BrushConverter();
                if (number < RandNumber)
                {
                    TextColor = (System.Windows.Media.Brush)converter.ConvertFromString(System.Windows.Media.Colors.Blue.ToString());
                    return string.Format("Sorry your number is {0} than serched :(", ((Results)0).ToString());
                }
                if (number > RandNumber)
                {
                    TextColor = (System.Windows.Media.Brush)converter.ConvertFromString(System.Windows.Media.Colors.Red.ToString());
                    return string.Format("Sorry your number is {0} than serched :(", ((Results)1).ToString());
                }
                else
                {
                    TextColor = (System.Windows.Media.Brush)converter.ConvertFromString(System.Windows.Media.Colors.Green.ToString());
                    return string.Format("{0} number discovered on: {1} guess! ", ((Results)2).ToString(), counter);
                }
            }
            //set { myVar = value; }
        }



        enum Results
        {
            Lower,
            Higher,
            Proper
        }

        #region Commands Declaration
        private ICommand _ResetCommand;

        public ICommand ResetCommand
        {
            get
            {
                if (_ResetCommand == null)
                {
                    _ResetCommand = new RelayCommand(
                        param => Reset(),
                        param => true
                    );
                }
                return _ResetCommand;
            }
        }

        private ICommand _CheckNumberCommand;

        public ICommand CheckNumberCommand
        {
            get
            {
                if (_CheckNumberCommand == null)
                {
                    _CheckNumberCommand = new RelayCommand(
                        param => CheckNumber(),
                        param => true
                    );
                }
                return _CheckNumberCommand;
            }
        }

        #endregion
    }
}
