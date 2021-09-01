using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp.Validators
{
    abstract class Validator
    {
        protected string[] parametrs;
        public Validator(string[] parametrs)
        {
            this.parametrs = parametrs;
        }

        public abstract string[] Validate();
    }
}
