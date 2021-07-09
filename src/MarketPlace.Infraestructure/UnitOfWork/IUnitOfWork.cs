using DataAccess.Library.EntityFramework;
using MarketPlace.Domain.Entities;
using MarketPlace.Infraestructure.Context;

namespace MarketPlace.Infraestructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Customer, MarketPlaceContext> CustomerRepository { get; }
        IRepository<Establishment, MarketPlaceContext> EstablishmentRepository { get; }
        IRepository<EstablishmentCategory, MarketPlaceContext> EstablishmentCategoryRepository { get; }
        IRepository<Product, MarketPlaceContext> ProductRepository { get; }
        IRepository<ProductCategory, MarketPlaceContext> ProductCategoryRepository { get; }
        IRepository<Merchant, MarketPlaceContext> MerchantRepository { get; }
        IRepository<Rating, MarketPlaceContext> RatingRepository { get; }

        void SaveChanges();

    }
}