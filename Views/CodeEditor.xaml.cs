using SandboxForTasks.Service;
using SandboxForTasks.ViewModels;
using System.Drawing.Text;
using System.Windows;
using System.Windows.Controls;

namespace SandboxForTasks.Views
{
    /// <summary>
    /// Interaction logic for CodeEditor.xaml
    /// </summary>
    public partial class CodeEditor : UserControl
    {
        public CodeEditor()
        {
            InitializeComponent();
            this.DataContext = new CodeEditorViewModel();
        }
        private void Execute_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
