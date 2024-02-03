using Dine.Service.Contracts;
using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.Service.Repositories
{
    public class OngoingOffersRepository : IOngoingOffersRepository
    {
        public bool CreateOngoingOffer(int offerId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOngoingOffer(int offerId)
        {
            throw new NotImplementedException();
        }

        public List<OngoingOffers> GetOngoingOffersByRestaurant(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public List<OngoingOffers> GetOngoingOffersForUser(long userId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOngoingOffer(int offerId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOngoingOfferForUser(long userId, int offerId)
        {
            throw new NotImplementedException();
        }
    }
}
