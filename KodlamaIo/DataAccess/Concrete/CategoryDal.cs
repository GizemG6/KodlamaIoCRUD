using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        private readonly List<Category> _categories;

        public CategoryDal()
        {
            _categories = new List<Category>
            { 
                new Category{ Id = 1, Name = "Tümü"},
                new Category{ Id = 2, Name = "Programlama"}
            };
        }
        public void Add(Category entity)
        {
            _categories.Add(entity);
        }

        public void Delete(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
                _categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id) ?? throw new Exception("Category not found");
        }

        public void Update(Category entity)
        {
            var existingCategory = _categories.FirstOrDefault(c => c.Id == entity.Id);
            if (existingCategory != null)
            {
                existingCategory.Name = entity.Name;
            }
        }
    }
}
