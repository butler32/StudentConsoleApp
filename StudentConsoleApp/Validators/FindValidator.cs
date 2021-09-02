using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp.Validators
{
    class FindValidator : Validator
    {
        public FindValidator(string[] parametrs) : base (parametrs)
        {
        }

        public override string[] Validate()
        {
            if (parametrs[1] is null)
            {
                parametrs[6] = "2";
                return parametrs;
            }

            string name = parametrs[1].Substring(0, 1).ToUpper() + (parametrs[1].Length > 1 ? parametrs[1].Substring(1, parametrs[1].Length - 1) : "").ToLower();


            if (name.Length > 50)
            {
                parametrs[6] = "5";
                return parametrs;
            }

            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsDigit(name[i]))
                {
                    parametrs[6] = "6";
                    return parametrs;
                }
            }

            parametrs[1] = name;
            parametrs[6] = "1";
            return parametrs;
        }
    }
}
