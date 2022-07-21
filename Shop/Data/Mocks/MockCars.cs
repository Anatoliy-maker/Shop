using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public new IEnumerable<Car> Cars 
        { 
            get 
            {
                return new List<Car> { 

                    new Car {
                    Name = "Tesla", 
                    ShortDescription = "", 
                    LongDescription = "", 
                    Img = "", 
                    Price = 50000, 
                    IsFavourite = true, 
                    Available = true, 
                    Category = _categoryCars.Allcategories.First()
                    },

                   new Car {
                   Name = "Mazda CX-5 II",
                   ShortDescription = "Отличный, универсальный и резвый городской кроссовер MAZDA CX-5",
                   LongDescription = "",
                   Img = "https://avatars.mds.yandex.net/get-autoru-vos/6220172/0c2ff3dceebd9fce28751b86c44e34cf/1200x900n", 
                   Price = 55000,
                   IsFavourite = true,
                   Available = true,
                   Category = _categoryCars.Allcategories.Last()
                   },

                   new Car {
                   Name = "Mercedes-Benz GLB 200 d I (X247)",
                   ShortDescription = "Отличный, универсальный и резвый городской кроссовер Mercedes-Benz GLB 200 d I (X247)",
                   LongDescription = "",
                   Img = "https://avatars.mds.yandex.net/get-autoru-vos/5986540/979edc93184453ed4c3840ad03c5bbb6/1200x900n",
                   Price = 145000,
                   IsFavourite = true,
                   Available = true,
                   Category = _categoryCars.Allcategories.Last()
                   },

                   new Car {
                   Name = "BMW 3 серии 320i xDrive VII (G2x)",
                   ShortDescription = "Отличный, универсальный и резвый городской кроссовер BMW 3 серии 320i xDrive VII (G2x)",
                   LongDescription = "",
                   Img = "https://avatars.mds.yandex.net/get-autoru-vos/5911025/7adbf6e06027792fdb742a14535d0184/1200x900n",
                   Price = 35000,
                   IsFavourite = true,
                   Available = true,
                   Category = _categoryCars.Allcategories.Last()
                   }

                };
            }
        }
        public new IEnumerable<Car> GetFavCars { get; set; }
        public new Car GetObjectCar(int carId)
        {
            return new Car();
        }
    }
}
