using Kodlama.io.Business.Abstracts;
using Kodlama.io.Business.Dtos.Requests.Course;
using Kodlama.io.Business.Dtos.Responses.Instructor;
using Microsoft.AspNetCore.Mvc;

namespace Kodlama.io.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {

        private readonly IInstructorService _instructorService;

        public InstructorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            GetAllInstructorResponse getAllInstructorResponse = new GetAllInstructorResponse();
            return Ok(getAllInstructorResponse);
        }

        [HttpPost]
        public IActionResult Add(CreateInstructorRequest createInstructorRequest)
        {
            CreatedInstructorResponse createdInstructorResponse = _instructorService.Add(createInstructorRequest);
            return Ok(createdInstructorResponse);

        }

        [HttpPut]
        public IActionResult Update(UpdateInstructorRequest updateInstructorRequest)
        {
            UpdatedInstructorResponse updatedInstructorResponse = _instructorService.Update(updateInstructorRequest);
            return Ok(updatedInstructorResponse);
        }

        [HttpDelete]
        public IActionResult Delete(DeleteInstructorRequest deleteInstructorRequest)
        {
            DeletedInstructorResponse deletedInstructorResponse = _instructorService.Delete(deleteInstructorRequest);
            return Ok(deletedInstructorResponse);
        }
    }
}
