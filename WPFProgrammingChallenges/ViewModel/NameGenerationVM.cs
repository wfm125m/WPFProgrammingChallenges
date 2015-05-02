using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFProgrammingChallenges.Helpers;

namespace WPFProgrammingChallenges.ViewModel
{
    class NameGenerationVM : PropertyChangedHandler
    {
        private string name;

        public string GeneratedName
        {
            get { return name; }
            set { name = value; }
        }

        private int nameLength = 10;

        public int NameLength
        {
            get { return nameLength; }
            set
            {
                nameLength = value;
                RaisePropertyChangedEvent("NameLength");
            }
        }

        private bool useSpecial;

        public bool UseSpecial
        {
            get { return useSpecial; }
            set
            {
                useSpecial = value;
                RaisePropertyChangedEvent("UseSpecial");
            }
        }


        public static char GetRandomCharacter(char[] text, Random rng)
        {
            int index = rng.Next(text.Length);
            return text[index];
        }

        public void GenerateName()
        {
            //Reset generated name
            name = string.Empty;
            //start new Rand generator
            Random rand = new Random();
            //declare and initialaze base chhar set
            char[] alpha;
            if (!useSpecial)
                alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            else
                alpha = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?ABCDEFGHIJKLMNOPQRSTUVWXYZ^&".ToCharArray();
            //
            for (int i = 0; i < nameLength; i++)
            {
                char randChar = GetRandomCharacter(alpha, rand);
                name += randChar;
            }
        }

        public void ShowGeneratedName()
        {

            GenerateName();
            System.Windows.MessageBox.Show(string.Format("Generated name: {0}", GeneratedName));
        }

        #region Commands Declaration
        private ICommand _GenerateNameCommand;

        public ICommand GenerateNameCommand
        {
            get
            {
                if (_GenerateNameCommand == null)
                {
                    _GenerateNameCommand = new RelayCommand(
                        param => ShowGeneratedName(),
                        param => true
                    );
                }
                return _GenerateNameCommand;
            }
        }
        #endregion
    }
}
