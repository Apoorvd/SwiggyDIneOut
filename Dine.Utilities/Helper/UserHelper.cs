using Dine.DataModel.Models;
using Dine.Utilities.ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.Utilities.Helper
{
    public class UserHelper
    {
        public static string CheckWhatChanged(User userDb, User user)
        {
            //check the difference between two.
            return null;
        }

        public static string JSONifyObject(ResultHelper<User> input)
        {
            var result = Newtonsoft.Json.JsonConvert.SerializeObject(input);
            return result;
        }

        public static bool ValidateUser(User user)
        {
            //Build logic here
            return true;
        }
    }
}
