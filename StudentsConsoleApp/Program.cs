using System;

namespace StudentConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            var parser = new CommandsParser(repository);
            string defaultInput = "add стас стасик женский 18";
            var defaultCommand = parser.Parse(defaultInput);
            var defaultResult = defaultCommand.Execute();
            defaultInput = "add вова вовчик Ж 19";
            defaultCommand = parser.Parse(defaultInput);
            defaultResult = defaultCommand.Execute();
            defaultInput = "add влад владик женский 20";
            defaultCommand = parser.Parse(defaultInput);
            defaultResult = defaultCommand.Execute();
            defaultInput = "add даник дэнчик мужской 21";
            defaultCommand = parser.Parse(defaultInput);
            defaultResult = defaultCommand.Execute();
            defaultInput = "add кирилл кирилльчик жен 22";
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