using Dine.Service.Contracts;
using Dine.DataModel.ContextModel;
using Dine.DataModel.Models;
using Dine.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.Service.Repositories
{
    public class AddressRepository : IAddressRepository
    {

        private DineOutGQLDbContext _dbContext;

        public AddressRepository(DineOutGQLDbContext dbContext)
        {

            _dbContext = dbContext;
        }

        public void AddAddress(long userID, string address)
        {
            throw new NotImplementedException();
        }

        public Address GetAddressByUserID(long userID)
        {
            throw new NotImplementedException();
        }

        public void UpdateAddress(long userID, string address)
        {
            throw new NotImplementedException();
        }
    }
}
