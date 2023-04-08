using System.Windows;

namespace Sharp_Primer
{
    /// <summary>
    /// Interaction logic for UserHomeWindow.xaml
    /// </summary>
    public partial class UserHomeWindow : Window
    {
        private string username;
        public UserHomeWindow(string username)
        {
            InitializeComponent();
            this.username = username;
            LoggedInLabel.Content = "Logged in as " + username;
        }
    }
}