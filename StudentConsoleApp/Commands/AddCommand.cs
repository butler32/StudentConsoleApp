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

        private Student student;
        
        public AddComand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
            student = new Student(parametrs[1], parametrs[2], parametrs[3], int.Parse(parametrs[4]));
        }
        
        public override string Execute()
        {
            try
            {
                repository.Add(student);
                return $"Студент {student.surname} {student.name} добавлен";
            }
            catch(ArgumentException ex)
            {
                return ex.Message;
            }
        }
    }
}