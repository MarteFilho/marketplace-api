using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using MarketPlace.Domain.Entities;

namespace MarketPlace.Domain.Repository
{
    public interface IEstablishmentRepository
    {

        Task AddAsync(Establishment establishment, CancellationToken cancellation);
        bool Exists(Expression<Func<Establishment, bool>> predicate);
        IList<Establishment> GetAll();
        void SaveChanges();
    }
}