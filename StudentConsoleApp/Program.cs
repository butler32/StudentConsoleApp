using System;

namespace StudentsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            while(true)
            {
                string input = Console.ReadLine();
                Console.Clear();
                var parser = new CommandsParser(repository);
                var command = parser.Parse(input);
                var result = command.Execute();

                Console.WriteLine(result);
            }
        }
    }
}