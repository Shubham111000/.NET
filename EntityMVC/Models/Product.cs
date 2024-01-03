using System.ComponentModel.DataAnnotations.Schema;

namespace EntityMVC.Models
{
    public class Product
    {
        public int  ProductId {  get; set; }
        public string ProductName { get; set; }

        [ForeignKey("CompanyId")]
        public int?  CompanyId {  get; set; }
        public Company? Company { get; set; }     

    }
}
