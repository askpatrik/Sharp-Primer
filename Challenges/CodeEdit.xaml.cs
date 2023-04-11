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
        InitializeComponent();
        CodeEditor editor = new CodeEditor();
        editor.SetValue(Grid.RowProperty, 1);
        editor.SetValue(Grid.ColumnProperty, 0);
        editor.SetValue(Grid.ColumnSpanProperty, 2);
        MainGrid.Children.Add(editor);
    }
    private void RunCode_Click(object sender, RoutedEventArgs e)
{
    // Code to execute when the "Run Code" button is clicked
}
    }
}