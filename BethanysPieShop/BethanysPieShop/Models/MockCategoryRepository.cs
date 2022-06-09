using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        { 
        new Category {CategoryTd = 1 ,CategoryName ="Frut Pies",Description="All Fruit Pies"},
         new Category {CategoryTd = 2 ,CategoryName ="Cheese Cakes",Description="Cheesy All The way"},
         new Category {CategoryTd = 3 ,CategoryName ="Seasonal pies",Description="Get In The Mood Of A Season Pie"}
        };
    }
}
 