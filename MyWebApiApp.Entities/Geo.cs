using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApiApp.Entities
{
 public   class Geo
    {
        public int Id { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }

        public int Addressid { get; set; }
        public Address Address { get; set; }
    }
}
