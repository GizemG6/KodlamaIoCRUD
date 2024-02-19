using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Add(T entity);
        T GetById(int id);
        List<T> GetAll();
        void Update(T entity);
        void Delete(T entity);
    }
}
