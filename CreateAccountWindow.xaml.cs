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

namespace Sharp_Primer
{
    /// <summary>
    /// Interaction logic for CreateAccountWindow.xaml
    /// </summary>
    public partial class CreateAccountWindow : Window
    {
        public CreateAccountWindow()
        {
            InitializeComponent();
        }
        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            // Collect the user's input data
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            // TODO: Implement code to create a new account

            // Close the CreateAccountWindow
            this.Close();
        }
    }
}