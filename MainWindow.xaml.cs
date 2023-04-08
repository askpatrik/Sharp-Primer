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
using Microsoft.Data.Sqlite;

namespace Sharp_Primer
{
    public partial class MainWindow : Window
    {

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

    }
}