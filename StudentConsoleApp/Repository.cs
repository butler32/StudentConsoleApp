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
        int id = 1;

        public int Add(Student student)
        {
            for (int i = 0; i < 10; i++)
            {
                if (students[i] is null)
                {
                    students[i] = student;
                    students[i].id = id;
                    return id++;
                }
            }
            return 0;
        }

        public Student Get(int id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                    if (students[i].id == id)
                        return students[i];
            }
            return null;

        }

        public void Delete(int id)
        {
            students[id] = null;
        }

        public int Edit(int id, Student student)
        {
            for (int i = 0; i < 10; i++)
            {
                if (students[i] != null && students[i].id == id)
                {
                    int oldId = students[i].id;
                    students[i] = student;
                    students[i].id = oldId;
                    return id;
                }
            }
            return 0;
        }

        public Student[] Find(string name)
        {
            Student[] studentsSearch = new Student[10];
            for (int i = 0, j = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    if (students[i].name.Contains(name, StringComparison.OrdinalIgnoreCase) ||
                    students[i].surname.Contains(name, StringComparison.OrdinalIgnoreCase))
                    {
                        studentsSearch[j] = students[i];
                        j++;
                        continue;
                    }
                }
            }
            return studentsSearch;
        }

        public Student[] List()
        {
            return students;
        }

        // *****
    }
}