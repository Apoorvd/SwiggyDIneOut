using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long AddressId { get; set; }
        public ICollection<OngoingOffers> OngoingOffers { get; set; }
        public ICollection<CategoryMenu> CategoryMenu { get; set;}
        public ICollection<Review> ReviewList { get; set; }
        public long UserId { get; set; }
        public int TotalSeats { get; set; } = 0;
        public int TotalSeatsAvailable { get; set; } = 0;
        public ICollection<Payment> PaymentList { get; set; }

    }
}
