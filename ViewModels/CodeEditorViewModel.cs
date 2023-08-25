using Newtonsoft.Json;
using SandboxForTasks.Models;
using SandboxForTasks.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
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
            string language = "PYTHON"; 
            MessageBox.Show("CURRENT " + EditorModel.Language);
            ClientHackerEarth clientHackerEarth = new ClientHackerEarth();
            if (EditorModel.Language == "JavaScript")
            {
                language = "JAVASCRIPT_NODE";
            }
            else if (EditorModel.Language == "Java")
            {
                language = "JAVA8";
            }
            else if (EditorModel.Language == "Python")
            {
                language = "PYTHON";
            }
            else if (EditorModel.Language == "C#")
            {
                language = "CSHARP";
            }
            else if (EditorModel.Language == "TypeScript")
            {
                language = "TYPESCRIPT";
            }
            ResponseSubmissionsModel response = await clientHackerEarth.GetCodeValidation(EditorModel.CodeToValidate, language);
            
            /*
             * Sleep waiting for compiling result on HackerEarth
             */
            Thread.Sleep(5000);

            ResponseConcreteSubmissionModel responseConcrete =  await clientHackerEarth.GetResultOfCompiling(response.HeId);
     
            string stderr = responseConcrete.ResultConrete.RunStatusConrete.Stderr;
            if (stderr != "" && stderr != null) 
            {
                this.EditorModel.Stderr = "Erro List " + Environment.NewLine + stderr;
            }

            string output = responseConcrete.ResultConrete.RunStatusConrete.Output;
            if (output != "" && output != null)
            {
                HttpClient httpClient = new HttpClient();
                var result  = await httpClient.GetAsync(output);
                this.EditorModel.Output = "Output " + Environment.NewLine + result.Content.ReadAsStringAsync().Result;
            }
        } 
    }
}
