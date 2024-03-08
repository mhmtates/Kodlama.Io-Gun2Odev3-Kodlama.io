using Kodlama.io.Core.Entities;

namespace Kodlama.io.Entities.Concretes
{
    public class Course:BaseEntity<Course>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string PriceInfo { get; set; }
        public Instructor Instructor { get; set; }
        public Category Category { get; set; }
    }
}
