using System.Windows;

namespace Sharp_Primer
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly DatabaseManager dbManager;

        public LoginWindow(DatabaseManager dbManager)
        {
            InitializeComponent();
            this.dbManager = dbManager;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Password;

            // Check if the user exists in the database
            if (dbManager.UserExists(username))
            {
                // Check if the password is correct
                if (dbManager.VerifyPassword(username, password))
                {
                    MessageBox.Show("Login successful!");
                    UserHomeWindow userHomeWindow = new UserHomeWindow(username);
                    userHomeWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Incorrect password. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Username does not exist. Please try again.");
            }
        }
        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            // Create a new instance of the CreateAccountWindow and show it
            var createAccountWindow = new CreateAccountWindow(dbManager);
            createAccountWindow.Show();
        }

    }

}