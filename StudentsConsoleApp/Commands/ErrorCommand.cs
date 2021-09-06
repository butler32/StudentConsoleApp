using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp.Commands
{
    class ErrorCommand : Command
    {
        ErrorList er;
        public ErrorCommand(Repository repository, string[] parametrs, ErrorList error) : base (repository, parametrs)
        {
            er = error;
        }

        public override string Execute()
        {
            switch(er)
            {
                case ErrorList.NullFields:
                    {
                        return "Введены не все параметры";
                    }
                case ErrorList.WrongDigits:
                    {
                        return "Неверно введены числовые параметры";
                    }
                case ErrorList.WrongGender:
                    {
                        return "Неверно введён пол";
                    }
                case ErrorList.WrongLength:
                    {
                        return "Максимальная длина имени и фамилии - 50";
                    }
                case ErrorList.WrongName:
                    {
                        return "В имени и фамилии не должно быть цифр";
                    }
                case ErrorList.WrongAge:
                    {
                        return "Возраст должен быть от 18 до 99 лет";
                    }
                default:
                    {
                        return "Введите верно команду";
                    }
            }
        }
    }
}
