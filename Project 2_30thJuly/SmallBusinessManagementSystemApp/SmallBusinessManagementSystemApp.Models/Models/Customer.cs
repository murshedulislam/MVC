using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystemApp.Models.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int LoyaltyPoint { get; set; }
        public int Contact { get; set; }
        public string Address { get; set; }
    }
}
