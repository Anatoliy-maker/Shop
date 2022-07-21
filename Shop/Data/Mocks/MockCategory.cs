using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public new IEnumerable<Category> Allcategories 
        { 
            get {
               return new List<Category> { 
                   new Category {CategoryName = "Электромобили", Description = "Современный вид транспорта" },
                   new Category {CategoryName = "Классические автомобили", Description = "Машины с двигателем внутреннего сгорания" }
               };
            }
        }
    }
}
