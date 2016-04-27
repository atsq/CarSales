using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carsales.Data;
using Carsales.Data.DbConnections;

namespace CarSales.Repository
{
    public interface ICarRepository
    {
        List<Car> GetCars();
        Car FindCar(int id);
        void CreateCar(Car car);
        void CreateCars(List<Car> cars);
        void EditCar(Car car);
        bool NoCars();
        void DeleteCar(int carId);
    }
}
