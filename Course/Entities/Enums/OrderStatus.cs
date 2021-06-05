using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        shipped = 2,
        delivered = 3
    }
}
