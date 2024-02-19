using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        private readonly List<Course> _courses;
        public CourseDal() 
        {
            _courses = new List<Course>
            { new Course { Id = 1, Name = "C# 101", Description = "dgfdgf", categoryId = 1, instructorId = 1},
              new Course { Id = 2, Name = "Java", Description = "sdfgdfg", categoryId = 2, instructorId = 2}
            };
        }
        public void Add(Course entity)
        {
            _courses.Add(entity);
        }

        public void Delete(int id)
        {
            var course = _courses.FirstOrDefault(c => c.Id == id);
            if (course != null)
                _courses.Remove(course);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public Course GetById(int id)
        {
            return _courses.FirstOrDefault(c => c.Id == id) ?? throw new Exception("Course not found");
        }

        public void Update(Course entity)
        {
            var existingCourse = _courses.FirstOrDefault(c => c.Id == entity.Id);
            if (existingCourse != null)
            {
                existingCourse.Name = entity.Name;
                existingCourse.Description = entity.Description;
                existingCourse.categoryId = entity.categoryId;
                existingCourse.instructorId = entity.instructorId;
            }
        }
    }
}
