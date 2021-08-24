
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebApplication2.Data.Modeles
 
{
    public class Category
    {   
        public int id { get; set; }
        public string categoryName { get; set; }
        public string desc { get; set; }
        public LinkedList<Cars> cars { get; set; }
    }
}
