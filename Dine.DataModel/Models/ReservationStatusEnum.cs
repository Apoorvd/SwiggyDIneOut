using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public enum ReservationStatusEnum
    {
        Unknown = 0,
        Alloted = 1,
        In_Queue = 2,
        Failed = 3,
        Cancelled = 4
    }
}
