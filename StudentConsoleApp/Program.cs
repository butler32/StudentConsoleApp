using System;

namespace StudentsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            var parser = new CommandsParser(repository);
            string input = "add стас стасик муж 18";
            var command = parser.Parse(input);
            var result = command.Execute();
            input = "add вова вовчик Ж 19";
            command = parser.Parse(input);
            result = command.Execute();
            input = "add влад владик женский 20";
            command = parser.Parse(input);
            result = command.Execute();
            input = "add даник дэнчик мужской 21";
            command = parser.Parse(input);
            result = command.Execute();
            input = "add кирилл кирилльчик жен 22";
            command = parser.Parse(input);
            result = command.Execute();
            while (true)
            {
                input = Console.ReadLine();
                Console.Clear();
                command = parser.Parse(input);
                result = command.Execute();

                Console.WriteLine(result);
            }
        }
    }
}