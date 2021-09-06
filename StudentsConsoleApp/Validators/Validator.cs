/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp.Validators
{
    class Validator : BaseValidator
    {
        public Validator(string[] parametrs) : base (parametrs)
        {
        }

        public int Validate()
        {
            string[] str = new string[5];
            bool need = false;
            switch(parametrs[0]?.ToUpper())
            {
                case "ADD":
                    {
                        need = true;
                        for (int i = 0; i < 4; i++)
                        {
                            str[i] = parametrs[i + 1];
                        }

                        break;
                    }
                case "EDIT":
                    {
                        need = true;
                        for (int i = 0; i < 4; i++)
                        {
                            str[i] = parametrs[i + 2];
                        }

                        int res = Validator.IdValidate(parametrs[1]);
                        if (res != 1)
                            return res;
                        break;
                    }
                case "FIND":
                    {
                        if (parametrs[1] == null)
                        {
                            return 2;
                        }
                        return Validator.NameValidate(parametrs[1]);
                    }
                case "DELETE":
                case "GET":
                    {
                        if (parametrs[1] == null)
                        {
                            return 2;
                        }
                        return Validator.IdValidate(parametrs[1]);

                    }
            }

            if (need)
            {
                int result = Validator.NullValidate(str);
                if (result != 1)
                    return result;
                result = Validator.NameValidate(str[0]);
                if (result != 1)
                    return result;
                result = Validator.NameValidate(str[1]);
                if (result != 1)
                    return result;
                result = Validator.GenderValidate(str[2]);
                if (result != 1)
                    return result;
                result = Validator.AgeValidate(str[3]);
                return result;
            }
            return 1;
        }
    }
}
*/