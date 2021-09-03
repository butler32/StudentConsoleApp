using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp.Validators
{
    class BaseValidator
    {
        protected string[] parametrs;
        public BaseValidator(string[] parametrs)
        {
            this.parametrs = parametrs;
        }

        protected static int NullValidate(string[] parametrs)
        {
            for (int i = 0; i < parametrs.Length - 1; i++)
            {
                if (parametrs[i] == null)
                {
                    return 2;
                }
            }
            return 1;
        }

        protected static int AgeValidate(string parametr)
        {
            int age;
            bool result = int.TryParse(parametr, out age);
            if (!result)
            {
                return 3;
            }
            else
            {
                if (age < 18 || age > 99)
                {
                    return 7;
                }
            }
            return 1;
        }

        protected static int GenderValidate(string parametr)
        {
            if (parametr == "М" || parametr == "Ж" || parametr == "муж" || parametr == "жен" || parametr == "мужской" || parametr == "женский")
            {
                return 1;
            }
            else
            {
                return 4;
            }
        }

        protected static int NameValidate(string parametr)
        {
            if (parametr.Length > 50)
            {
                return 5;
            }

            for (int i = 0; i < parametr.Length; i++)
            {
                if (char.IsDigit(parametr[i]))
                {
                    return 6;
                }
            }

            return 1;
        }

        protected static int IdValidate(string parametr)
        {
            int intCheck;
            bool result = int.TryParse(parametr, out intCheck);
            if (!result)
            {
                return 3;
            }
            return 1;
        }
    }
}
