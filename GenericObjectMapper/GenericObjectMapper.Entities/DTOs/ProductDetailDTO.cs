using Core.Entities;

namespace GenericObjectMapper.Entities.DTOs
{
    public class ProductDetailDTO : IDTO
    {
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
    }
}
