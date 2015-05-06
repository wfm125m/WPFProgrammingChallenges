using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFProgrammingChallenges.Helpers;

namespace WPFProgrammingChallenges.ViewModel
{
    class FizzBuzzVM : PropertyChangedHandler
    {
        private int from = 1;

        public int From
        {
            get { return from; }
            set { from = value; }
        }

        private int to = 100;

        public int To
        {
            get { return to; }
            set { to = value; }
        }


        private string fizzBuzzText;

        public string FizzBuzzText
        {
            get { return fizzBuzzText; }
            set { fizzBuzzText = value; }
        }
        

        private void FizzBuzz()
        {
            string partialFizzBuzz;
            fizzBuzzText = "";
            StringBuilder sb = new StringBuilder("");
            for (int i = from; i < to; i++)
            {
                partialFizzBuzz = "";
                if (i % 3 == 0)
                {
                    partialFizzBuzz = "Fizz";
                }
                if (i % 5 == 0)
                {
                    partialFizzBuzz += "Buzz";
                }
                if (partialFizzBuzz == "") partialFizzBuzz = i.ToString();

                fizzBuzzText += partialFizzBuzz + ", ";
            }
            RaisePropertyChangedEvent("FizzBuzzText");
        }

        #region Commands Declaration
        private ICommand _StartFizzBuzzCommand;

        public ICommand StartFizzBuzzCommand
        {
            get
            {
                if (_StartFizzBuzzCommand == null)
                {
                    _StartFizzBuzzCommand = new RelayCommand(
                        param => FizzBuzz(),
                        param => true
                    );
                }
                return _StartFizzBuzzCommand;
            }
        }
        #endregion
    }
}
