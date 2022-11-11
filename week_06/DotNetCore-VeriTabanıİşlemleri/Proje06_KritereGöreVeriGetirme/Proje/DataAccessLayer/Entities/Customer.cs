using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.DataAccessLayer.Entities
{
    public class Customer
    {
        public string Id { get; set; }
        public string Company { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}