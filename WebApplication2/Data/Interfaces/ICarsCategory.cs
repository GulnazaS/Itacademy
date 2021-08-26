using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Modeles;

namespace WebApplication2.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> IAllCategories { get; }
    }
}
