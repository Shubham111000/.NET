using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEntityApp.Models
{
    public class Student
    {
       //public String? ParentName {  get; set; }
       //public String? Email {  get; set; }

       //public String? Address { set; get; }
       //public String? Photo {  get; set; }
        public int StudentId { get; set; }
        public string? FirstName {  get; set; }
        public string? LastName { get; set;}
        public DateTime? DateOfBirth { get; set; }
        public  float? Weight { get; set; }
        public float? Height { get; set; }
        public Grade? Grade { get; set; }
        [ForeignKey("GradeId")]
        public int? GradeId { get; set; }
        public override string ToString()
        {
            return ($" StudentId={StudentId} FirstName={FirstName} lastName={LastName} DateOfBirth={DateOfBirth} Heigth={Height} Weight={Weight}");
        }



    }
}
