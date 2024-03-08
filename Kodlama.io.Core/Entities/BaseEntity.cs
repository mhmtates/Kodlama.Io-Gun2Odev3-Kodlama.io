using System.Runtime.InteropServices;

namespace Kodlama.io.Core.Entities
{
    public class BaseEntity<T> where T : class,new()
    {
        public int Id { get; set; }

        public DateTime CreatedDate{ get; set; }

        public DateTime? UpdatedDate{ get; set; }

        public DateTime? DeletedDate{ get; set; }

    }
}
