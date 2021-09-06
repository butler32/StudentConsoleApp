using System;

namespace StudentConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            var parser = new CommandsParser(repository);
            string defaultInput = "add стас стасик М 18";
            var defaultCommand = parser.Parse(defaultInput);
            var defaultResult = defaultCommand.Execute();
            defaultInput = "add вова вовчик М 19";
            defaultCommand = parser.Parse(defaultInput);
            defaultResult = defaultCommand.Execute();
            defaultInput = "add влад владик М 20";
            defaultCommand = parser.Parse(defaultInput);
            defaultResult = defaultCommand.Execute();
            defaultInput = "add даник дэнчик мужской 21";
            defaultCommand = parser.Parse(defaultInput);
            defaultResult = defaultCommand.Execute();
            defaultInput = "add кирилл кирилльчик М 22";
            defaultCommand = parser.Parse(defaultInput);
            defaultResult = defaultCommand.Execute();
            while (true)
            {
                string input = Console.ReadLine();
                Console.Clear();
                var command = parser.Parse(input);
                var result = command.Execute();

                Console.WriteLine(result);
            }
        }
    }
}