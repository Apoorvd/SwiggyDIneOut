using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public class Payment
    {
        public long PaymentId { get; set; }
        public long UserId { get; set; }
        public int ReservationId { get; set; }
        public int OrderId { get; set; }
        public int RestaurantId { get; set; }
        public float Amount { get; set; }
        public bool Status { get; set; } = false;
        public DateTime PaymentTime { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
