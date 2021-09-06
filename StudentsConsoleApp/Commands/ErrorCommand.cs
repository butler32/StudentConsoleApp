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
        public ErrorCommand(Repository repository, string[] parametrs, ErrorList error) : base(repository, parametrs)
        {
            er = error;
        }

        public override string Execute()
        {
            string res = string.Empty;
            if ((er & ErrorList.NullFields) != 0)
                res += "Введены не все параметры\n";

            if ((er & ErrorList.WrongLength) != 0)
                res += "Максимальная длина имени и фамилии - 50\n";

            if ((er & ErrorList.WrongName) != 0)
                res += "В имени и фамилии не должно быть цифр\n";

            if ((er & ErrorList.WrongGender) != 0)
                res += "Неверно введён пол\n";

            if ((er & ErrorList.WrongDigits) != 0)
                res += "Неверно введены числовые параметры\n";

            if ((er & ErrorList.WrongAge) != 0)
                res += "Возраст должен быть от 18 до 99 лет\n";

            return res;






          /*  switch (er)
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
            } */
        }
    }
}