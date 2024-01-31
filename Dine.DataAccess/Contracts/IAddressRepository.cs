using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataAccess.Contracts
{
    public interface IAddressRepository
    {
        Address GetAddressByUserID(long userID);
        Address GetAddressByEmail(string email);
        Address GetAddressByPhoneNumber(string phoneNumber);
        void UpdateAddress(long userID, string address);
        void AddAddress(long userID, string address);
    }
}
