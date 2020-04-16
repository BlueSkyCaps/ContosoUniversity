using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; } // PK值由自己指定

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        public Department Department { get; set; }

        // 参与一门课程的学生数量不定，因此 Enrollments 导航属性是一个集合：
        public ICollection<Enrollment> Enrollments { get; set; }

        // 一门课程可能由多位讲师讲授，因此 CourseAssignments 导航属性是一个集合：
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}