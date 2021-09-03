using StudentConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp.Commands
{
    class RandomCommand : Command
    {
        public RandomCommand(Repository repository, string[] parametrs) : base(repository, parametrs)
        {
        }

        public override string Execute()
        {
            Random rnd = new Random();
            Student[] students = repository.List();

            if (students.Length == 0)
            {
                return "Нет студентов";
            }

            int index = rnd.Next(0, students.Length);
            return Student.ToString(students[index]);
        }
    }
}