using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Dine.Service.Contracts
{
    public interface IUserRepository
    {
        Task<User> GetUserById(long userId); //: Fetch a user by ID.
        Task<User> GetUserByEmail(string email); //: Fetch a user by email.
        Task<User> GetUserByPhoneNumber(string phoneNumber);
        Task<string> RegisterUser(User user); //: Create a new user.
        Task<string> UpdateUserProfile(User user); //: Update user details.
    }
}
