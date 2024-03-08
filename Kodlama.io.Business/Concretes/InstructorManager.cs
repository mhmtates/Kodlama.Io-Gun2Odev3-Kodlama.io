using Kodlama.io.Business.Abstracts;
using Kodlama.io.Business.Dtos.Requests.Course;
using Kodlama.io.Business.Dtos.Responses.Instructor;
using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.Entities.Concretes;

namespace Kodlama.io.Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public CreatedInstructorResponse Add(CreateInstructorRequest createInstructorRequest)
        {
            Instructor instructor = new Instructor();
            instructor.FirstName = createInstructorRequest.FirstName;
            instructor.LastName = createInstructorRequest.LastName;
            instructor.CreatedDate = DateTime.Now;
            CreatedInstructorResponse createdInstructorResponse = new CreatedInstructorResponse
            {
                Id = 2,
                FirstName = instructor.FirstName,
                LastName = instructor.LastName,
                CreatedDate = instructor.CreatedDate
            };
            return createdInstructorResponse;
        }

        public DeletedInstructorResponse Delete(DeleteInstructorRequest deleteInstructorRequest)
        {
            Instructor instructor = new Instructor();
            instructor.FirstName = deleteInstructorRequest.FirstName;
            instructor.LastName = deleteInstructorRequest.LastName;
            instructor.DeletedDate = DateTime.Now;
            DeletedInstructorResponse deletedInstructorResponse = new DeletedInstructorResponse
            {
                Id = 1,
                FirstName = instructor.FirstName,
                LastName = instructor.LastName,
                DeletedDate = instructor.DeletedDate
            };
            return deletedInstructorResponse;
        }

        public List<GetAllInstructorResponse> GetAll()
        {
            List<Instructor> instructors = new List<Instructor>();
            List<GetAllInstructorResponse> getAllInstructorResponses = new List<GetAllInstructorResponse>();
            foreach (Instructor instructor in instructors)
            {
                GetAllInstructorResponse getAllInstructorResponse = new GetAllInstructorResponse
                {
                    Id = instructor.Id,
                    FirstName = instructor.FirstName,
                    LastName = instructor.LastName,
                    CreatedDate = instructor.CreatedDate
                };
                getAllInstructorResponses.Add(getAllInstructorResponse);

            }

            return getAllInstructorResponses;
        }

        public UpdatedInstructorResponse Update(UpdateInstructorRequest updateInstructorRequest)
        {
            Instructor instructor = new Instructor();
            instructor.FirstName = updateInstructorRequest.FirstName;
            instructor.LastName = updateInstructorRequest.LastName;
            instructor.UpdatedDate = DateTime.Now;
            UpdatedInstructorResponse updatedInstructorResponse = new UpdatedInstructorResponse
            {
                Id = 1,
                FirstName = instructor.FirstName,
                LastName = instructor.LastName,
                UpdatedDate = instructor.UpdatedDate
            };
            return updatedInstructorResponse;
        }
    }
}
