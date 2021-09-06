using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentConsoleApp.Validators;

namespace StudentConsoleApp.Commands
{
    class GetCommand : Command
    {
        public GetCommand(Repository repository, string[] parametrs)
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

            Student student = repository.Get(int.Parse(parametrs[1]));
            if (student != null)
            {
                return Student.ToString(student);
            }
            else
                return "Такого студента не существует";
        }
    }
}