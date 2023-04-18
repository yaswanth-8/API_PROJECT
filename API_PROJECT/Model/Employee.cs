using System.ComponentModel.DataAnnotations;

namespace API_PROJECT.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int Phno { get; set;}
    }
}
