using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public Student(string name, string surname, string gender, int age)
        {
            Name = Mapper.NameMap(name); ;
            Surname = Mapper.NameMap(surname);
            Gender = Mapper.GenderMap(gender);
            Age = age;
        }

        public Student()
        {
        }
        
        public static string ToString(Student student)
        {
            return $"Студент с id {student.Id}: Имя - {student.Name}, " +
                    $"Фамилия - {student.Surname}, " +
                    $"Пол - {student.Gender}, " +
                    $"Возраст - {student.Age}\n";
        }
    }
}