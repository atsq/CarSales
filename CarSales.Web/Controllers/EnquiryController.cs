using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Carsales.Data;
using CarSales.Repository;

namespace CarSales.Web.Controllers
{
    public class EnquiryController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly IEnquiryRepository _enquiryRepository;
        // GET: Enquiry
        public EnquiryController() : this(new CarRespository(), new EnquiryRepository())
        {
            
        }
        public EnquiryController(ICarRepository carRepository, IEnquiryRepository enquiryRepository)
        {
            _carRepository = carRepository;
            _enquiryRepository = enquiryRepository;
        }
        public ActionResult Save()
        {
            return View();
        }

        public ActionResult EnquiryForm(int carId)
        {
            var car = _carRepository.FindCar(carId);
            var enquiry = new Enquiry {Car = car};
            return View(enquiry);
        }
    }
}