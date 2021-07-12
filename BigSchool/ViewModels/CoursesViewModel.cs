using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        internal IQueryable<Course> UpcommingCourses;

        public IEnumerable<Course> UpcommingCourse { get; set; } 
        public bool ShowAction { get; set; }
    }
}