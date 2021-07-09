using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using MarketPlace.Domain.Entities;

namespace MarketPlace.Domain.Repository
{
    public interface IEstablishmentCategoryRepository
    {
        Task AddAsync(EstablishmentCategory establishmentCategory, CancellationToken cancellation);
        bool Exists(Expression<Func<EstablishmentCategory, bool>> predicate);
        void SaveChanges();
    }
}