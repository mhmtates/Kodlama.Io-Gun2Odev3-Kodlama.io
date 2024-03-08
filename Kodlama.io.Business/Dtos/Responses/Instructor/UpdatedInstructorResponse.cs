using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Dtos.Responses.Instructor
{
    public class UpdatedInstructorResponse
    {
        public int Id { get; set; }

        public string FirstName { get; set; }


        public string LastName { get; set; }


        public DateTime? UpdatedDate{ get; set; }

    }
}
