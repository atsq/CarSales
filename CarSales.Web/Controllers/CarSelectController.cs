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
        // GET: CarSelect
        public ActionResult Index()
        {
            // Make this part of the constructor parameter for IOC
            var carRepository = new CarRespository();
            var cars = carRepository.GetCars();
            return View(cars);
        }

        public ActionResult Details(int id)
        {
            var carRepository = new CarRespository();
            var car = carRepository.FindCar(id);
            return View(car);
        }
    }
}