using Kodlama.io.Business.Abstracts;
using Kodlama.io.Business.Dtos.Requests.Course;
using Kodlama.io.Business.Dtos.Responses.Course;
using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.Entities.Concretes;

namespace Kodlama.io.Business.Concretes
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public CreatedCourseResponse Add(CreateCourseRequest createCourseRequest)
        {
            Course course = new Course();
            course.Name = createCourseRequest.Name;
            course.CreatedDate = DateTime.Now;
            CreatedCourseResponse createdCourseResponse = new CreatedCourseResponse
            {
                Id = 2,
                Name = course.Name,
                Description = course.Description,
                PriceInfo = course.PriceInfo,
                CreatedDate = course.CreatedDate
            };
            return createdCourseResponse;
        }

        public DeletedCourseResponse Delete(DeleteCourseRequest deleteCourseRequest)
        {
            Course course = new Course();
            course.Name = deleteCourseRequest.Name;
            course.DeletedDate = DateTime.Now;
            DeletedCourseResponse deletedCourseResponse = new DeletedCourseResponse
            {
                Id = 1,
                Name = course.Name,
                Description = course.Description,
                PriceInfo = course.PriceInfo,
                DeletedDate = course.DeletedDate
            };
            return deletedCourseResponse;
        }

        public List<GetAllCourseResponse> GetAll()
        {
            List<Course> courses= new List<Course>();
            List<GetAllCourseResponse> getAllCourseResponses = new List<GetAllCourseResponse>();
            foreach (Course course in courses)
            {
                GetAllCourseResponse getAllCourseResponse = new GetAllCourseResponse
                {
                    Id = course.Id,
                    Name = course.Name,
                    Description = course.Description,
                    PriceInfo = course.PriceInfo,
                    CreatedDate = course.CreatedDate
                };
                getAllCourseResponses.Add(getAllCourseResponse);

            }

            return getAllCourseResponses;
        }

        public UpdatedCourseResponse Update(UpdateCourseRequest updateCourseRequest)
        {
            Course course = new Course();
            course.Name = updateCourseRequest.Name;
            course.UpdatedDate = DateTime.Now;
            UpdatedCourseResponse updatedCourseResponse = new UpdatedCourseResponse
            {
                Id = 1,
                Name = course.Name,
                Description = course.Description,
                PriceInfo = course.PriceInfo,
                UpdatedDate = course.UpdatedDate
            };
            return updatedCourseResponse;
        }
    }
}

