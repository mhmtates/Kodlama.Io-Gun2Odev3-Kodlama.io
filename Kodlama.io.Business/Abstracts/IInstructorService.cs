using Kodlama.io.Business.Dtos.Requests.Course;
using Kodlama.io.Business.Dtos.Responses.Instructor;

namespace Kodlama.io.Business.Abstracts
{
    public interface IInstructorService
    {
        List<GetAllInstructorResponse> GetAll();
        CreatedInstructorResponse Add(CreateInstructorRequest createInstructorRequest);

        UpdatedInstructorResponse Update(UpdateInstructorRequest updateInstructorRequest);

        DeletedInstructorResponse Delete(DeleteInstructorRequest deleteInstructorRequest);

    }
}
