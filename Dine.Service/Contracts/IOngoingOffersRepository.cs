using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.Service.Contracts
{
    public interface IOngoingOffersRepository
    {
        List<OngoingOffers> GetOngoingOffersByRestaurant(int restaurantId);
        List<OngoingOffers> GetOngoingOffersForUser(long userId);
        bool UpdateOngoingOffer(int offerId);
        bool DeleteOngoingOffer(int offerId);
        bool UpdateOngoingOfferForUser(long userId, int offerId);
        bool CreateOngoingOffer(int offerId);
    }
}
