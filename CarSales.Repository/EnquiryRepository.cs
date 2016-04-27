using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carsales.Data;
using Carsales.Data.DbConnections;

namespace CarSales.Repository
{
    public class EnquiryRepository : IEnquiryRepository
    {
        public void SaveEnquiry(Enquiry enquiry)
        {
            using (var db = new CarSalesDb())
            {
                db.Enquiries.Add(enquiry);
                db.SaveChanges();
            }
        }
    }
}
