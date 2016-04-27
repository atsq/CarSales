using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carsales.Data;

namespace CarSales.Repository
{
    public interface IEnquiryRepository
    {
        void SaveEnquiry(Enquiry enquiry);
    }
}
