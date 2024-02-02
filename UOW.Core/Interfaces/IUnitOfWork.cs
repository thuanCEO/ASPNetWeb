
namespace UOW.Core.Entities
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountRepository Account { get; }
        ICatogoryRepository Category { get; }
        ICustomerRepository Customer { get; }
        IOrderRepository Order { get; }
        IOrderDetailRepository OrderDetail { get; }
        IProductRepository Product { get; }
        ISupplierRepository Supplier { get; }
        Task<int> CompletedAsync();

    }
}
