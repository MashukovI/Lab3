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

namespace TRPO_Lab3.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void validationError(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
            {
                // MessageBox.Show(e.Error.ErrorContent.ToString());
                surfaceAreaTextBlock.Text = e.Error.ErrorContent.ToString();
            }
            if (e.Action == ValidationErrorEventAction.Removed)
            {
                Binding myBinding = new Binding
                {
                    Source = DataContext,
                    Path = new PropertyPath("SurfaceArea"),
                };
                BindingOperations.SetBinding(surfaceAreaTextBlock, TextBlock.TextProperty, myBinding);
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
