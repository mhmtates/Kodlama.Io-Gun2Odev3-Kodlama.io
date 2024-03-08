using Kodlama.io.Entities.Concretes;

namespace Kodlama.io.DataAccess.Abstracts
{
    public interface IInstructorDal
    {

         List<Instructor> GetAll();

         void Add(Instructor instructor);

        void Update(Instructor instructor);

        void Delete(Instructor instructor);
    }
}
