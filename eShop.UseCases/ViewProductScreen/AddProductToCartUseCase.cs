using eShop.UseCases.PluginInterfaces.DataStore;
using eShop.UseCases.PluginInterfaces.StateStore;
using eShop.UseCases.PluginInterfaces.UI;
using eShop.UseCases.ViewProductScreen.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.UseCases.ViewProductScreen
{
    public class AddProductToCartUseCase : IAddProductToCartUseCase
    {
        private readonly IProductRepository _productRepository;
        private readonly IShoppingCart _shoppingCart;
        private readonly IShoppingCartStateStore _shoppingCartStateStore;

        public AddProductToCartUseCase(
            IProductRepository productReposity,
            IShoppingCart shoppingCart,
            IShoppingCartStateStore shoppingCartStateStore)
        {
            _productRepository = productReposity;
            _shoppingCart = shoppingCart;
            _shoppingCartStateStore = shoppingCartStateStore;
        }


        public async void Execute(int productId)
        {
            var product = _productRepository.GetProduct(productId);
            await _shoppingCart.AddProductAsync(product);

            _shoppingCartStateStore.UpdateLineItemsCount();
        }
    }
}
