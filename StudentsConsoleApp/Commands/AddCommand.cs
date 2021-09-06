﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp.Commands
{
    class AddComand : Command
    {
        public AddComand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
        }

        public override string Execute()
        {
            Student student = new Student(parametrs[1], parametrs[2], parametrs[3], int.Parse(parametrs[4]));
            int result = repository.Add(student);
            string res;
            _ = result != 0 ? res = $"Студент {student.surname} {student.name} добавлен" : res = "Не получилось добавить студента";
            return res;
        }
    }
}