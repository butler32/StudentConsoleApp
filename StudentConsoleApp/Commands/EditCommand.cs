using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsConsoleApp.Commands;
using StudentConsoleApp;

namespace StudentsConsoleApp.Commands
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
            student = new Student(parametrs[2], parametrs[3], parametrs[4], int.Parse(parametrs[5]));
            int check = repository.Edit(int.Parse(parametrs[1]), student);
            if (check != 0)
                return $"Студент c id {check} изменён";
            else return "Возникла ошибка";
        }
    }
}