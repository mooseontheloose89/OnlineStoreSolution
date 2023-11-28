using OnlineStore.Models.Dtos;

namespace OnlineStore.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
    }
}
