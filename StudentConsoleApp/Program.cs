using System;

namespace StudentsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            var parser = new CommandsParser(repository);
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