using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Place { get; set; }

        [Required]
        public string Date { get; set; }

        [ValidTime]
        [Required]
        public string Time { get; set; }

        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Heading { get; set; }
        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }
        internal IQueryable<Course> UpcommingCourses;

        public IEnumerable<Course> UpcommingCourse { get; set; } 
        public bool ShowAction { get; set; }
    }
}