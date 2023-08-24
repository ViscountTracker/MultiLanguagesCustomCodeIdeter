using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace SandboxForTasks.Models
{
    public class CodeEditorModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string codeToValidate;
        private string output;
        public string CodeToValidate
        {
            get
            {
                return this.codeToValidate;
            }

            set
            {
                this.codeToValidate= value;
                NotifyPropertyChanged();
            }
        }
        public string Output 
        {
            get {
                 return this.output; 
            }
            set {
                this.output= value;
                NotifyPropertyChanged();
            }
        }
      

        public CodeEditorModel()
        {
            CodeToValidate = "";
            Output = "Output: ";
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
