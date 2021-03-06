﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsales.Data
{
    public interface ICarSalesDataSource
    {
        IQueryable<Car> Cars { get; } 
        IQueryable<Enquiry> Enquiries { get; } 
    }
}
