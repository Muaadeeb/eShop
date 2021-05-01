using eShop.CoreBusiness.Models;
using eShop.DataStore.SQL.Dapper.Helpers;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop.DataStore.SQL.Dapper
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IDataAccess _dataAccess;
        

        public OrderRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        

        public int CreateOrder(Order order)
        {
            var sql = @"Insert Into dbo.[Order] (DatePlaced, DateProcessing, DateProcessed, CustomerName, CustomerAddress, CustomerCity, CustomerStateProvince, CustomerCountry, AdminUser, UniqueId)
                        OutPut Inserted.OrderId Values (@DatePlaced, @DateProcessing, @DateProcessed, @CustomerName, @CustomerAddress, @CustomerCity, 
                        @CustomerStateProvince, @CustomerCountry, @AdminUser, @UniqueId)";

            var orderId = _dataAccess.QuerySingle<int, Order>(sql, order);

            sql = @"Insert Into dbo.[OrderLineItem] (ProductId, OrderId, Quantity, Price)
                    Values(@ProductId, @OrderId, @Quantity, @Price)";

            order.LineItems.ForEach(x => x.OrderId = orderId);
            _dataAccess.ExecuteCommand(sql, order.LineItems);

            return orderId;
        }

        public IEnumerable<OrderLineItem> GetLineItemsByOrderId(int orderId)
        {
            var sql = "Select * From dbo.[OrderLineItem] Where OrderId = @OrderId";
            var lineItems = _dataAccess.Query<OrderLineItem, dynamic>(sql, new { OrderId = orderId });

            sql = "Select * From dbo.[Product] Where ProductId = @ProductId";
            lineItems.ForEach(x => x.Product = _dataAccess.QuerySingle<Product, dynamic>(sql, new { ProductId = x.ProductId}));

            return lineItems;
        }

        public Order GetOrder(int id)
        {
            var sql = "Select * From dbo.[Order] Where OrderId = @OrderId";
            var order = _dataAccess.QuerySingle<Order, dynamic>(sql, new { OrderId = id });
            order.LineItems = GetLineItemsByOrderId(order.OrderId.Value).ToList();

            return order;
        }

        public Order GetOrderbyUniqueId(string uniqueId)
        {
            var sql = "Select * From dbo.[Order] Where UniqueId = @UniqueId";
            var order = _dataAccess.QuerySingle<Order, dynamic>(sql, new { UniqueId = uniqueId });
            order.LineItems = GetLineItemsByOrderId(order.OrderId.Value).ToList();

            return order;
        }

        public IEnumerable<Order> GetOrders()
        {
            var sql = "Select * from dbo.[Order]";
            return _dataAccess.Query<Order, dynamic>(sql, new { });
        }

        public IEnumerable<Order> GetOutstandingOrders()
        {
            var sql = "Select * from dbo.[Order] Where DateProcessed is null";
            return _dataAccess.Query<Order, dynamic>(sql, new { });
        }

        public IEnumerable<Order> GetProcessedOrders()
        {
            var sql = "Select * from dbo.[Order] Where DateProcessed is not null";
            return _dataAccess.Query<Order, dynamic>(sql, new { });
        }

        public void UpdateOrder(Order order)
        {
            var sql = @"Update dbo.[Order] 
                            Set  DatePlaced = @DatePlaced,
                                 DateProcessing = @DateProcessing,
                                 DateProcessed = @DateProcessed,
                                 CustomerName = @CustomerName,
                                 CustomerAddress = @CustomerAddress,
                                 CustomerCity = @CustomerCity,
                                 CustomerStateProvince = @CustomerStateProvince,
                                 CustomerCountry = @CustomerCountry,
                                 AdminUser = @AdminUser,
                                 UniqueId = @UniqueId
                            Where OrderId = @OrderId";

            _dataAccess.ExecuteCommand(sql, order);

            sql = @"Update dbo.[OrderLineItem]
                        Set ProductId = @ProductId,
                            OrderId = @OrderId,
                            Quantity = @Quantity,
                            Price = @Price
                        Where LineItemId = @LineItemId";

            _dataAccess.ExecuteCommand(sql, order.LineItems);
        }
        

        public void DeleteOrder(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
