﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp.Commands
{
    class FindCommand : Command
    {
        public FindCommand(Repository repository, string[] parametrs) : base(repository, parametrs)
        {
        }

        public override string Execute()
        {
            parametrs[1] = Mapper.NameMap(parametrs[1]);
            Student[] student = repository.Find(parametrs[1]);
            if (student[0] == null)
                return "Студентов не найдено";
            StringBuilder findStudent = new StringBuilder("Найдены студенты:\n");
            for (int i = 0; i < student.Length; i++)
            {
                if (student[i] != null)
                {
                    findStudent.Append(Student.ToString(student[i]));
                }
            }
            return findStudent.ToString();
        }
    }
}