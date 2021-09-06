using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentConsoleApp.Commands;
using StudentConsoleApp.Validators;

namespace StudentConsoleApp.Commands
{
    class EditCommand : Command
    {
        private Student student;

        public EditCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
        }

        public override string Execute()
        {
            var errorResult = BaseValidator.NullValidate(parametrs) | BaseValidator.IdValidate(parametrs[1]) 
                | BaseValidator.NameValidate(parametrs[2])
                | BaseValidator.NameValidate(parametrs[3]) |
                BaseValidator.GenderValidate(parametrs[4]) | BaseValidator.AgeValidate(parametrs[5]);
            if (errorResult != 0)
            {
                ErrorCommand error = new ErrorCommand(repository, parametrs, (ErrorList)errorResult);
                return error.Execute();
            }

            student = new Student(parametrs[2], parametrs[3], parametrs[4], int.Parse(parametrs[5]));
            int check = repository.Edit(int.Parse(parametrs[1]), student);
            if (check != 0)
                return $"Студент c id {check} изменён";
            else return "Возникла ошибка";
        }
    }
}