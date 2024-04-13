using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Labb1_LINQ.Models
{
    internal class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set;}

        public int HeadTeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}
