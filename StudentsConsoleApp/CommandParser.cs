using StudentsConsoleApp.Commands;
using StudentsConsoleApp.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp
{
    enum ErrorList
    {
        NullFields = 2,
        WrongDigits,
        WrongGender,
        WrongLength,
        WrongName,
        WrongAge,
        WrongCommand = 0
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

            Validator val = new Validator(parametrs);
            int result = 1;
            result = val.Validate();
            if (result != 1)
            {
                return new ErrorCommand(repository, parametrs, (ErrorList)result);
            }

            switch (parametrs[0]?.ToUpper())
            {
                case "ADD":
                    {
                        parametrs[1] = Mapper.NameMap(parametrs[1]);
                        parametrs[2] = Mapper.NameMap(parametrs[2]);
                        parametrs[3] = Mapper.GenderMap(parametrs[3]);
                        return new AddComand(repository, parametrs);
                    }
                case "EDIT":
                    {
                        parametrs[2] = Mapper.NameMap(parametrs[2]);
                        parametrs[3] = Mapper.NameMap(parametrs[3]);
                        parametrs[4] = Mapper.GenderMap(parametrs[4]);
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
                        parametrs[1] = Mapper.NameMap(parametrs[1]);
                        return new FindCommand(repository, parametrs);
                    }
                default:
                    {
                        return new ErrorCommand(repository, parametrs, (ErrorList)result);
                    }
            }
        }
    }
}