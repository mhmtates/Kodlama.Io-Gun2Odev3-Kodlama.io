using Kodlama.io.Business.Dtos.Requests.Course;
using Kodlama.io.Business.Dtos.Responses.Course;

namespace Kodlama.io.Business.Abstracts
{
    public interface ICourseService
    {
        List<GetAllCourseResponse> GetAll();

        CreatedCourseResponse Add(CreateCourseRequest createCourseRequest);

        UpdatedCourseResponse Update(UpdateCourseRequest updateCourseRequest);

        DeletedCourseResponse Delete(DeleteCourseRequest deleteCourseRequest);

    }
}
