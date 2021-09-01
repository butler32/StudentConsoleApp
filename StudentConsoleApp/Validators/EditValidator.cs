using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp.Validators
{
    class EditValidator : Validator
    {
        public EditValidator(string[] parametrs) : base (parametrs)
        {
        }

        public override string[] Validate()
        {
            if (parametrs[1] is null || parametrs[2] is null || parametrs[3] is null || parametrs[4] is null || parametrs[5] is null)
            {
                parametrs[0] = "2";
                return parametrs;
            }

            int intCheck;
            bool result = int.TryParse(parametrs[5], out intCheck);
            if (result is false)
            {
                parametrs[0] = "3";
                return parametrs;
            }
            else
            {
                if (intCheck < 18 || intCheck > 99)
                {
                    parametrs[0] = "3";
                    return parametrs;
                }
            }

            result = int.TryParse(parametrs[1], out intCheck);
            if (result is false)
            {
                parametrs[0] = "3";
                return parametrs;
            }

            switch (parametrs[4])
            {
                case "М":
                    {
                        parametrs[4] = "Мужской";
                        break;
                    }
                case "Ж":
                    {
                        parametrs[4] = "Женский";
                        break;
                    }
                case "муж":
                    {
                        parametrs[4] = "Мужской";
                        break;
                    }
                case "жен":
                    {
                        parametrs[4] = "Женский";
                        break;
                    }
                case "мужской":
                    {
                        parametrs[4] = "Мужской";
                        break;
                    }
                case "женский":
                    {
                        parametrs[4] = "Женский";
                        break;
                    }
                default:
                    {
                        parametrs[0] = "4";
                        return parametrs;
                    }
            }


            string name = parametrs[2].Substring(0, 1).ToUpper() + (parametrs[2].Length > 1 ? parametrs[2].Substring(1, parametrs[2].Length - 1) : "").ToLower();


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
            name = parametrs[3].Substring(0, 1).ToUpper() + (parametrs[3].Length > 1 ? parametrs[3].Substring(1, parametrs[3].Length - 1) : "").ToLower();

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

            parametrs[3] = name;
            parametrs[0] = "1";
            return parametrs;
        }
    }
}
