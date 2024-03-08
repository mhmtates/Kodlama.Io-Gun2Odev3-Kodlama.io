using Kodlama.io.Entities.Concretes;

namespace Kodlama.io.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        List<Category> GetAll();

        void Add(Category category);

        void Update(Category category);

        void Delete(Category category);

    }
}
