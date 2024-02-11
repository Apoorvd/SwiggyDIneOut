using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public class Address
    {
        public long Id { get; set; }
        public string StreetAddress { get; set; }
        public string HouseNumber {  get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Landmark { get; set; }
        public long UserId { get; set; }
        public bool IsDefault { get; set; }
    }
}
