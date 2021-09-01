using System;
using StudentConsoleApp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using StudentConsoleApp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp.Commands
{
    class AddComand : Command
    {
        public AddComand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
        }

        public override string Execute()
        {
            Student student = new Student(parametrs[1], parametrs[2], parametrs[3], int.Parse(parametrs[4]));
            int result = repository.Add(student);
            if (result != 0)
                return $"Студент {student.surname} {student.name} добавлен";
            else
                return "Не получилось добавить студента";
        }
    }
}