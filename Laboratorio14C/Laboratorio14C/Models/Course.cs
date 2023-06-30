using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio14C.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Credit { get; set; }
        public DateTime StartDate { get; set; }
    }
}
