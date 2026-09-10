using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC_LINQ_EF_Core.Models
{
    [Table("Employee_EF")]
    public class Employee
    {
       

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Employee Name")]
        public string ename { get; set; }

        public int? Age { get; set; }

        public int? salary { get; set; }

        [StringLength(20)]
        public string Department { get; set; }

        public int? Manager_Id { get; set; }

        [StringLength(30)]
        [EmailAddress]
        [Display(Name = "Email ID")]
        public string Email_Id { get; set; }


    }
}
