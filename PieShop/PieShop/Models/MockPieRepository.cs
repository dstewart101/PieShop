using PieShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class MockPieRepository : IPieRepository
    {

        private List<Pie> pies = new List<Pie>() {
            new Pie { Id = 1, Name = "Apple Pie", Price = 12.95M, IsPieOfTheWeek = true, ShortDescription = "Yummy Apple Pie", LongDescription = "Lengthy apple pie", ImageThumbnailUrl = "images/thumbs/apple.jpg", ImageUrl = "images/apple.jpg"},
            new Pie { Id = 2, Name = "Rhubarb Pie", Price = 11.95M, IsPieOfTheWeek = false, ShortDescription = "Yummy Rhubarb Pie", LongDescription = "Lengthy Rhubarb pie", ImageThumbnailUrl = "images/thumbs/Rhubarb.jpg", ImageUrl = "images/Rhubarb.jpg"},
            new Pie { Id = 3, Name = "Cheesecake", Price = 8.95M, IsPieOfTheWeek = false, ShortDescription = "Yummy Cheesecake Pie", LongDescription = "Lengthy Cheesecake pie", ImageThumbnailUrl = "images/thumbs/Cheesecake.jpg", ImageUrl = "images/Cheesecake.jpg"},
            new Pie { Id = 4, Name = "Chocolate Cake", Price = 4.95M, IsPieOfTheWeek = false, ShortDescription = "Yummy Chocolate Pie", LongDescription = "Lengthy Chocolate pie", ImageThumbnailUrl = "images/thumbs/Chocolate.jpg", ImageUrl = "images/Chocolate.jpg"},
            new Pie { Id = 5, Name = "Mince Beef", Price = 6.99M, IsPieOfTheWeek = false, ShortDescription = "Yummy Mince Beef Pie", LongDescription = "Lengthy Mince Beef pie", ImageThumbnailUrl = "images/thumbs/Beef.jpg", ImageUrl = "images/Beef.jpg"}
        };

        public IEnumerable<Pie> GetPies()
        {
            return pies.OrderBy(p => p.Id);
        }
        public Pie GetPieById(int pieId)
        {
            return pies.FirstOrDefault(p => p.Id == pieId);
        }

        
    }
}
