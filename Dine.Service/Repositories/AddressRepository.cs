using Dine.Service.Contracts;
using Dine.DataModel.ContextModel;
using Dine.DataModel.Models;
using Dine.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dine.Utilities.Helper;

namespace Dine.Service.Repositories
{
    public class AddressRepository : IAddressRepository
    {

        private DineOutGQLDbContext _dbContext;

        public AddressRepository(DineOutGQLDbContext dbContext)
        {

            _dbContext = dbContext;
        }
        public async Task<long> SetDefaultAddress(long Id)
        {
            var result = await _dbContext.Address.FirstOrDefaultAsync(x => x.Id == Id);
            return result == null ? 0 : result.Id;
        }
        public async Task<long> GetDefaultAddress(long userId)
        {
            var result = await _dbContext.Address.FirstOrDefaultAsync(x => x.UserId == userId && x.IsDefault == true);
            return result == null ? 0 : result.Id;
        }

        public async Task<Address> GetAddress(long Id)
        {
            var result = await _dbContext.Address.FirstOrDefaultAsync(x => x.Id == Id);
            return result;
        }
        public async void AddAddress(long userID, Address address)
        {
            var allAddress = await this.GetAddressByUserID(userID);
            bool isValid = AddressHelper.ValidateAddress(address);
            // see if the address is valid or not
            // thrwo exception if not valid
            // Add new ADDRESS

        }
        

        public async Task<List<Address>> GetAddressByUserID(long userID)
        {
            var result = await _dbContext.Address.Where(u => u.UserId == userID).ToListAsync();
            int a = 0;
            return result;
        }

        public async void UpdateAddress(Address address)
        {
            var adrs = await this.GetAddress(address.Id);
            //validate which part of address is changing and is it a feasible change


        }
    }
}
