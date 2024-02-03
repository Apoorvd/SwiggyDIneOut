using Dine.DataAccess.Contracts;
using Dine.DataModel.ContextModel;
using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataAccess.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private AddressService _addressService;
        private DineOutGQLDbContext _dbContext;
        public void AddAddress(long userID, string address)
        {
            throw new NotImplementedException();
        }

        public Address GetAddressByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Address GetAddressByPhoneNumber(string phoneNumber)
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
