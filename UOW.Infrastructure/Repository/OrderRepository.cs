using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Core.Entities;
using Microsoft.Extensions.Logging;
namespace UOW.Infrastructure.Repository
{
    public abstract class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(PizzaStoreContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
