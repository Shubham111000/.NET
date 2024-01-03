using System.ComponentModel.DataAnnotations;

namespace EntityMVC.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public String Name { set; get; }
        public ICollection<Product> products { get; set; }

    }
}
