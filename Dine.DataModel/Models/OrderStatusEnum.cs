using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public enum OrderStatusEnum
    {
        Unknown = 0,
        Queued = 1,
        Delivered = 2,
        Awaiting_Payment = 3,
        Completed = 4,
        Cancelled = 5,
        Disputed = 6,
        Refunded = 7,
        Preparing = 8
    }
}
