using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp
{
    class Student
    {
        public string name;
        public string surname;
        public string gender;
        public int age;
        public int id;
        public Student(string name, string surname, string gender, int age)
        {
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.age = age;
        }
    }
}
