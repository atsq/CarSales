using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsales.Data.DbConnections
{
    public class CarSalesDb : DbContext, ICarSalesDataSource
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Enquiry> Enquiries { get; set; }
 
        IQueryable<Car> ICarSalesDataSource.Cars => Cars;
        IQueryable<Enquiry> ICarSalesDataSource.Enquiries => Enquiries;
    }
}
