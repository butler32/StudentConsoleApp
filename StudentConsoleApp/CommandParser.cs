using StudentConsoleApp.Validators;
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
                    {
                        AddValidator addValidator = new AddValidator(parametrs);
                        parametrs = addValidator.Validate();
                        if (int.Parse(parametrs[0]) == 1)
                            return new AddComand(repository, parametrs);
                        else return new ErrorCommand(repository, parametrs);
                    }
                case "EDIT":
                    {
                        EditValidator editValidator = new EditValidator(parametrs);
                        parametrs = editValidator.Validate();
                        if (int.Parse(parametrs[0]) == 1)
                            return new EditCommand(repository, parametrs);
                        else return new ErrorCommand(repository, parametrs);
                    }
                case "GET":
                    {
                        IdValidator idValidator = new IdValidator(parametrs);
                        parametrs = idValidator.Validate();
                        if (int.Parse(parametrs[0]) == 1)
                            return new GetCommand(repository, parametrs);
                        else return new ErrorCommand(repository, parametrs);
                        
                    }
                case "DELETE":
                    {
                        IdValidator idValidator = new IdValidator(parametrs);
                        parametrs = idValidator.Validate();
                        if (int.Parse(parametrs[0]) == 1)
                            return new DeleteCommand(repository, parametrs);
                        else return new ErrorCommand(repository, parametrs);
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
                        FindValidator findValidator = new FindValidator(parametrs);
                        parametrs = findValidator.Validate();
                        if (int.Parse(parametrs[0]) == 1)
                            return new FindCommand(repository, parametrs);
                        else return new ErrorCommand(repository, parametrs);
                    }
                default:
                    return new Command(repository, parametrs);
            }
        }
    }
}