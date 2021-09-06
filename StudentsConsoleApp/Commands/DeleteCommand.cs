using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentConsoleApp.Validators;

namespace StudentConsoleApp.Commands
{
    class DeleteCommand : Command
    {
        public DeleteCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
        }
        public override string Execute()
        {
            var errorResult = BaseValidator.OneParametrNullValidate(parametrs[1]);
            if (errorResult == 0)
                errorResult = BaseValidator.IdValidate(parametrs[1]);
            if (errorResult != 0)
            {
                ErrorCommand error = new ErrorCommand(repository, parametrs, (ErrorList)errorResult);
                return error.Execute();
            }

            int result = repository.Delete(int.Parse(parametrs[1]));
            string res;
            _ = result == 1 ? res = "Студент отчислен(" : res = "Нету студента с таким id";
            return res;
        }
    }
}