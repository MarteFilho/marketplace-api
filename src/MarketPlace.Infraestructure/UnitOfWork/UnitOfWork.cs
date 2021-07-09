using DataAccess.Library.EntityFramework;
using MarketPlace.Domain.Entities;
using MarketPlace.Infraestructure.Context;

namespace MarketPlace.Infraestructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MarketPlaceContext Context;
        public UnitOfWork(MarketPlaceContext context)
        {
            Context = context;
        }

        private IRepository<Customer, MarketPlaceContext> customerRepository;
        public IRepository<Customer, MarketPlaceContext> CustomerRepository
        {
            get
            {
                if (customerRepository == null)
                    customerRepository = new Repository<Customer, MarketPlaceContext>(Context);

                return customerRepository;
            }
        }

        private IRepository<Establishment, MarketPlaceContext> establishmentRepository;
        public IRepository<Establishment, MarketPlaceContext> EstablishmentRepository
        {
            get
            {
                if (establishmentRepository == null)
                    establishmentRepository = new Repository<Establishment, MarketPlaceContext>(Context);

                return establishmentRepository;
            }
        }

        private IRepository<EstablishmentCategory, MarketPlaceContext> establishmentCategoryRepository;
        public IRepository<EstablishmentCategory, MarketPlaceContext> EstablishmentCategoryRepository
        {
            get
            {
                if (establishmentCategoryRepository == null)
                    establishmentCategoryRepository = new Repository<EstablishmentCategory, MarketPlaceContext>(Context);

                return establishmentCategoryRepository;
            }
        }

        private IRepository<Product, MarketPlaceContext> productRepository;
        public IRepository<Product, MarketPlaceContext> ProductRepository
        {
            get
            {
                if (productRepository == null)
                    productRepository = new Repository<Product, MarketPlaceContext>(Context);

                return productRepository;
            }
        }

        private IRepository<ProductCategory, MarketPlaceContext> productCategoryRepository;
        public IRepository<ProductCategory, MarketPlaceContext> ProductCategoryRepository
        {
            get
            {
                if (productCategoryRepository == null)
                    productCategoryRepository = new Repository<ProductCategory, MarketPlaceContext>(Context);

                return productCategoryRepository;
            }
        }

        private IRepository<Merchant, MarketPlaceContext> merchantRepository;
        public IRepository<Merchant, MarketPlaceContext> MerchantRepository
        {
            get
            {
                if (merchantRepository == null)
                    merchantRepository = new Repository<Merchant, MarketPlaceContext>(Context);

                return merchantRepository;
            }
        }

        private IRepository<Rating, MarketPlaceContext> ratingRepository;
        public IRepository<Rating, MarketPlaceContext> RatingRepository
        {
            get
            {
                if (ratingRepository == null)
                    ratingRepository = new Repository<Rating, MarketPlaceContext>(Context);

                return ratingRepository;
            }
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}