using StudentConsoleApp.Validators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace StudentConsoleApp.Commands
{
    class DeserializeCommand : Command
    {
        Student[] students;
        public DeserializeCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        { 
        }

        public override string Execute()
        {
            var errorResult = BaseValidator.OneParametrNullValidate(parametrs[1]) | BaseValidator.PathValidate(parametrs[1]);
            if (errorResult != 0)
            {
                ErrorCommand error = new ErrorCommand(repository, parametrs, (ErrorList)errorResult);
                return error.Execute();
            }

            Deserialize();
            Thread.Sleep(100);
            int i = 0;
            foreach (var item in students)
            {
                if (repository.Get(item.Id) != null)
                {
                    repository.Edit(item.Id, item);
                }
                else
                {
                    repository.Add(item);
                }
                i++;
            }
            for (; i < 10; i++)
            {
                repository.Delete(i + 1);
            }
            return "Файл загружен";
        }

        private async void Deserialize()
        {
            using FileStream openStream = File.OpenRead(parametrs[1]);
            students = await JsonSerializer.DeserializeAsync<Student[]>(openStream);
        }
    }
}
