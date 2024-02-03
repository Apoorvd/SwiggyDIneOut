using Dine.Service.Contracts;
using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.Service.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(long userId)
        {
            throw new NotImplementedException();
        }

        public User GetUserByPhoneNumber(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public bool RegisterUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUserProfile(User user)
        {
            throw new NotImplementedException();
        }
    }
}
