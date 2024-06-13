using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Student
    {
        private static int idCounter = 1;
        public int Id { get; private set; }
        public string Fullname { get; set; }
        public double Point { get; set; }

        public Student(string fullname, double point)
        {
            this.Id = idCounter++;
            this.Fullname = fullname;
            this.Point = point;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"ID: {Id}, Fullname: {Fullname}, Point: {Point}");
        }
    }
}
