using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.Entities.Concretes;

namespace Kodlama.io.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {

        List<Instructor> _instructors;
       

        public InstructorDal()
        {
            _instructors =
            [
                new Instructor
                    {
                    Id = 1,
                    FirstName = "Engin",
                    LastName = "Demiroğ",
                    CreatedDate = DateTime.Now
                   },
               new Instructor
                    {
                    Id = 2,
                    FirstName = "Halit Enes",
                    LastName = "Kalaycı",
                    CreatedDate = DateTime.Now
                   },
            ];

            
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            throw new NotImplementedException();
        }
    }
}
