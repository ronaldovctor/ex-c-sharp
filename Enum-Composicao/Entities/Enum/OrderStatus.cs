using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Composicao.Entities.Enum
{
    public enum OrderStatus : int
    {
        PendingPayment = 1,
        Processing = 2,
        Shipped = 3,
        Delivered = 4
    }
}
