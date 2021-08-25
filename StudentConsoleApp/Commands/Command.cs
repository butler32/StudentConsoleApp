﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp.Commands
{
    class Command
    {
        private string[] parametrs;
        protected Repository repository;

        public Command(Repository repository, string[] parametrs)
        {
            this.parametrs = parametrs;
            this.repository = repository;
        }

        public virtual string Execute()
        {
            return "Нечего делать!";
        }
    }
}