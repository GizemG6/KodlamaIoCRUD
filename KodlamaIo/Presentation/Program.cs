using KodlamaIo.Business.Abstract;
using KodlamaIo.Business.Concrete;
using KodlamaIo.DataAccess.Concrete;
using KodlamaIo.Entities;

IGenericService<Category> _categoryService = new GenericService<Category>(new CategoryDal());
IGenericService<Course> _courseService = new GenericService<Course>(new CourseDal());
IGenericService<Instructor> _instructorService = new GenericService<Instructor>(new InstructorDal());

Category addedCategory = new Category { Id = 3, Name = "Yapay Zeka" };
Course updateCourse = new Course { Id = 4 };

//kategori ekleme
_categoryService.Add(addedCategory);

foreach (var category in _categoryService.GetAll())
{
    Console.WriteLine($"{category.Id}: {category.Name}");
}

//kurs güncelleme
updateCourse.Description = "C# Temel";
_courseService.Update(updateCourse);

foreach (var course in _courseService.GetAll())
{
    Console.WriteLine($"{course.Id}: {course.Name} - {course.Description}");
}

//eğitmen silme
_instructorService.Delete(3);

foreach (var instructor in _instructorService.GetAll())
{
    Console.WriteLine($"{instructor.Id}: {instructor.Name} {instructor.Surname}");
}