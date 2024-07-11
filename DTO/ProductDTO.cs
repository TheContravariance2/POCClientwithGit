using POCClient.Models;

namespace POCClient.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? PhotoUrl { get; set; }
        public ProductType? ProductType { get; set; }
    }
}
