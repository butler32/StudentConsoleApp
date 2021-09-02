using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp.Commands
{
    class ErrorCommand : Command
    {
        public ErrorCommand(Repository repository, string[] parametrs) : base (repository, parametrs)
        {
        }

        public override string Execute()
        {
            if (parametrs[6] == "2")
                return "Введены не все параметры";
            if (parametrs[6] == "3")
                return "Неверно введены числовые параметры";
            if (parametrs[6] == "4")
                return "Неверно введён пол";
            if (parametrs[6] == "5")
                return "Максимальная длина имени и фамилии - 50";
            if (parametrs[6] == "6")
                return "В имени и фамилии не должно быть цифр";
            if (parametrs[6] == "7")
                return "Возраст должен быть от 18 до 99 лет";
            return "Введите верно команду";
        }
    }
}
