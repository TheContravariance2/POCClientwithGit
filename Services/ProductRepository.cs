using Microsoft.EntityFrameworkCore;
using POCClient.Data;
using POCClient.Functionality;
using POCClient.Models;

namespace POCClient.Services
{
    public class ProductRepository : IProduct
    {

        ProductDBContext dbContext;
        public ProductRepository(ProductDBContext _dbContext)  // applying DI for dbContext 
        {
            dbContext = _dbContext;
        }

        int IProduct.createProduct(Product product)
        {
            dbContext.Products.Add(product);
            return dbContext.SaveChanges();
        }

        IEnumerable<Product> IProduct.getProducts()
        {
            return dbContext.Products;
        }
    }
}
