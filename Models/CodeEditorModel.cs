using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SandboxForTasks.Models
{
    public class CodeEditorModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string codeToValidate;
        private string output;
        private string stderr;
        private string language;
        public string Language
        {
            get { return this.language; }
            set
            {
                this.language = value;
                NotifyPropertyChanged();
            }
        }
        public string CodeToValidate
        {
            get
            {
                return this.codeToValidate;
            }
            set
            {
                this.codeToValidate = value;
                NotifyPropertyChanged();
            }
        }
        public string Output
        {
            get
            {
                return this.output;
            }
            set
            {
                this.output = value;
                NotifyPropertyChanged();
            }
        }
        public string Stderr
        {
            get
            {
                return this.stderr;
            }
            set
            {
                this.stderr = value;
                NotifyPropertyChanged();
            }
        }
        public CodeEditorModel()
        {
            CodeToValidate = "";
            Output = "Output: ";
            Stderr = "Eror List: ";
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
