using System.ComponentModel.DataAnnotations;

namespace EmployeeManagerApp.Models
{
    public class Employee
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public decimal Salary { get; set; }
    }
}
