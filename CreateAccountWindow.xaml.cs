using System.Windows;

namespace Sharp_Primer
{
    public partial class CreateAccountWindow : Window
    {
        private readonly DatabaseManager dbManager;

        public CreateAccountWindow(DatabaseManager dbManager)
        {
            InitializeComponent();
            this.dbManager = dbManager;
        }
        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            // Collect the user's input data
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            // check if username and password are valid, then insert into database
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                dbManager.InsertUser(username, password);
                // show success message and close window
                MessageBox.Show("Account created successfully!");
                this.Close();
            }
            else
            {
                // show error message if username or password is empty
                MessageBox.Show("Please enter a valid username and password.");
            }

            // TODO: Implement code to create a new account

            // Close the CreateAccountWindow
            this.Close();
        }

    }
}