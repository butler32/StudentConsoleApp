using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp.Validators
{
    class BaseValidator
    {
        private string[] parametrs;
        public BaseValidator(string[] parametrs)
        {
            this.parametrs = parametrs;
        }

        public static int OneParametrNullValidate(string parametr)
        {
            if (parametr == null)
                return 1;
            return 0;
        }

        public static int PathValidate(string parametr)
        {
            string[] path = parametr.Split('.');
            if (path[path.Length - 1] != "json")
            {
                return 128;
            }
            return 0;
        }

        public static int NullValidate(string[] parametrs)
        {
            for (int i = 0; i < parametrs.Length - 1; i++)
            {
                if (parametrs[i] == null)
                {
                    return 1;
                }
            }
            return 0;
        }

        public static int AgeValidate(string parametr)
        {
            int age;
            bool result = int.TryParse(parametr, out age);
            if (!result)
            {
                return 2;
            }
            else
            {
                if (age < 18 || age > 99)
                {
                    return 32;
                }
            }
            return 0;
        }

        public static int GenderValidate(string parametr)
        {
            if (parametr == "М" || parametr == "Ж" || parametr == "муж" || parametr == "жен" || parametr == "мужской" || parametr == "женский")
            {
                return 0;
            }
            else
            {
                return 4;
            }
        }

        public static int NameValidate(string parametr)
        {
            if (parametr.Length > 50)
            {
                return 8;
            }

            for (int i = 0; i < parametr.Length; i++)
            {
                if (char.IsDigit(parametr[i]))
                {
                    return 16;
                }
            }

            return 0;
        }

        public static int IdValidate(string parametr)
        {
            int intCheck;
            bool result = int.TryParse(parametr, out intCheck);
            if (!result)
            {
                return 2;
            }
            return 0;
        }
    }
}
