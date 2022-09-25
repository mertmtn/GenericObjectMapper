using System.ComponentModel.DataAnnotations; 
using System.Text.Json.Serialization;
using Core.Entities;

namespace GenericObjectMapper.Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

        [JsonIgnore]
        public virtual Category? Category { get; set; }
    }
}
