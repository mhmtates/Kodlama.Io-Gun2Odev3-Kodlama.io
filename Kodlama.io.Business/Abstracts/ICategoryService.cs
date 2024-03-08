using Kodlama.io.Business.Dtos.Requests.Category;
using Kodlama.io.Business.Dtos.Responses.Category;

namespace Kodlama.io.Business.Abstracts
{
    public interface ICategoryService
    {
       
       List<GetAllCategoryResponse> GetAll();

       CreatedCategoryResponse Add(CreateCategoryRequest createCategoryRequest); 
        
       UpdatedCategoryResponse Update(UpdateCategoryRequest updateCategoryRequest);

       DeletedCategoryResponse Delete(DeleteCategoryRequest deleteCategoryRequest);

   }
}
