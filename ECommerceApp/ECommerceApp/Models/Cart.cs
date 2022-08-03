using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceApp.Models
{
    [Table("Cart")]
    //[Table("Users")]
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
