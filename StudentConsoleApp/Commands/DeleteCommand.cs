using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp.Commands
{
    class DeleteCommand : Command
    {
        public DeleteCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
        }
        public override string Execute()
        {
            repository.Delete(int.Parse(parametrs[1]));
            return "Студент отчислен(";
        }
    }
}