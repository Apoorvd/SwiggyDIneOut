using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public enum OfferTypeEnum
    {
        None = 1,
        Rupay_CreditCard = 2,
        Rupay_DebitCard = 3,
        VISA_CreditCard = 4,
        VISA_DebitCard = 5,
        MasterCard_CreditCard = 6,
        MasterCard_DebitCard = 7,
        UPI = 8,
        PayTM = 9,
        Mobikwick = 10,
        Amazon_Pay = 11,
    }
}
