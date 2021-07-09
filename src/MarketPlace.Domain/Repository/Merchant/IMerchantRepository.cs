using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using MarketPlace.Domain.Entities;

namespace MarketPlace.Domain.Repository
{
    public interface IMerchantRepository
    {
        Task AddAsync(Merchant merchant, CancellationToken cancellation);
        bool Exists(Expression<Func<Merchant, bool>> predicate);
        void SaveChanges();
    }
}