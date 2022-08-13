using IDLS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDLS.Services
{
    public interface IOrderService
    {
        int OrderStatus(OrderDetails details);

    }
}
