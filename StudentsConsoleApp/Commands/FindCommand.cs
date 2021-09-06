using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentConsoleApp.Validators;

namespace StudentConsoleApp.Commands
{
    class FindCommand : Command
    {
        public FindCommand(Repository repository, string[] parametrs) : base(repository, parametrs)
        {
        }

        public override string Execute()
        {
            var errorResult = BaseValidator.OneParametrNullValidate(parametrs[1]);
            if (errorResult == 0)
                errorResult = BaseValidator.NameValidate(parametrs[1]);
            if (errorResult != 0)
            {
                ErrorCommand error = new ErrorCommand(repository, parametrs, (ErrorList)errorResult);
                return error.Execute();
            }

            Student[] student = repository.Find(parametrs[1]);
            if (student[0] == null)
                return "Студентов не найдено";
            StringBuilder findStudent = new StringBuilder("Найдены студенты:\n");
            for (int i = 0; i < student.Length; i++)
            {
                if (student[i] != null)
                {
                    findStudent.Append(Student.ToString(student[i]));
                }
            }
            return findStudent.ToString();
        }
    }
}