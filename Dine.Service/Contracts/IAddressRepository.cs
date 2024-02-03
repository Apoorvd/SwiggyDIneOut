using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.Service.Contracts
{
    public interface IAddressRepository
    {
        Task<List<Address>> GetAddressByUserID(long userID);
        Task<Address> GetAddress(long id);
        Task<long> SetDefaultAddress(long id);
        void UpdateAddress(Address address);
        void AddAddress(long userID, Address address);
    }
}
