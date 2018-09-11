using PieShop.Data;
using PieShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public List<Pie> piebalds = new List<Pie>() {
            new Pie { Category =  }
        }

        public IEnumerable<Pie> GetPies() {
            return new List<Pie>() {
                new Pie { Id = 1, Name = "Apple Pie", Price = 12.95M, IsPieOfTheWeek = true, ShortDescription = "Yummy Apple Pie", LongDescription = "Lengthy apple pie", ImageThumbnailUrl = "images/thumbs/apple.jpg", ImageUrl = "images/apple.jpg", CategoryId = 1, Category = _categoryRepository.Categories.ToList()[0] },
                new Pie { Id = 2, Name = "Rhubarb Pie", Price = 11.95M, IsPieOfTheWeek = false, ShortDescription = "Yummy Rhubarb Pie", LongDescription = "Lengthy Rhubarb pie", ImageThumbnailUrl = "images/thumbs/Rhubarb.jpg", ImageUrl = "images/Rhubarb.jpg", CategoryId = 1, Category = _categoryRepository.Categories.ToList()[0]},
                new Pie { Id = 3, Name = "Cheesecake", Price = 8.95M, IsPieOfTheWeek = false, ShortDescription = "Yummy Cheesecake Pie", LongDescription = "Lengthy Cheesecake pie", ImageThumbnailUrl = "images/thumbs/Cheesecake.jpg", ImageUrl = "images/Cheesecake.jpg", CategoryId = 2, Category = _categoryRepository.Categories.ToList()[1]},
                new Pie { Id = 4, Name = "Chocolate Cake", Price = 4.95M, IsPieOfTheWeek = false, ShortDescription = "Yummy Chocolate Pie", LongDescription = "Lengthy Chocolate pie", ImageThumbnailUrl = "images/thumbs/Chocolate.jpg", ImageUrl = "images/Chocolate.jpg", CategoryId = 3, Category = _categoryRepository.Categories.ToList()[2]},
                new Pie { Id = 5, Name = "Mince Beef", Price = 6.99M, IsPieOfTheWeek = false, ShortDescription = "Yummy Mince Beef Pie", LongDescription = "Lengthy Mince Beef pie", ImageThumbnailUrl = "images/thumbs/Beef.jpg", ImageUrl = "images/Beef.jpg", CategoryId = 3, Category = _categoryRepository.Categories.ToList()[2]}
            };
        }
        public Pie GetPieById(int pieId)
        {
            throw new System.NotImplementedException();
        }

        
    }
}
