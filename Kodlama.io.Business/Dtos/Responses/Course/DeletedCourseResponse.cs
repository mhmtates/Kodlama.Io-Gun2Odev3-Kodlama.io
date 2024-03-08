namespace Kodlama.io.Business.Dtos.Responses.Course
{
    public class DeletedCourseResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string PriceInfo { get; set; }

         public DateTime? DeletedDate { get; set; }
    }
}
