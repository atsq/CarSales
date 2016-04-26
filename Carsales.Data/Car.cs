using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsales.Data
{
    public class Car
    {
        public virtual int Id { get; set; }
        public virtual string Make { get; set; }
        public virtual string Model { get; set; }
        public virtual string Year { get; set; }
        public virtual CarPriceType PriceType { get; set; }
        public virtual int EgcPrice { get; set; }
        public virtual int DapPrice { get; set; }
        public virtual string Email { get; set; }
        public virtual string ContactName { get; set; }
        public virtual string Phone { get; set; }
        public virtual string DealerAbn { get; set; }
        public virtual string Comments { get; set; }
    }

    public enum CarPriceType
    {
        POA,
        DAP,
        EGC
    }
}
