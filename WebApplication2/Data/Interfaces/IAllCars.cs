using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Modeles;

namespace WebApplication2.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Cars> Cars { get; }
        IEnumerable<Cars> getFavCars { get; set; }
        Cars getObject(int carId);
    }
}
