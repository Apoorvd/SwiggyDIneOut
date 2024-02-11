using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public class User
    {
        public long Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateOnly BirthDay { get; set; }
        public bool EmailConfirmed { get; set; }
        = false;
        public long DefaultAddressId { get; set; } = 0;
        public virtual UserTypeEnum UserTypeEnum { get; set; }
        public int UserTypeId { get; set; }
        public ICollection<Address> AddressList { get; set; }
        public ICollection<Review> ReviewList { get;  }
        public ICollection<Payment> PaymentList { get;  }
    }
}
