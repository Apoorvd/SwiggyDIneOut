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
        Address GetAddressByUserID(long userID);
        void UpdateAddress(long userID, string address);
        void AddAddress(long userID, string address);
    }
}
