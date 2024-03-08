using Kodlama.io.Core.Entities;

namespace Kodlama.io.Entities.Concretes
{
    public class Instructor:BaseEntity<Instructor>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

    

        public virtual List<Course> Courses { get; set; }


    }
}
