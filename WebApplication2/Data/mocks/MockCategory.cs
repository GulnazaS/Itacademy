using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Interfaces;
using WebApplication2.Data.Modeles;

namespace WebApplication2.Data.mocks
{
    public class MockCategory: ICarsCategory
    {
        public IEnumerable<Category> IAllCategories
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
