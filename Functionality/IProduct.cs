using POCClient.Models;

namespace POCClient.Functionality
{
    public interface IProduct
    {
        public int createProduct(Product product);

        public IEnumerable<Product> getProducts();
    }
}
