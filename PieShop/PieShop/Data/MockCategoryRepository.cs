using PieShop.Interfaces;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Data
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories {
            get {
                return new List<Category>
                {
                    new Category { CategoryId = 1, CategoryName = "Fruit Pies", Description = "All fruity pies"},
                    new Category { CategoryId = 2, CategoryName = "Cheesecakes", Description = "Cheesecakes to make your heart sing"},
                    new Category { CategoryId = 3, CategoryName = "Seasonal Pies", Description = "Christmas, Halloween or Spring"}
                };
            }
        }
    }
}
