using Kodlama.io.Business.Abstracts;
using Kodlama.io.Business.Dtos.Requests.Category;
using Kodlama.io.Business.Dtos.Requests.Course;
using Kodlama.io.Business.Dtos.Responses.Category;
using Kodlama.io.Business.Dtos.Responses.Course;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kodlama.io.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {

        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            GetAllCourseResponse getAllCourseResponse = new GetAllCourseResponse();
            return Ok(getAllCourseResponse);
        }

        [HttpPost]
        public IActionResult Add(CreateCourseRequest createCourseRequest)
        {
            CreatedCourseResponse createdCourseResponse = _courseService.Add(createCourseRequest);
            return Ok(createdCourseResponse);

        }

        [HttpPut]
        public IActionResult Update(UpdateCourseRequest updateCourseRequest)
        {
            UpdatedCourseResponse updatedCourseResponse = _courseService.Update(updateCourseRequest);
            return Ok(updatedCourseResponse);
        }

        [HttpDelete]
        public IActionResult Delete(DeleteCourseRequest deleteCourseRequest)
        {
            DeletedCourseResponse deletedCourseResponse = _courseService.Delete(deleteCourseRequest);
            return Ok(deletedCourseResponse);
        }
    }
}
