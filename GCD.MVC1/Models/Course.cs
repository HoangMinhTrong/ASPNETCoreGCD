using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCD.MVC1.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int categoryid { get; set; }
        public Category Category { get; set; }
    }
}
