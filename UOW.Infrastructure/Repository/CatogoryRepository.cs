using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Core.Entities;

namespace UOW.Infrastructure.Repository
{
    public abstract class CatogoryRepository : GenericRepository<Category>, ICatogoryRepository
    {
        public CatogoryRepository(PizzaStoreContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
