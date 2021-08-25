using StudentsConsoleApp.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp
{
    class CommandsParser
    {
        private Repository repository;

        public CommandsParser(Repository repository)
        {
            this.repository = repository;
        }

        public Command Parse(string input)
        {
            var inputArr = input.Split();
            string[] parametrs = new string[6];
            int index = 0;

            foreach (var item in inputArr)
            {
                if (!string.IsNullOrEmpty(item) && index < parametrs.Length)
                {
                    parametrs[index] = item;
                    index++;
                }
            }
            
            switch (parametrs[0].ToUpper())
            {
                case "ADD":
                    return new AddComand(repository, parametrs);
                case "EDIT":
                    return new EditCommand(repository, parametrs);
                case "GET":
                    return new GetCommand(repository, parametrs);
                case "DELETE":
                    return new DeleteCommand(repository, parametrs);
                default:
                    return new Command(repository, parametrs);
            }
        }
    }
}