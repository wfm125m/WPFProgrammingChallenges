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
    /// Interaction logic for LowerUpperView.xaml
    /// </summary>
    public partial class LowerHigherView : UserControl
    {
        public LowerHigherView()
        {
            InitializeComponent();
        }

        private void NumericOnly(System.Object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = Helpers.HelperMethods.IsTextNumeric(e.Text);

        }
    }
}
