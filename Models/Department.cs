using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CodegraphiaTesting.Models
{
    [Table("Department",Schema ="dbo")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Department Id")]
        public int DepartmentId { get; set; }
        [Required]
        [Column("varchar(100)")]
        [Display(Name ="Department Name")]
        public string DepartmentName {  get; set; }
        [Required]
        [Display(Name ="Department Abbreviation")]
        [Column("varchar(10")]
        public string DepartmentAbbr { get; set; }

    }
}
