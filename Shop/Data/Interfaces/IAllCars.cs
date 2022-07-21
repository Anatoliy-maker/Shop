using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public class IAllCars
    {
        public IEnumerable<Car> Cars { get; set; }
        public IEnumerable<Car> GetFavCars { get; set; }
        public Car GetObjectCar(int carId) 
        {
            return new Car();
        }
       
    }
}
