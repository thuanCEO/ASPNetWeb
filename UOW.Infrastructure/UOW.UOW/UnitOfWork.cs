using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Core.Entities;

namespace UOW.Infrastructure.UOW.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PizzaStoreContext _context;
        private readonly ILogger _logger;
        public IAccountRepository Account => throw new NotImplementedException();

        public ICatogoryRepository Category => throw new NotImplementedException();

        public ICustomerRepository Customer => throw new NotImplementedException();

        public IOrderRepository Order => throw new NotImplementedException();

        public IOrderDetailRepository OrderDetail => throw new NotImplementedException();

        public IProductRepository Product => throw new NotImplementedException();

        public ISupplierRepository Supplier => throw new NotImplementedException();

        public Task<int> CompletedAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
