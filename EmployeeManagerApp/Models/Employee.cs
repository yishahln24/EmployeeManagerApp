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

        [Range(1,1000000)]
        public decimal Salary { get; set; }

        public decimal CalculateAnnualBonus()
        {
            if(Salary < 0)
            {
                throw new ArgumentException("Salary cannot be negative");
            }
            return Salary * 0.10m;
        }
    }
}
