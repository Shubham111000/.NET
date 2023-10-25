using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Student
    {
        string name;
        int maths;
        int eng;
        int sci;
        int total;
        public Student(string name, int maths, int eng, int sci)
        {
            this.name = name;
            this.maths = maths;
            this.eng = eng;
            this.sci = sci;

        }
        public int TotalMarks()
        {
            this.total = maths + eng + sci;
            return total;
        }

        public void disp()
        {
            Console.WriteLine($"name = {name} total = {TotalMarks()} ");
        }
    }
}
