using Microsoft.EntityFrameworkCore;
using OnlineStore.Api.Data;
using OnlineStore.Api.Entities;
using OnlineStore.Api.Repositories.Contracts;
using OnlineStore.Models.Dtos;

namespace OnlineStore.Api.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly OnlineStoreDbContext onlineStoreDbContext;

        public ShoppingCartRepository(OnlineStoreDbContext onlineStoreDbContext) 
        {
            this.onlineStoreDbContext = onlineStoreDbContext;
        }

        private async Task<bool> CartItemsExists(int cartId, int productId)
        {
            return await this.onlineStoreDbContext.CartItems.AnyAsync(c => c.CartId == cartId && c.ProductId == productId);
        }
        public async Task<CartItem> AddItem(CartItemToAddDto cartItemToAddDto)
        {
            if (await CartItemsExists(cartItemToAddDto.CartId, cartItemToAddDto.ProductId) == false) 
            {
                var item = await (from product in this.onlineStoreDbContext.Products
                                  where product.Id == cartItemToAddDto.ProductId
                                  select new CartItem
                                  {
                                      CartId = cartItemToAddDto.CartId,
                                      ProductId = cartItemToAddDto.ProductId,
                                      Quantity = cartItemToAddDto.Quantity
                                  }).SingleOrDefaultAsync();
                if (item != null)
                {
                    var result = await this.onlineStoreDbContext.CartItems.AddAsync(item);
                    await this.onlineStoreDbContext.SaveChangesAsync();
                    return result.Entity;
                }
            }
            
            return null;
        }

        public async Task<CartItem> DeleteItem(int id)
        {
            var item = await this.onlineStoreDbContext.CartItems.FindAsync(id);

            if (item != null) 
            {
                this.onlineStoreDbContext.CartItems.Remove(item);
                await this.onlineStoreDbContext.SaveChangesAsync(true);
            }

            return item;
        }

        public async Task<CartItem> GetItem(int id)
        {
            return await (from cart in this.onlineStoreDbContext.Carts
                          join cartItem in this.onlineStoreDbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cartItem.Id == id
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Quantity = cartItem.Quantity,
                              CartId = cartItem.CartId
                          }).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<CartItem>> GetItems(int userId)
        {
            return await (from cart in this.onlineStoreDbContext.Carts
                          join cartItem in this.onlineStoreDbContext.CartItems
                          on cart.Id equals cartItem.Id
                          where cart.UserId == userId
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Quantity = cartItem.Quantity,
                              CartId= cartItem.CartId
                          }).ToListAsync();
        }

        public Task<CartItem> UpdateQuantity(int id, CartItemQuantityUpdateDto quantityUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
