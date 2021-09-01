using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp.Validators
{
    class AddValidator : Validator
    {
        public AddValidator(string[] parametrs) : base(parametrs)
        {
        }

        public override string[] Validate()
        {
            if (parametrs[1] is null || parametrs[2] is null || parametrs[3] is null || parametrs[4] is null)
            {
                parametrs[0] = "2";
                return parametrs;
            }

            int age;
            bool result = int.TryParse(parametrs[4], out age);
            if (result is false)
            {
                parametrs[0] = "3";
                return parametrs;
            }
            else
            {
                if (age < 18 || age > 99)
                {
                    parametrs[0] = "3";
                    return parametrs;
                }
            }

            switch (parametrs[3])
            {
                case "М":
                    {
                        parametrs[3] = "Мужской";
                        break;
                    }
                case "Ж":
                    {
                        parametrs[3] = "Женский";
                        break;
                    }
                case "муж":
                    {
                        parametrs[3] = "Мужской";
                        break;
                    }
                case "жен":
                    {
                        parametrs[3] = "Женский";
                        break;
                    }
                case "мужской":
                    {
                        parametrs[3] = "Мужской";
                        break;
                    }
                case "женский":
                    {
                        parametrs[3] = "Женский";
                        break;
                    }
                default:
                    {
                        parametrs[0] = "4";
                        return parametrs;
                    }
            }


            string name = parametrs[1].Substring(0, 1).ToUpper() + (parametrs[1].Length > 1 ? parametrs[1].Substring(1, parametrs[1].Length - 1) : "").ToLower();
            

            if (name.Length > 50)
            {
                parametrs[0] = "5";
                return parametrs;
            }

            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsDigit(name[i]))
                {
                    parametrs[0] = "5";
                    return parametrs;
                }
            }

            parametrs[1] = name;
            name = parametrs[2].Substring(0, 1).ToUpper() + (parametrs[2].Length > 1 ? parametrs[2].Substring(1, parametrs[2].Length - 1) : "").ToLower();

            if (name.Length > 50)
            {
                parametrs[0] = "5";
                return parametrs;
            }

            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsDigit(name[i]))
                {
                    parametrs[0] = "5";
                    return parametrs;
                }
            }

            parametrs[2] = name;
            parametrs[0] = "1";
            return parametrs;
        }
    }
}
