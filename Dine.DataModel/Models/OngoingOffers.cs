using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public class OngoingOffers
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual OfferAppEnum OfferApp { get; set; }
        public int OfferAppId { get; set; }
        public virtual OfferBankEnum OfferBank { get; set; }
        public int OfferBankId { get; set; }
        public virtual OfferTypeEnum OfferType { get; set; }
        public int OfferTypeId { get; set; }
        public float Offer_Discount_Price { get; set; }
        public float Offer_Discount_Percentage { get; set; }
        public float Offer_Available_Above { get; set; }
        public ICollection<Menu> MenuList { get; set; }
        public float Special_Price { get; set; } = 0;
        public int RestaurantId { get; set; }

    }
}
