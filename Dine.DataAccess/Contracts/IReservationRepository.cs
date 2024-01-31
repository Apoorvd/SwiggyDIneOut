using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataAccess.Contracts
{
    public interface IReservationRepository
    {
        Reservation GetReservation(int id);
        List<Reservation> GetAllReservationsByUser(long userId);
        List<Reservation> GetAllReservationsByRestaurant(int restaurantId);
        bool MakeReservation(Reservation reservation);
        bool UpdateReservation(Reservation reservation);
        bool CancelReservation(Reservation reservation);
    }
}
