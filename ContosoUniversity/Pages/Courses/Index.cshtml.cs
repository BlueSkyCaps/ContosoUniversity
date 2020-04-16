using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace ContosoUniversity.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ContosoUniversity.Data.SchoolContext _context;

        public IndexModel(ContosoUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }
        // public IList<CourseViewModel> Course { get;set; } // 也可以使用视图模型获取课程

        public async Task OnGetAsync()
        {
            Course = await _context.Courses
                .Include(c => c.Department).AsNoTracking().ToListAsync();
            
            // 以下方式使用视图模型:
            //Course = await _context.Courses
            //.Select(p => new CourseViewModel
            //{
            //    CourseID = p.CourseID,
            //    Title = p.Title,
            //    Credits = p.Credits,
            //    Department = p.Department
            //}).ToListAsync();
        }
    }
}

//public class CourseViewModel
//{
//    public int CourseID { get; set; }
//    public string Title { get; set; }
//    public int Credits { get; set; }
//    public Department Department { get; set; }
//}