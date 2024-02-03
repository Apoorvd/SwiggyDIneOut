using Dine.DataAccess.Contracts;
using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataAccess.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        public bool CancelReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetAllReservationsByRestaurant(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetAllReservationsByUser(long userId)
        {
            throw new NotImplementedException();
        }

        public Reservation GetReservation(int id)
        {
            throw new NotImplementedException();
        }

        public bool MakeReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public bool UpdateReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }
    }
}
