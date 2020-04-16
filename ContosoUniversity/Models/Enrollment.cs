using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    // 代表报名学生的年级
    public enum Grade
    {
        A, B, C, D, F
    }

    // 如果 Enrollment 表不包含年级信息，则它只需包含两个 FK（CourseID 和 StudentID）。
    // 无有效负载的多对多联接表有时称为纯联接表 (PJT)。
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}