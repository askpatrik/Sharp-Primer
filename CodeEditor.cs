using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using ICSharpCode.AvalonEdit.Highlighting;

namespace Sharp_Primer
{
        //This class creates an instance of the AvalonEdit TextEditor, 
        //sets some properties such as syntax highlighting and font, 
        //and exposes a Text property to get or set the editor's contents. 
        //It also provides FocusEditor() and SelectAll() methods to programmatically
        // focus the editor and select all text, respectively.
    public class CodeEditor : UserControl
    {
        private ICSharpCode.AvalonEdit.TextEditor _editor;

        public CodeEditor()
        {
            _editor = new ICSharpCode.AvalonEdit.TextEditor();
            _editor.ShowLineNumbers = true;
            _editor.SyntaxHighlighting = HighlightingManager.Instance.GetDefinition("C#");
            _editor.FontFamily = new System.Windows.Media.FontFamily("Consolas");
            _editor.FontSize = 14;

        }
        public string Text
        {
            get { return _editor.Text; }
            set { _editor.Text = value; }
        }

        public void FocusEditor()
        {
            _editor.Focus();
        }

        public void SelectAll()
        {
            _editor.SelectAll();
        }
    }
}