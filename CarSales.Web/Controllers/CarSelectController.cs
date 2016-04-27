using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarSales.Repository;

namespace CarSales.Web.Controllers
{
    public class CarSelectController : Controller
    {
        private readonly ICarRepository _carRepository;

        public CarSelectController() : this(new CarRespository())
        {
                
        }
        public CarSelectController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        // GET: CarSelect
        public ActionResult Index()
        {
            // Make this part of the constructor parameter for IOC
            
            var cars = _carRepository.GetCars();
            return View(cars);
        }
    }
}