using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public virtual OrderStatusEnum OrderStatusEnum { get; set; }
        public int OrderStatusId { get; set; }
        public ICollection<Menu> MealList { get; set; }
        public double TotalPrice { get; set; }
        public int AppliedOngoingOffer { get; set; } = 0; // OfferID is used here
        public int CalculatedTax { get; set; }

    }
}
