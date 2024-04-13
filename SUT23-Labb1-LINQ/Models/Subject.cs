using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Labb1_LINQ.Models
{
    internal class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        [Required]
        [MaxLength(50)]
        public string SubjectName { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }

    
}
