using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Dtos.Responses.Course
{
    public class UpdatedCourseResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string PriceInfo { get; set; }

    
       
        public DateTime? UpdatedDate { get; set; }
    }
}
