using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIDemo.Model
{
    [Table("Product")]  // mapping of table product with class product
    public class Product
    {
        [Key]  // primary key col
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

    }
}
