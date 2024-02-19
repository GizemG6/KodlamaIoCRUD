using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        private readonly List<Instructor> _instructors;

        public InstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor{ Id = 1, Name = "Gizem", Surname = "Güneş"},
                new Instructor{ Id = 2, Name = "Mehmet", Surname = "Aslan"},
                new Instructor{ Id = 3, Name = "Pelin", Surname = "Coşkun"}
            };
        }
        public void Add(Instructor entity)
        {
            _instructors.Add(entity);
        }

        public void Delete(int id)
        {
            var instructor = _instructors.FirstOrDefault(i => i.Id == id);
            if (instructor != null)
                _instructors.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetById(int id)
        {
            return _instructors.FirstOrDefault(i => i.Id == id) ?? throw new Exception("Instructor not found");
        }

        public void Update(Instructor entity)
        {
            var existingInstructor = _instructors.FirstOrDefault(i => i.Id == entity.Id);
            if (existingInstructor != null)
            {
                existingInstructor.Name = entity.Name;
                existingInstructor.Surname = entity.Surname;
            }
        }
    }
}
