using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Entities
{
    public class Category : BaseEntity
    {
        public ICollection<Course> Courses { get; set; }
    }
}
