using Kodlama.io.Business.Abstracts;
using Kodlama.io.Business.Dtos.Requests.Category;
using Kodlama.io.Business.Dtos.Responses.Category;
using Microsoft.AspNetCore.Mvc;

namespace Kodlama.io.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            GetAllCategoryResponse getAllCategoryResponse = new GetAllCategoryResponse();
            return Ok(getAllCategoryResponse);
        }

        [HttpPost]
        public IActionResult Add(CreateCategoryRequest createCategoryRequest)
        {
            CreatedCategoryResponse createdCategoryResponse = _categoryService.Add(createCategoryRequest);
            return Ok(createdCategoryResponse);

        }

        [HttpPut]
        public IActionResult Update(UpdateCategoryRequest updateCategoryRequest)
        {
            UpdatedCategoryResponse updatedCategoryResponse = _categoryService.Update(updateCategoryRequest);
            return Ok(updatedCategoryResponse);
        }

        [HttpDelete]
        public IActionResult Delete(DeleteCategoryRequest deleteCategoryRequest)
        {
            DeletedCategoryResponse deletedCategoryResponse = _categoryService.Delete(deleteCategoryRequest);
            return Ok(deletedCategoryResponse);
        }
    }
}
