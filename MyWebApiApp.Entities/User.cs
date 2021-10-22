﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApiApp.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int? AddressId { get; set; }
        public Address Address { get; set; }
        //public List<Address> Addresses { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }

        public int? CompanyId { get; set; }
        public Company Company { get; set; }
        //public List<Company> Companies { get; set; }
    }
}
