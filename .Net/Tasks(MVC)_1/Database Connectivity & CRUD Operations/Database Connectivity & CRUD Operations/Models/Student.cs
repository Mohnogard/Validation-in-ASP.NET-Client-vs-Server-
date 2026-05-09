using System.ComponentModel.DataAnnotations;

namespace Database_Connectivity___CRUD_Operations.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(0, 100)]
        public int Age { get; set; }
    }
}
