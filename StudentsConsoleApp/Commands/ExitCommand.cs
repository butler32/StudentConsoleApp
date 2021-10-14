using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp.Commands
{
    class ExitCommand : Command
    {
        public ExitCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
        }

        public override string Execute()
        {
            return "Пока";
        }
    }
}
