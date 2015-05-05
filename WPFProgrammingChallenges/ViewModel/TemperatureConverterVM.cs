using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProgrammingChallenges.Helpers;

namespace WPFProgrammingChallenges.ViewModel
{
    class TemperatureConverterVM : PropertyChangedHandler
    {
        public int SelectedInput { get; set; }
        public int SelectedOutput { get; set; }

        private double defaultKelvinTemperature = 273.15;
        private double inputTemp;
        public double InputValue
        {
            get { return inputTemp; }
            set {
                switch (SelectedInput)
                {
                    case 0:
                        if (value < -273.15)
                        {
                            defaultKelvinTemperature = 0;
                            inputTemp = -273.15;
                            RaisePropertyChangedEvent("InputValue");
                            RaisePropertyChangedEvent("OutputValue");
                            return;
                        }
                        defaultKelvinTemperature = value + 273.15;
                        break;
                    case 1:
                        if (value < 0)
                        {
                            defaultKelvinTemperature = 0;
                            inputTemp = 0;
                            RaisePropertyChangedEvent("InputValue");
                            RaisePropertyChangedEvent("OutputValue");
                            return;
                        }
                        defaultKelvinTemperature = value;
                        break;
                    case 2:
                        if (value < -459.67)
                        {
                            defaultKelvinTemperature = 0;
                            inputTemp = -459.67;
                            RaisePropertyChangedEvent("InputValue");
                            RaisePropertyChangedEvent("OutputValue");
                            return;
                        }
                        defaultKelvinTemperature = (value - 32.00) / 1.8000 + 273.15;
                        break;
                    default:
                        break;
                }
                inputTemp = value;
                RaisePropertyChangedEvent("OutputValue");
            }
        }

       // private string outuptValue;

        public string OutputValue
        {
            get {
                switch (SelectedOutput)
                {
                    case 0:
                        return (defaultKelvinTemperature - 273.15).ToString();
                    case 1:
                        return defaultKelvinTemperature.ToString();
                    case 2:
                        return ((defaultKelvinTemperature - 273.15) * 1.8000 + 32.00).ToString();
                    default:
                        break;
                }
                return ""; 
            
            }
            //set { outuptValue = value; }
        }
        
        
    }
}
