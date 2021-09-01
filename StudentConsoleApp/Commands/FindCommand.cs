using StudentConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp.Commands
{
    class FindCommand : Command
    {
        public FindCommand(Repository repository, string[] parametrs) : base(repository, parametrs)
        {
        }

        public override string Execute()
        {
            Student[] student = repository.Find(parametrs[1]);
            if (student[0] is null)
                return "Студентов не найдено";
            string findStudent = "Найдены студенты:\n";
            for (int i = 0; i < student.Length; i++)
            {
                if (student[i] != null)
                {
                    findStudent += $"Студент с id {student[i].id}: Имя - {student[i].name}, " +
                    $"Фамилия - {student[i].surname}, " +
                    $"Пол - {student[i].gender}, " +
                    $"Возраст - {student[i].age}\n";
                }
            }
            return findStudent;
        }
    }
}