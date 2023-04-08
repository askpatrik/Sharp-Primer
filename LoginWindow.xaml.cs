using System.Windows;

namespace Sharp_Primer
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            // Create a new instance of the CreateAccountWindow and show it
            var createAccountWindow = new CreateAccountWindow();
            createAccountWindow.Show();
        }

    }

}