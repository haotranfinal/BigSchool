using lab3_TranVanHao_2011065143.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3_TranVanHao_2011065143.ViewModels
{
    public class CustomViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}