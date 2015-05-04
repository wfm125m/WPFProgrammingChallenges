using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFProgrammingChallenges.View
{
    /// <summary>
    /// Interaction logic for TemperatureConverterView.xaml
    /// </summary>
    public partial class TemperatureConverterView : UserControl
    {
        public TemperatureConverterView()
        {
            InitializeComponent();
        }

        private void NumericOnly(System.Object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = Helpers.HelperMethods.IsDouble(e.Text);

        }
    }
}
