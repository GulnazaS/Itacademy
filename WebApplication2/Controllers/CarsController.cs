using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data.Interfaces;

namespace WebApplication2.Controllers
{
    public class CarsController: Controller
    {   
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategory;

        public CarsController (IAllCars iallCars, ICarsCategory iCarsCat)
        {
            _allCars = iallCars;
            _allCategory = iCarsCat;
        }
        public ViewResult List()
        {
            ViewBag.Category = "Some category";
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}
