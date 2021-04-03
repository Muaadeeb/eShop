using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using eShop.UseCases.PluginInterfaces.UI;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.ShoppingCart.LocalStorage
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly IJSRuntime _jsRunTime;
        private readonly IProductRepository _productRepositry;
        private const string cstrShoppingCart = "eShop.ShoppingCart";

        public ShoppingCart(IJSRuntime jSRuntime, IProductRepository productRepository)
        {
            _jsRunTime = jSRuntime;
            _productRepositry = productRepository;
        }


        public async Task<Order> AddProductAsync(Product product)
        {
            var order = await GetOrder();
            order.AddProduct(product.ProductId, 1, product.Price);
            await SetOrder(order);

            return order;
        }

        public async Task<Order> DeleteProductAsync(int productId)
        {
            var order = await GetOrder();
            order.RemoveProduct(productId);
            await SetOrder(order);

            return order;
        }

        public Task EmptyAsync()
        {
            return SetOrder(null);
        }

        public async Task<Order> GetOrderAsync()
        {
            return await GetOrder();
        }

        public Task<Order> PlaceOrderAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Order> UpdateOrderAsync(Order order)
        {
            await SetOrder(order);
            return order;
        }

        public async Task<Order> UpdateQuantityAsync(int productId, int quantity)
        {
            var order = await GetOrder();

            if (quantity < 0)
            {
                return order;
            }
            else if (quantity == 0)
            {
                return  await DeleteProductAsync(productId);
            }

            var lineItem = order.LineItems.SingleOrDefault(x => x.ProductId == productId);

            if (lineItem != null)
            {
                lineItem.Quantity = quantity;
            }

            await SetOrder(order);

            return order;

        }

        private async Task<Order> GetOrder()
        {
            Order order = new Order();

            var strOrder = await _jsRunTime.InvokeAsync<string>("localStorage.getItem", cstrShoppingCart);
            if (!string.IsNullOrWhiteSpace(strOrder) && strOrder.ToLower() != "null" )
            {
                order = JsonConvert.DeserializeObject<Order>(strOrder);
            }
            else
            {
                await SetOrder(order);
            }

            foreach (var item in order.LineItems)
            {
                item.Product = _productRepositry.GetProduct(item.ProductId);
            }

            return order;
        }

        private async Task SetOrder(Order order)
        {
            await _jsRunTime.InvokeVoidAsync("localStorage.setItem", cstrShoppingCart, JsonConvert.SerializeObject(order));
        }
    }
}
