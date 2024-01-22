using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public int PartySize { get; set; }
        public virtual ReservationStatusEnum ReservationStatusEnum { get; set; }
        public int ReservationStatusId { get; set; }
        public string SpecialRequest { get; set;}
        public DateTime ReservationDate { get; set; }
        public int RestaurantId {  get; set; }

    }
    
}
