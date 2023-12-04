using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using OnlineStore.Models.Dtos;
using OnlineStore.Web.Services.Contracts;

namespace OnlineStore.Web.Pages
{
    public class ProductDetailsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        [Inject]
        public IProductService ProductService { get; set; }

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }

        [Inject]
        public IManageCartItemsLocalStorageService manageCartItemsLocalStorageService { get; set; }
        [Inject]
        public IManageProductsLocalStorageService manageProductsLocalStorageService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public ILogger<ProductDetailsBase> Logger { get; set; }

        public ProductDto Product { get; set; }
        public string ErrorMessage { get; set; }
        private List<CartItemDto> ShoppingCartItems { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                ShoppingCartItems = await manageCartItemsLocalStorageService.GetCollection();

                Product = await GetProductById(Id);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Error occurred while initializing product details: {Message}", ex.Message);
                ErrorMessage = ex.Message;
            }
        }

        protected async Task AddToCart_Click(CartItemToAddDto cartItemToAddDto)
        {
            try
            {
                var cartItemDto = await ShoppingCartService.AddItem(cartItemToAddDto);

                if (cartItemDto != null)
                {
                    ShoppingCartItems.Add(cartItemDto);
                    await manageCartItemsLocalStorageService.SaveCollection(ShoppingCartItems);
                }

                NavigationManager.NavigateTo("/ShoppingCart");
            }
            catch (Exception ex )
            {
                Logger.LogError(ex, "Error adding item to cart: {Message}", ex.Message);                
                ErrorMessage = "An error occurred while adding the item to the cart. Please try again.";
                StateHasChanged();
            }
        }

        private async Task<ProductDto> GetProductById(int id)
        {
            var productDtos = await manageProductsLocalStorageService.GetCollection();

            if(productDtos != null)
            {
                return productDtos.SingleOrDefault(p => p.Id == id);
            }

            return null;
        }
    }
}
