using StudentConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp
{
    class Repository
    {
        public Student[] students = new Student[10];

        public void Add(Student student)
        {
            bool isAdded = false;
            for (int i = 0; i < 10; i++)
            {
                if (students[i] is null)
                {
                    students[i] = student;
                    isAdded = true;
                    break;
                }
            }

            if (!isAdded)
            {
                throw new ArgumentException("Список заполнен");
            }
        }

        public void Edit(Student student, int id)
        {
            students[id] = student;
        }

        public void Get(int id)
        {
            if (students[id] != null)
            {
                Console.Write($"Студент под номером {id}: " +
                $"Имя - {students[id].name}, " +
                $"Фамилия - {students[id].surname}, " +
                $"Пол - {students[id].gender}, " +
                $"Возраст - {students[id].age}");
            }
            else Console.WriteLine("Студента с таким номером не существует");

        }

        public void Delete(int id)
        {
            students[id] = null;
        }

        // *****
    }
}