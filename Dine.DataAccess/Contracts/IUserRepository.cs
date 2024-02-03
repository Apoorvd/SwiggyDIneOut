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
        User GetUserById(long userId); //: Fetch a user by ID.
        User GetUserByEmail(string email); //: Fetch a user by email.
        User GetUserByPhoneNumber(string phoneNumber);
        bool RegisterUser(User user); //: Create a new user.
        bool UpdateUserProfile(User user); //: Update user details.
    }
}
