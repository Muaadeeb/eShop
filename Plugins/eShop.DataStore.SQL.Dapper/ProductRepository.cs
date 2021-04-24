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
            var sql = "Select * from Product Where ProductId = @ProductId";
            return _dataAccess.QuerySingle<Product, dynamic>(sql, new { ProductId = productId });
        }

        public IEnumerable<Product> GetProducts(string filter)
        {
            var products = new List<Product>();
            if (string.IsNullOrWhiteSpace(filter))
            {
                products = _dataAccess.Query<Product, dynamic>("Select * From Product", new { });
            }
            else
            {
                products = _dataAccess.Query<Product, dynamic>("Select * From Product Where Name like '%' + @Filter + '%'", new { Filter = filter });
            }

            return products.AsEnumerable();
        }
    }
}
