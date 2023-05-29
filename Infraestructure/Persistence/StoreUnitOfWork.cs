using bootcamp_store_backend.Domain.Persistence;
using Microsoft.EntityFrameworkCore;

namespace bootcamp_store_backend.Infraestructure.Persistence
{
    public class StoreUnitOfWork : UnitOfWork, IStoreUnitOfWork
    {
        public StoreUnitOfWork(StoreContext dbContext) : base(dbContext)
        {
        }
    }
}
