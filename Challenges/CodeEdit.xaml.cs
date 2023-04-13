using System.Windows;
using System.Windows.Controls;

namespace Sharp_Primer.Challenges
{
    /// <summary>
    /// Interaction logic for CodeEdit.xaml
    /// </summary>
    public partial class CodeEdit : Window
    {
        public CodeEdit()
        {
            Challenge challenge = Challenge.GetRandomChallenge();
            DataContext = challenge;
            InitializeComponent();

        }
        private void RunCode_Click(object sender, RoutedEventArgs e)
        {
            // Code to execute when the "Run Code" button is clicked
        }
    }
}