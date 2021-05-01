using eShop.CoreBusiness.Models;
using eShop.DataStore.SQL.Dapper.Helpers;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eShop.DataStore.SQL.Dapper
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDataAccess _dataAccess;

        public ProductRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Product GetProduct(int productId)
        {
            var sql = "Select * from dbo.[Product] Where ProductId = @ProductId";
            return _dataAccess.QuerySingle<Product, dynamic>(sql, new { ProductId = productId });
        }

        public IEnumerable<Product> GetProducts(string filter)
        {
            var products = new List<Product>();
            var sql = string.Empty;
            if (string.IsNullOrWhiteSpace(filter))
            {
                sql = "Select * From dbo.[Product]";
                products = _dataAccess.Query<Product, dynamic>(sql, new { });
            }
            else
            {
                sql = "Select * From dbo.[Product] Where Name like '%' + @Filter + '%'";
                products = _dataAccess.Query<Product, dynamic>(sql, new { Filter = filter });
            }

            return products.AsEnumerable();
        }
    }
}