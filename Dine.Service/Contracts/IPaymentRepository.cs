using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.Service.Contracts
{
    public interface IPaymentRepository
    {
        Payment GetPayment(int id);
        Task<Payment> GetLastPayment(long id);
        Task<List<Payment>> GetAllPaymentbyUser(long userId);
        Payment ProcessPayment(Payment payment);
        Payment UpdatePayment(Payment payment);

    }
}
