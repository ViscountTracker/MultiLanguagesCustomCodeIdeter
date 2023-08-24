using Newtonsoft.Json;
using SandboxForTasks.Models;
using SandboxForTasks.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

namespace SandboxForTasks.ViewModels
{
    public class CodeEditorViewModel
    {
       public CodeEditorModel EditorModel { get; set; }

        public CodeEditorViewModel() 
        {
            EditorModel = new CodeEditorModel();
        }
        public async void ValidateCode() 
        {   
            ResponseSubmissionsModel response = await Task.Run(async () =>
            {
                ClientHackerEarth clientHackerEarth = new ClientHackerEarth();
                return await clientHackerEarth.GetCodeValidation(EditorModel.CodeToValidate);
            });
          

            ResponseConcreteSubmissionModel responseConcrete = await Task.Run(async () =>
            {
                ClientHackerEarth clientHackerEarth = new ClientHackerEarth();
                return await clientHackerEarth.GetResultOfCompiling(response.HeId);
            });
            this.EditorModel.Output += Environment.NewLine + responseConcrete.ResultConrete.RunStatusConrete.Stderr;
        }
        //TODO: метод для аупут успешного выполнения программы  модель описать 
        //TODO: Комбо бокс с выбором языка топ языков JavaScript
        //JavaScript
        //Java
        //Python
        //C#
        //TypeScript
        //TODO: разделить аутпут для ошибок и нормального вывода ошибки красным 
        //TODO: To create commit 
    }
}
