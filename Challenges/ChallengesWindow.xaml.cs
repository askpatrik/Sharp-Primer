using System.Windows;
using Sharp_Primer.Challenges;

namespace Sharp_Primer
{
    /// <summary>
    /// Interaction logic for ChallengesWindow.xaml
    /// </summary>
    public partial class ChallengesWindow : Window
    {
        public ChallengesWindow()
        {
            InitializeComponent();
        }
        private void CodeEdit_Click(object sender, RoutedEventArgs e)
        {
            CodeEdit codeEditWindow = new CodeEdit();
            codeEditWindow.Show();
            this.Close();
        }

    }
}