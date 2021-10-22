using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApiApp.Entities
{
   public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public List<Geo> Geos { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
