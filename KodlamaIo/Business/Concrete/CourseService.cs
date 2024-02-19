using KodlamaIo.Business.Abstract;
using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Concrete
{
    public class CourseService : GenericService<Course>, ICourseService
    {
        public CourseService(IGenericDal<Course> genericDal) : base(genericDal)
        {
        }
    }
}
