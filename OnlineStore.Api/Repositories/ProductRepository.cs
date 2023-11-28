using Microsoft.EntityFrameworkCore;
using OnlineStore.Api.Data;
using OnlineStore.Api.Entities;
using OnlineStore.Api.Repositories.Contracts;

namespace OnlineStore.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly OnlineStoreDbContext onlineStoreDbContext;

        public ProductRepository(OnlineStoreDbContext onlineStoreDbContext)
        {
            this.onlineStoreDbContext = onlineStoreDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.onlineStoreDbContext.ProductCategories.ToListAsync();
            return categories;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.onlineStoreDbContext.Products.ToListAsync();
            return products;
        }
    }
}
