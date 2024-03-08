namespace Kodlama.io.Business.Dtos.Responses.Category
{
    public class DeletedCategoryResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? DeletedDate { get; set; }
    }
}
