using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApiApp.Entities
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? AddressId { get; set; }
        public Address Address { get; set; }
     
        public string Phone { get; set; }
        public string Website { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
  
    }
}
