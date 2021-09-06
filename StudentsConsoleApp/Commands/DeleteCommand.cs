using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp.Commands
{
    class DeleteCommand : Command
    {
        public DeleteCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
        }
        public override string Execute()
        {
            int result = repository.Delete(int.Parse(parametrs[1]));
            string res;
            _ = result == 1 ? res = "Студент отчислен(" : res = "Нету студента с таким id";
            return res;
        }
    }
}