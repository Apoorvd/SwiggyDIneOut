﻿using Dine.DataModel.Models;
using Dine.Utilities.ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.Utilities.Helper
{
    public class AddressHelper
    {
        public static bool ValidateAddress(Address address)
        {

            return true;
        }
        public static string JSONifyObject(ResultHelper<Address> input)
        {
            var result = Newtonsoft.Json.JsonConvert.SerializeObject(input);
            return result;
        }
    }
}
