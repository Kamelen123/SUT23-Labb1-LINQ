using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Labb1_LINQ.Models
{
    internal class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        [MaxLength(5)]
        public string CourseName { get; set; }
    }
}
