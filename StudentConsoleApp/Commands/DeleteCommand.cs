using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp.Commands
{
    class DeleteCommand : Command
    {
        int id;
        public DeleteCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
            id = int.Parse(parametrs[1]);
        }
        public override string Execute()
        {
            repository.Delete(id);
            return "Студент отчислен(";
        }
    }
}
