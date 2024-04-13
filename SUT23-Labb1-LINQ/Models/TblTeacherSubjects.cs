using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Labb1_LINQ.Models
{
    internal class TblTeacherSubjects
    {
        [Key]
        public int TblTeacherSubjectId { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
