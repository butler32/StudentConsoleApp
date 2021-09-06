using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp
{
    class Student
    {
        public string name { get; private set; }
        public string surname { get; private set; }
        public string gender { get; private set; }
        public int age { get; private set; }
        public int id { get; set; }
        public Student(string name, string surname, string gender, int age)
        {
            this.name = Mapper.NameMap(name); ;
            this.surname = Mapper.NameMap(surname);
            this.gender = Mapper.GenderMap(gender);
            this.age = age;
        }

        public Student()
        {
        }
        
        public static string ToString(Student student)
        {
            return $"Студент с id {student.id}: Имя - {student.name}, " +
                    $"Фамилия - {student.surname}, " +
                    $"Пол - {student.gender}, " +
                    $"Возраст - {student.age}\n";
        }
    }
}