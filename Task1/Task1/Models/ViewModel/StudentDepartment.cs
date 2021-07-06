using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task1.Models.ViewModel
{
    public class StudentDepartment
    {
        [Required(ErrorMessage = "Please enter your dept")]
        public int Dept_Id { get; set; }
        [Required(ErrorMessage = "Please enter your name here")]
        [MaxLength(30, ErrorMessage = "Max Length 30")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter DATE OF BIRTH")]
        public string DOB { get; set; }
        [Required]
        [Range(1, 148)]
        public int Credit { get; set; }
        [Required]
        public double CGPA { get; set; }

        public Department Department { get; set; }
        public Student Student { get; set; }
        public List<Department> Departments { get; set; }
        public List<Student> Students { get; set; }
        public StudentDepartment()
        {

            List<Department> Departments = new List<Department>();
        }
    }
}