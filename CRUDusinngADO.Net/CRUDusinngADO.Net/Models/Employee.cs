using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDusinngADO.Net.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Employee Name is Required")]
        [DataType(DataType.Text)]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Salary is Required")]
        [Display(Name ="Employee Salary")]
        [Range(minimum:5000,maximum:50000)]
        public double Salary { get; set; }
    }
}
