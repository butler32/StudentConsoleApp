using StudentConsoleApp.Validators;
using System.IO;
using System.Text.Json;

namespace StudentConsoleApp.Commands
{
    class SerializeCommand : Command
    {
        public SerializeCommand(Repository repository, string[] parametrs)
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

            serialize();
            return "Файл сохранён";
        }

        private async void serialize()
        {
            using (Stream stream = File.Open(parametrs[1], FileMode.Create))
            {
                await JsonSerializer.SerializeAsync<Student[]>(stream, repository.List());
            }
        }
    }
}
