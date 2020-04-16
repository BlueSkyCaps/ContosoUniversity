using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        // 一个系可能有也可能没有管理员
        public int? InstructorID { get; set; }

        // 管理员始终由讲师担任。 因此，InstructorID 属性作为到 Instructor 实体的 FK 包含在其中
        public Instructor Administrator { get; set; }
        
        // 一个系可以有多门课程，因此存在 Course 导航属性：
        public ICollection<Course> Courses { get; set; }
    }
}