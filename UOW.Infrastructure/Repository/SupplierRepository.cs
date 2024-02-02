using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Core.Entities;

namespace UOW.Infrastructure.Repository
{
    public abstract class SupplierRepository : GenericRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(PizzaStoreContext context, ILogger logger) : base(context, logger)
        {
        }
    }

}
