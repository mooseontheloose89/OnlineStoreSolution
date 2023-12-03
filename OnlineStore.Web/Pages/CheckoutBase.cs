using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using OnlineStore.Models.Dtos;
using OnlineStore.Web.Services;
using OnlineStore.Web.Services.Contracts;

namespace OnlineStore.Web.Pages
{
    public class CheckoutBase : ComponentBase
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        protected IEnumerable<CartItemDto> ShoppingCartItems { get; set; }
        protected int TotalQuantity { get; set; }
        protected string PaymentDescription { get; set; }
        protected decimal PaymentAmount { get; set; }

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                ShoppingCartItems = await ShoppingCartService.GetItems(HardCoded.UserId);

                if (ShoppingCartItems != null)
                {
                    Guid orderGuid = Guid.NewGuid();
                    PaymentAmount = ShoppingCartItems.Sum(p => p.TotalPrice);
                    TotalQuantity = ShoppingCartItems.Sum(p => p.Quantity);
                    PaymentDescription = $"Order_{HardCoded.UserId}_{orderGuid}";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            try
            {
                if (firstRender)
                {
                    await JSRuntime.InvokeVoidAsync("initPayPalButton");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
