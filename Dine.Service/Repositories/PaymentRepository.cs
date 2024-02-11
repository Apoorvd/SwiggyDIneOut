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
        public Task<List<Payment>> GetAllPaymentbyUser(long userId)
        {
            throw new NotImplementedException();
        }

        public Payment GetPayment(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<Payment> GetLastPayment(long userId)
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
