using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        //public List<User> Users { get; set; }

       
        public int GeoId { get; set; }
        //public Geo Geo { get; set; }





        //public int UserId { get; set; }
        //public User User { get; set; }
        //public List<Geo> Geos { get; set; }
    }
}
