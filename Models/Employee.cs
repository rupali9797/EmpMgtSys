using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmpMgtSys.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        [Key]
        public int Id { get; set; }
        
        

        [Required]

        [StringLength(40)]

        public string Name { get; set; }
        public int FieldExperience { get; set; }
        [MaxLength(13)]
        public string PhoneNumber { get; set; }
        //[Display(Name = "Date of birth")]
        //[DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        //[MyDate(ErrorMessage = "Back date entry not allowed")]

        public DateTime? BirthDate { get; set; }
        [ForeignKey("Departments")]
        public int DepartmentId { get; set; }

        public virtual Department Departments { get;  set; }
        
    }
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]


        public string Name { get; set; }
        
        public string Description { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}