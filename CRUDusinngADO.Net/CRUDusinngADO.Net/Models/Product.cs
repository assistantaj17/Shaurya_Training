using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDusinngADO.Net.Models
{
    [Table("Product")]      // database table name where the operation done
    public class Product
    {
        // POCO class (plain old c#/clr object)
        // BO - Business Object / Model class

        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Product Name is Required")]
        [DataType(DataType.Text)]
        [Display(Name="Product Name")]
        public string Pname { get; set; }

        [Required(ErrorMessage ="Price is Required")]
        [Display(Name ="Product Price")]
        [Range(minimum:1,maximum:50000)]
        public double Price { get; set; }
    }
}
