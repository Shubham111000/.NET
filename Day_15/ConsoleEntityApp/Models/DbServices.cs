using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleEntityApp.Models
{
    class DbServices
    {
        private readonly static StudentContext _studentContext = new StudentContext();
        public void Adddata(Student s)
        {
            Student student = new Student() { FirstName = "Mona", LastName = "Thak", DateOfBirth = new DateTime(1999, 12, 12, 0, 0, 0), Height = 5, Weight = 50, GradeId = 2 };
            _studentContext.Add<Student>(s);
            _studentContext.SaveChanges();

        }
        public void Display()
        {
            foreach (var r in _studentContext.Students)
                Console.WriteLine(r);

        }
        public void Delete(int id)
        {
            Student s = _studentContext.Students.SingleOrDefault<Student>((Stu) => Stu.StudentId == id);
            if (s != null)
            {
                _studentContext.Remove<Student>(s);
                _studentContext.SaveChanges();
            }
        }
        public List<Student> Customquery(string name)
        {
            FormattableString sql = $"SELECT * FROM Students WHERE FirstName ={name}";
            var studentlist = _studentContext.Students.FromSql<Student>(sql).ToList();
            return studentlist;


        }

        public void Liqdemo()
        {
            var r = _studentContext.Students.Join(_studentContext.Grades, (sg) => sg.GradeId, (gi) => gi.Id, (r, g) => new { Name = r.FirstName, Gradename = g.GradeName });
            foreach (var result in r)
            {
                Console.Write(result.Gradename + " ");
                Console.WriteLine(result.Name);

            }
        }
    }
   
}
