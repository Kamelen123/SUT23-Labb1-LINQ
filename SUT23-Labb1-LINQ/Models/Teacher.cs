using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Labb1_LINQ.Models
{
    internal class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Subject> Subjects { get; set; }
    }
}
