using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodegraphiaTesting.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Display(Name="Employee Name")]
        public string EmployeeName { get; set; }
        [Required]
        [Display(Name ="Employee Salary")]
        public double Salary { get; set; }
        public string EmployeeNumber { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        [NotMapped]
        public string DepartmentName { get; set; }
        public Department Department { get; set; }

    }
}
