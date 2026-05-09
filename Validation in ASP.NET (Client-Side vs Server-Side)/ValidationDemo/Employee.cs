using System.ComponentModel.DataAnnotations;

namespace ValidationDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Full Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 characters.")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Range(18, 65, ErrorMessage = "Age must be between 18 and 65.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Salary is required.")]
        [Range(0.01, 1000000, ErrorMessage = "Salary must be a positive value.")]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
    }
}
