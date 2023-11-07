using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEntityApp.Models
{
    public class Grade
    {
        [Key]
        public int Id { set; get; }
        public String? GradeName { set; get; }
        public String? Section { set; get; }
        [ForeignKey("GradeId")]
        public IList<Student> Student {set;get;}
    }
}
