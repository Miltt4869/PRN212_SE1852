using System.Collections.Generic;
using System.Linq;
using BusinessObjects;

namespace DataAccessLayer
{
    public static class CategoryDAO
    {
        private static readonly List<Category> Categories = new List<Category>();

        static CategoryDAO()
        {
            InitializeDataset();
        }

        private static void InitializeDataset()
        {
            if (!Categories.Any())
            {
                Categories.AddRange(new List<Category>
                {
                    new Category { CategoryID = 1, CategoryName = "Thức uống", Description = "Các loại nước: Cà phê, sting, 7up" },
                    new Category { CategoryID = 2, CategoryName = "Thức ăn", Description = "Hủ tíu, mì, bánh, kẹo " },
                    new Category { CategoryID = 3, CategoryName = "Áo", Description = "Áo sơ mi, áo dài, Áo croptop" }
                });
            }
        }

        public static List<Category> GetAllCategories()
        {
            return Categories;
        }

        public static Category? GetCategoryById(int id)
        {
            return Categories.FirstOrDefault(c => c.CategoryID == id);
        }
    }
}