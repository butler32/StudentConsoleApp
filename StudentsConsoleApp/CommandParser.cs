using StudentConsoleApp.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp
{
    [Flags]
    enum ErrorList
    {
        NullFields = 0b_000_0001,
        WrongDigits = 0b_000_0010,
        WrongGender = 0b_000_0100,
        WrongLength = 0b_000_1000,
        WrongName = 0b_001_0000,
        WrongAge = 0b_010_0000,
        WrongCommand = 0b_100_0000
    }

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

            switch (parametrs[0]?.ToUpper())
            {
                case "ADD":
                    {
                        return new AddComand(repository, parametrs);
                    }
                case "EDIT":
                    {
                        return new EditCommand(repository, parametrs);
                    }
                case "GET":
                    {
                        return new GetCommand(repository, parametrs);
                    }
                case "DELETE":
                    {
                        return new DeleteCommand(repository, parametrs);
                    }
                case "LIST":
                    {
                        return new ListCommand(repository, parametrs);
                    }
                case "RAND":
                    {
                        return new RandomCommand(repository, parametrs);
                    }
                case "FIND":
                    {
                        return new FindCommand(repository, parametrs);
                    }
                default:
                    {
                        return new ErrorCommand(repository, parametrs, 0);
                    }
            }
        }
    }
}