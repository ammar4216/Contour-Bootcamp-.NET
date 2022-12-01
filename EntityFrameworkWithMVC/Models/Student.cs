using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day_18___EntityFrameworkWithMVC.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column("varchar")]
        public string Name { get; set; }

        public int? Age { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
