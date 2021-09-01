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

            do
            {
                int index = rnd.Next(0, students.Length);
                if (students[index] != null)
                {
                    return $"Студент с id {students[index].id}: Имя - {students[index].name}, " +
                    $"Фамилия - {students[index].surname}, " +
                    $"Пол - {students[index].gender}, " +
                    $"Возраст - {students[index].age}";
                }
            }
            while (true);
        }
    }
}