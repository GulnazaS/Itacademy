using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Modeles;

namespace WebApplication2.Data.mocks
{
    public class MockCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName ="Электромобили", desc="Современный вид транспорта"},
                    new Category { categoryName="Классические автомобили", desc="Машины с двигателем внутреннего сгорания"}
                };
            }
        }

    }
}
