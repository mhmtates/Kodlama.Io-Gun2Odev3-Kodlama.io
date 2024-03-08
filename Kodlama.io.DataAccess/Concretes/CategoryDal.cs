using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.Entities.Concretes;

namespace Kodlama.io.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        public List<Category>_categories;
       
        public CategoryDal()
        {
            _categories = [new Category{Id = 1, Name = "Programlama", CreatedDate = DateTime.Now }];

        }

        public void Add(Category category)
        {

            _categories.Add(category);
            
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }

       
    }
}
