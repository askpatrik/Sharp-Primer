using System.Windows;

namespace Sharp_Primer
{
    public partial class MainWindow : Window
    {
        public string loggedInUsername;

        private DatabaseManager dbManager;
        public MainWindow()
        {
            InitializeComponent();
            // Create database
            dbManager = new DatabaseManager();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow(dbManager);
            loginWindow.Show();
            this.Close();
        }
        private void ChallengesButton_Click(object sender, RoutedEventArgs e)
        {
            ChallengesWindow challengesWindow = new ChallengesWindow();
            challengesWindow.Show();
            this.Close();
        }
        public void MainWindow_Load()
        {
            // Check if the user is logged in
            if (loggedInUsername is not null)
            {
                // Display the logged-in user's username
                LoggedInLabel.Content = $"Logged in as {loggedInUsername}";
            }
            else
            {
                // Display a default message
                LoggedInLabel.Content = "Not logged in";
            }

        }
    }}