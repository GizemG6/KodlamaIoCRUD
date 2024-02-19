using KodlamaIo.Business.Abstract;
using KodlamaIo.Business.Concrete;
using KodlamaIo.DataAccess.Concrete;
using KodlamaIo.Entities;

IGenericService<Category> _categoryService = new GenericService<Category>(new CategoryDal());
IGenericService<Course> _courseService = new GenericService<Course>(new CourseDal());
IGenericService<Instructor> _instructorService = new GenericService<Instructor>(new InstructorDal());

Category category3 = new Category { Id = 3, Name = "Yapay Zeka" };

_categoryService.Add(category3);

foreach (var category in _categoryService.GetAll())
{
    Console.WriteLine($"{category.Id}: {category.Name}");
}