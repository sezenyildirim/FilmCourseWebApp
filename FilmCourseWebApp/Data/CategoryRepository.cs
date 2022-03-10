using FilmCourseWebApp.Models;

namespace FilmCourseWebApp.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category(){Id=1, Name="Adventure"},
                new Category(){Id=2, Name="Sci-Fi"},
                new Category(){Id=3, Name="Comedy"},
                new Category(){Id=4, Name="Dram"},
                new Category(){Id=5, Name="Fantastic"}
            };
        }
        public static List<Category> Categories
        {
            get { return _categories; }
        }
        public static void AddCategory(Category entity)
        {
            _categories.Add(entity);
        }
        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }
    }
}
