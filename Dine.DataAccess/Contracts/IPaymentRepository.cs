using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataAccess.Contracts
{
    public interface IPaymentRepository
    {
        Payment GetPayment(int id);
        List<Payment> GetAllPaymentbyUser(int userId);
        Payment ProcessPayment(Payment payment);
        Payment UpdatePayment(Payment payment);

    }
}
