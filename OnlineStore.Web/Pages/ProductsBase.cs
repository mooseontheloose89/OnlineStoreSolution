using Microsoft.AspNetCore.Components;
using OnlineStore.Models.Dtos;
using OnlineStore.Web.Services;
using OnlineStore.Web.Services.Contracts;

namespace OnlineStore.Web.Pages
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }
        [Inject]
        public IManageCartItemsLocalStorageService manageCartItemsLocalStorageService { get; set; }
        [Inject]
        public IManageProductsLocalStorageService manageProductsLocalStorageService { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
        public NavigationManager NavigationManager { get; set; }
        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                await ClearLocalStorage();
                Products = await manageProductsLocalStorageService.GetCollection();

                var shoppingCartItems = await manageCartItemsLocalStorageService.GetCollection();
                var totalQuantity = shoppingCartItems.Sum(i => i.PurchaseQuantity);

                ShoppingCartService.RaiseEventOnShoppingCartChanged(totalQuantity);

            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;                
            }
            
        }

        protected IOrderedEnumerable<IGrouping<int, ProductDto>> GetGroupedProductsByCategory()
        {
            return from product in Products
                   group product by product.CategoryId into prodByCatGroup
                   orderby prodByCatGroup.Key
                   select prodByCatGroup;
        }

        protected string GetCategoryName(IGrouping<int, ProductDto> groupedProductDtos)
        {
            return groupedProductDtos.FirstOrDefault(pg => pg.CategoryId == groupedProductDtos.Key).CategoryName;
        }

        private async Task ClearLocalStorage()
        {
            await manageProductsLocalStorageService.RemoveCollection();
            await manageCartItemsLocalStorageService.RemoveCollection();
        }
    }
}
