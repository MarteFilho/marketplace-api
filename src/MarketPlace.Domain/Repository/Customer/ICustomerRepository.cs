using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using MarketPlace.Domain.Entities;

namespace MarketPlace.Domain.Repository
{
    public interface ICustomerRepository
    {
        Task AddAsync(Customer customer, CancellationToken cancellation);
        bool Exists(Expression<Func<Customer, bool>> predicate);
        IList<Customer> Find(Expression<Func<Customer, bool>> predicate);
        void SaveChanges();
    }
}