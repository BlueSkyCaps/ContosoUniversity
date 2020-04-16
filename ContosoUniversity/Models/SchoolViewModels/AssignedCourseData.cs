namespace ContosoUniversity.Models.SchoolViewModels
{
    // 包含的数据可用于为讲师已分配的课程创建复选框
    public class AssignedCourseData
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public bool Assigned { get; set; }
    }
}
