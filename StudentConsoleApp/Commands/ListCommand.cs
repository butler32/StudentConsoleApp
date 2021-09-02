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
            StringBuilder studentsList = new StringBuilder();
            Student[] student = repository.List();
            for (int i = 0; i < student.Length; i++)
            {
                if (student[i] != null)
                {
                    studentsList.Append(Student.ToString(student[i]));
                }
            }
            if (!string.IsNullOrEmpty(studentsList.ToString()))
                return studentsList.ToString();
            else
                return "Список пуст";
        }
    }
}