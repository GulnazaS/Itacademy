using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Interfaces;
using WebApplication2.Data.Modeles;

namespace WebApplication2.Data.mocks
{
    public class MockCars: IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Cars> Cars
        {
            get
            {
                return new List<Cars>
                {
                    new Cars
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и тихий автмобиль компании Tesla",
                        img = "",
                        price = 11000,
                        isFavourite =true,
                        available = true,
                        Category = _carsCategory.IAllCategories.First()
                    },
                    new Cars
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и тихий автмобиль компании Tesla",
                        img = "",
                        price = 11000,
                        isFavourite =true,
                        available = true,
                        Category = _carsCategory.IAllCategories.Last()
                    },
                    new Cars
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и тихий автмобиль компании Tesla",
                        img = "",
                        price = 11000,
                        isFavourite =true,
                        available = true,
                        Category = _carsCategory.IAllCategories.First()
                    }
                };
            }

        }
        public IEnumerable<Cars> getFavCar { get; set; }
        public Cars getObjectCars(int carId)
        {
            throw new NotImplementedException();
        } 
    }
}
