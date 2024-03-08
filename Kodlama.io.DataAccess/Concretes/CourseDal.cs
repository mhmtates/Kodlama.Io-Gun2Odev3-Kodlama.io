using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.Entities.Concretes;
using static System.Net.WebRequestMethods;

namespace Kodlama.io.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses = new List<Course>();

        public CourseDal()
        {
            _courses =
            [
                new Course
                {
                    Id = 1,
                    Name = "Senior Yazılım Geliştirici Yetiştirme Kampı(.NET)",
                    Description = "Senior Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
                    //Image = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz",
                    PriceInfo = "ÜCRETSİZ",
                    CreatedDate = DateTime.Now

                },
                new Course
                {
                    Id = 2,
                    Name = "2024 - Yazılım Geliştirici Yetiştirme Kampı C#",
                    Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
                    PriceInfo = "ÜCRETSİZ",
                    CreatedDate = DateTime.Now,
                },
                new Course
                {
                    Id = 3,
                    Name = "2023 - Yazılım Geliştirici Yetiştirme Kampı(Python&Selenium)",
                    Description = "Python&Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
                    PriceInfo = "ÜCRETSİZ",
                    CreatedDate = DateTime.Now,
                },
                new Course
                {
                    Id = 4,
                    Name = "2022 - Yazılım Geliştirici Yetiştirme Kampı(Java)",
                    Description = "Java Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
                    PriceInfo = "ÜCRETSİZ",
                    CreatedDate = DateTime.Now,
                },
                 new Course
                {
                    Id = 5,
                    Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",
                    Description = "1.5 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
                    PriceInfo = "ÜCRETSİZ",
                    CreatedDate = DateTime.Now,
                },


                 new Course
                {
                    Id = 6,
                    Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA+REACT)",
                    Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
                    PriceInfo = "ÜCRETSİZ",
                    CreatedDate = DateTime.Now,
                },
                 new Course
                {
                    Id = 7,
                    Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
                    Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
                    PriceInfo = "ÜCRETSİZ",
                    CreatedDate = DateTime.Now,
                },

                  new Course
                {
                    Id = 8,
                    Name = "Programlamaya Giriş İçin Temel Kurs",
                    Description = "PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin.",
                    PriceInfo = "ÜCRETSİZ",
                    CreatedDate = DateTime.Now,
                },
            ];


        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Delete(Course course)
        {
           _courses.Remove(course);
        }

        public void Update(Course course)
        {
            
        }
    }
}
