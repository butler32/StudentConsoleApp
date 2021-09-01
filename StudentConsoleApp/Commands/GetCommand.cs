using System;
using StudentConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp.Commands
{
    class GetCommand : Command
    {
        public GetCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
        }
        public override string Execute()
        {
            Student student = repository.Get(int.Parse(parametrs[1]));
            if (student is not null)
            {
                return $"Студент с id {student.id}: Имя - {student.name}, " +
                    $"Фамилия - {student.surname}, " +
                    $"Пол - {student.gender}, " +
                    $"Возраст - {student.age}";
            }
            else
                return "Такого студента не существует";
        }
    }
}