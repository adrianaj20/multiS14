using Laboratorio14C.DataContext;
using Laboratorio14C.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Laboratorio14C.Services
{
    public class CourseService
    {
        private readonly AppDbContext _context;

        public CourseService() => _context = App.GetContext();

        public bool Create(Course item)
        {
            try
            {
                _context.Courses.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateRange(List<Course> items)
        {
            try
            {
                _context.Courses.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Course> Get()
        {
            return _context.Courses.ToList();
        }

        public List<Course> GetByText(string text)
        {
            return _context.Courses.Where(x => x.Name.Contains(text)).ToList();
        }
    }
}
