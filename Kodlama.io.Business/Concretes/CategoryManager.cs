using Kodlama.io.Business.Abstracts;
using Kodlama.io.Business.Dtos.Requests.Category;
using Kodlama.io.Business.Dtos.Responses.Category;
using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.Entities.Concretes;

namespace Kodlama.io.Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public CreatedCategoryResponse Add(CreateCategoryRequest createCategoryRequest)
        {
            Category category = new Category();
            category.Name = createCategoryRequest.Name;
            category.CreatedDate = DateTime.Now;
            CreatedCategoryResponse createdCategoryResponse = new CreatedCategoryResponse
            {
                Id = 2,
                Name = category.Name,
                CreatedDate = category.CreatedDate
            };
            return createdCategoryResponse;
        }

        public DeletedCategoryResponse Delete(DeleteCategoryRequest deleteCategoryRequest)
        {
            Category category = new Category();
            category.Name = deleteCategoryRequest.Name;
            category.DeletedDate = DateTime.Now;
            DeletedCategoryResponse deletedCategoryResponse = new DeletedCategoryResponse
            {
                Id = 1,
                Name = category.Name,
                DeletedDate = category.DeletedDate
            };
            return deletedCategoryResponse;
        }

        public List<GetAllCategoryResponse> GetAll()
        {
            List<Category> categories = new List<Category>();
            List<GetAllCategoryResponse> getAllCategoryResponses = new List<GetAllCategoryResponse>();
            foreach (Category category in categories)
            {
                GetAllCategoryResponse getAllCategoryResponse = new GetAllCategoryResponse
                {
                    Id = category.Id,
                    Name = category.Name,
                    CreatedDate = category.CreatedDate
                };
                getAllCategoryResponses.Add(getAllCategoryResponse);

            }

            return getAllCategoryResponses;
        }

        public UpdatedCategoryResponse Update(UpdateCategoryRequest updateCategoryRequest)
        {
            Category category = new Category();
            category.Name = updateCategoryRequest.Name;
            category.UpdatedDate = DateTime.Now;
            UpdatedCategoryResponse updatedCategoryResponse = new UpdatedCategoryResponse
            {
                Id = 1,
                Name = category.Name,
                UpdatedDate = category.UpdatedDate
            };
            return updatedCategoryResponse;
        }
    }
}
