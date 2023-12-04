using OnlineStore.Models.Dtos;

namespace OnlineStore.Web.Services.Contracts
{
    public interface IManageCartItemsLocalStorageService
    {
        Task<List<CartItemDto>> GetCollection();
        Task SaveCollection (List<CartItemDto> cartItemDtos);
        Task RemoveCollection();
    }
}
