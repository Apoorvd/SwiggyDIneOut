using Dine.Service.Contracts;
using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dine.DataModel.ContextModel;
using Microsoft.EntityFrameworkCore;
using Dine.Utilities.Helper;
using Dine.Utilities.ResultHelper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Numerics;

namespace Dine.Service.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DineOutGQLDbContext _dbContext;

        public UserRepository(DineOutGQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<User> GetUserByEmail(string email)
        {
            var result = await _dbContext.Users.FirstOrDefaultAsync(x => x.Email == email);
            return result;
        }

        public async Task<User> GetUserById(long userId)
        {
            var result = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == userId);
            return result;
        }

        public async Task<User> GetUserByPhoneNumber(string phoneNumber)
        {
            var result = await _dbContext.Users.FirstOrDefaultAsync(x => x.PhoneNumber == phoneNumber);
            return result;
        }

        public async Task<string> RegisterUser(User user)
        {
            try
            {
                var checkAlreadyUsedDetails_Email = await GetUserByEmail(user.Email);
                var checkAlreadyUsedDetails_Phone = await GetUserByPhoneNumber(user.PhoneNumber);
                var isValid = UserHelper.ValidateUser(user);
                if (checkAlreadyUsedDetails_Email != null)
                    return "Email address already registered with another user. Click on forget password to reset password.";
                if (checkAlreadyUsedDetails_Phone != null)
                    return "Phone Number already registered with another user. Click on forget password to reset password.";
                if (isValid)
                {
                    //create new user here with dbcontext
                    return "New User Created Successfully.";
                }
                return "User Creation failed due to Invalid Details. Please check the details and try again.";
            }
            catch (Exception ex)
            {
                //ILogger and user defined exception format implementation
            }
            return "User Creation failed due to Unknown reason. Please try again after some time.";

        }

        public async Task<string> UpdateUserProfile(User user)
        {
            ResultHelper<User> result = new ResultHelper<User>(user);
            try
            {
                var checkAlreadyUsedDetails_Email = await GetUserByEmail(user.Email);
                var checkAlreadyUsedDetails_Phone = await GetUserByPhoneNumber(user.PhoneNumber);
                var userDbDetails = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == user.Id);
                string changedField = UserHelper.CheckWhatChanged(userDbDetails, user);
                if( changedField.Contains("email"))
                {
                    if (checkAlreadyUsedDetails_Email.Id != user.Id)
                    {
                        result.Success = false;
                        result.Error = true;
                        result.ErrorMsg = "Please use another email address, this one is already in use";
                        return UserHelper.JSONifyObject(result);
                    }
                        
                }
                if (changedField.Contains("phone"))
                {
                    if (checkAlreadyUsedDetails_Phone.Id != user.Id)
                    {
                        result.Success = false;
                        result.Error = true;
                        result.ErrorMsg = "Please use another phone number, this one is already in use";
                        return UserHelper.JSONifyObject(result);
                    }
                }
                // update existing user here with dbContext
                result.Success = true;
                result.SuccessMsg = $"User Update successfully, details changed were {changedField}";
                return UserHelper.JSONifyObject(result);

            }
            catch (Exception ex)
            {
                result.Exception = true;
                result.ExceptionMsg = ex.Message;
                result.Error = true;
                result.ErrorMsg = "User unable to update due to some reason. Please try again after some time.";
            }
            // create a null user 
            return UserHelper.JSONifyObject(result);
            
        }
    }
}
