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
        int id;

        public EditCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
            student = new Student(parametrs[2], parametrs[3], parametrs[4], int.Parse(parametrs[5]));
            id = int.Parse(parametrs[1]);
        }

        public override string Execute()
        {
            repository.Edit(student, id);
            return "Студент изменён";
        }
    }
}
