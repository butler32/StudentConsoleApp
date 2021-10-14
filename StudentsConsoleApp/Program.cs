using System;

namespace StudentConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRun = true;
            Repository repository = new Repository();
            var parser = new CommandsParser(repository);
            //string defaultInput = "add stas stas М 18";
            //var defaultCommand = parser.Parse(defaultInput);
            //var defaultResult = defaultCommand.Execute();
            //defaultInput = "add vova vova М 19";
            //defaultCommand = parser.Parse(defaultInput);
            //defaultResult = defaultCommand.Execute();
            //defaultInput = "add vlad vlad М 20";
            //defaultCommand = parser.Parse(defaultInput);
            //defaultResult = defaultCommand.Execute();
            //defaultInput = "add danik danik мужской 21";
            //defaultCommand = parser.Parse(defaultInput);
            //defaultResult = defaultCommand.Execute();
            //defaultInput = "add kirill kirill М 22";
            //defaultCommand = parser.Parse(defaultInput);
            //defaultResult = defaultCommand.Execute();
            while (isRun)
            {
                string input = Console.ReadLine();
                Console.Clear();
                var command = parser.Parse(input);
                var result = command.Execute();

                Console.WriteLine(result);
                if (result == "Пока")
                {
                    isRun = false;
                }
            }
        }
    }
}