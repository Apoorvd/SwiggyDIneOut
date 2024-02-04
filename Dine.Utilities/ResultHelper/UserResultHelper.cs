using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.Utilities.ResultHelper
{
    public class ResultHelper<T>(T resultObject)
    {
        public readonly T resultData = resultObject;
        public bool Success { get; set; } = false;
        public bool Error { get; set; } = false;
        public bool Exception { get; set; } = false;
        public string ErrorMsg { get; set; } = string.Empty;
        public string SuccessMsg { get; set; } = string.Empty;
        public string ExceptionMsg { get; set; } = string.Empty;
    }
}
