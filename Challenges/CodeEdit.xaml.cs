using System.CodeDom.Compiler;
using System.Windows;
using System.Windows.Controls;
using Microsoft.CSharp;

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
            RunCode();
            // Code to execute when the "Run Code" button is clicked
        }
          public void RunCode()
        {
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = false;
            parameters.GenerateInMemory = true;
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, this.CodeEditor.Text);
            if (results.Errors.HasErrors)
            {
                // Handle compilation errors
                foreach (CompilerError error in results.Errors)
                {
                    // Display error messages to the user
                    MessageBox.Show(error.ErrorText, "Compilation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                // Compilation succeeded, so let's execute the code
                
                int answer = (int)Challenge.ExecuteCode(results.CompiledAssembly);
                
            }
        }
    }
}