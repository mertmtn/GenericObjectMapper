using Core.Entities; 

namespace GenericObjectMapper.Entities.DTOs
{
    public class ProductDTO : IDTO
    {
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
