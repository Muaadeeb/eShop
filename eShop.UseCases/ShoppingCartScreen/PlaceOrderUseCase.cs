using eShop.UseCases.ShoppingCartScreen.Interfaces;
using eShop.CoreBusiness.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using eShop.UseCases.PluginInterfaces.UI;
using eShop.UseCases.PluginInterfaces.StateStore;
using System.Threading.Tasks;

namespace eShop.UseCases.ShoppingCartScreen
{
    public class PlaceOrderUseCase : IPlaceOrderUseCase
    {
        private readonly IOrderService _orderService;
        private readonly IOrderRepository _orderRepository;
        private readonly IShoppingCart _shoppingCart;
        private readonly IShoppingCartStateStore _shoppingCartStateStore;

        public PlaceOrderUseCase(IOrderService orderService, IOrderRepository orderRepository, IShoppingCart shoppingCart, IShoppingCartStateStore shoppingCartStateStore = null)
        {
            _orderService = orderService;
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
            _shoppingCartStateStore = shoppingCartStateStore;
        }

        public async Task<string> Execute(Order order)
        {
            if (_orderService.ValidateCreateOrder(order))
            {
                order.DatePlaced = DateTime.Now;
                order.UniqueId = Guid.NewGuid().ToString();
                _orderRepository.CreateOrder(order);

                await _shoppingCart.EmptyAsync();

                _shoppingCartStateStore.UpdateLineItemsCount();
                return order.UniqueId;
            }

            return default;
        }
    }
}
