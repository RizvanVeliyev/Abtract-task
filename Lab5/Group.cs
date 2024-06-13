using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab5
{
    class Group
    {
        public string GroupNo { get; private set; }
        public int StudentLimit { get; private set; }
        private Student[] Students;
        private int studentCount;

        public Group(string groupNo, int studentLimit)
        {
            if (!CheckGroupNo(groupNo)) Console.WriteLine("yalnis qrup nomresi");
            if (studentLimit < 5 || studentLimit > 18) Console.WriteLine("5-18 araliginda olmalidir");

            this.GroupNo = groupNo;
            this.StudentLimit = studentLimit;
            this.Students = new Student[studentLimit];
            this.studentCount = 0;
        }

        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length != 5) return false;
            if (!char.IsUpper(groupNo[0]) || !char.IsUpper(groupNo[1])) return false;
            for (int i = 2; i < 5; i++)
            {
                if (!char.IsDigit(groupNo[i])) return false;
            }
            return true;
        }

        public void AddStudent(Student student)
        {
            if (studentCount >= StudentLimit)
                Console.WriteLine("limite catdi");
            Students[studentCount++] = student;
        }

        public Student GetStudent(int id)
        {
            for (int i = 0; i < studentCount; i++)
            {
                if (Students[i].Id == id)
                    return Students[i];
            }
            return null;
        }

        public Student[] GetAllStudents()
        {
            Student[] currentStudents = new Student[studentCount];
            Array.Copy(Students, currentStudents, studentCount);
            return currentStudents;
        }
    }


}
