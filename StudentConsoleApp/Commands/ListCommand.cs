using StudentConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp.Commands
{
    class ListCommand : Command
    {
        public ListCommand(Repository repository, string[] parametrs) : base(repository, parametrs)
        {
        }

        public override string Execute()
        {
            string studentsList = string.Empty;
            Student[] student = repository.List();
            for (int i = 0; i < student.Length; i++)
            {
                if (student[i] != null)
                {
                    studentsList += $"Студент с id {student[i].id}: Имя - {student[i].name}, " +
                $"Фамилия - {student[i].surname}, " +
                $"Пол - {student[i].gender}, " +
                $"Возраст - {student[i].age}\n";
                }
            }
            if (!string.IsNullOrEmpty(studentsList))
                return studentsList;
            else
                return "Список пуст";
        }
    }
}