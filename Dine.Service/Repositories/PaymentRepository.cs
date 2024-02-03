using Dine.Service.Contracts;
using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.Service.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        public List<Payment> GetAllPaymentbyUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Payment GetPayment(int id)
        {
            throw new NotImplementedException();
        }

        public Payment ProcessPayment(Payment payment)
        {
            throw new NotImplementedException();
        }

        public Payment UpdatePayment(Payment payment)
        {
            throw new NotImplementedException();
        }
    }
}
