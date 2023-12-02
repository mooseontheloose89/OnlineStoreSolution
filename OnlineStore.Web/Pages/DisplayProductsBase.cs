using Microsoft.AspNetCore.Components;
using OnlineStore.Models.Dtos;

namespace OnlineStore.Web.Pages
{
    public class DisplayProductsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
