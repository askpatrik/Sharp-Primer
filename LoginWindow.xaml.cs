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
        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            // Create a new instance of the CreateAccountWindow and show it
            var createAccountWindow = new CreateAccountWindow(dbManager);
            createAccountWindow.Show();
        }

    }

}