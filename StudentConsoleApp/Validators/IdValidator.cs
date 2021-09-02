using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp.Validators
{
    class IdValidator : Validator
    {
        public IdValidator(string[] parametrs) : base (parametrs)
        {
        }

        public override string[] Validate()
        {
            if (parametrs[1] is null)
            {
                parametrs[6] = "2";
                return parametrs;
            }

            int intCheck;
            bool result = int.TryParse(parametrs[1], out intCheck);
            if (result is true)
                parametrs[6] = "1";
            else parametrs[6] = "3";
            return parametrs;
        }
    }
}
