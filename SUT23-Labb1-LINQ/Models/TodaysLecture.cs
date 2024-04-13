using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Labb1_LINQ.Models
{
    internal class TodaysLecture
    {
        [Key]
        public int LectureId { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int TblTeacherSubjectId { get; set; }
        public TblTeacherSubjects TblTeacherSubject { get; set; }


    }
}
