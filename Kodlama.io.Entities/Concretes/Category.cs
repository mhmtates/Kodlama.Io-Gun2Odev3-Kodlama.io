using Kodlama.io.Core.Entities;

namespace Kodlama.io.Entities.Concretes
{
    public class Category:BaseEntity<Category>
    {
         public string Name { get; set; }

         public virtual List<Course> Courses { get; set; }
    }
}
      