using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carsales.Data;
using Carsales.Data.DbConnections;

namespace CarSales.Repository
{
    public class CarRespository
    {
        //public class Car
        //{
        //    // Go into Web layer -> models? Data layer should be for mapping to db? CRUD?!
        //    [Key]
        //    public int Id { get; set; }
        //    public string Make { get; set; }
        //    public string Model { get; set; }
        //    public string Year { get; set; }
        //    public CarPriceType PriceType { get; set; }
        //    public int EgcPrice { get; set; }
        //    public int DapPrice { get; set; }
        //    public string Email { get; set; }
        //    public string ContactName { get; set; }
        //    public string Phone { get; set; }
        //    public string DealerAbn { get; set; }
        //    public string Comments { get; set; }
        //}

        //public enum CarPriceType
        //{
        //    POA,
        //    DAP,
        //    EGC
        //}

        public void Dispose()
        {
        }

        //public class CarSalesDb : DbContext
        //{
        //    public DbSet<Car> Cars { get; set; }
        //}

        public List<Car> GetCars()
        {
            using (var db = new CarSalesDb())
            {
                return db.Cars.Any() ? db.Cars.ToList() : new List<Car>();
            }
        }

        public Car FindCar(int id)
        {
            using (var db = new CarSalesDb())
            {
                return db.Cars.Find(id);
            }
        }

        public void CreateCar(Car car)
        {
            using (var db = new CarSalesDb())
            {
                db.Cars.Add(car);
                db.SaveChanges();
            }
        }

        public void CreateCars(List<Car> cars)
        {
            using (var db = new CarSalesDb())
            {
                foreach (var car in cars)
                {
                    db.Cars.Add(car);
                    db.SaveChanges();
                }
            }
        }

        public void EditCar(Car car)
        {
            using (var db = new CarSalesDb())
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public bool NoCars()
        {
            using (var db = new CarSalesDb())
            {
                return !db.Cars.Any();
            }
        }

        public void DeleteCar(int carId)
        {
            using (var db = new CarSalesDb())
            {
                var carToRemove = db.Cars.FirstOrDefault(c => c.Id == carId);
                db.Cars.Remove(carToRemove);
                db.SaveChanges();
            }
        }
    }
}
