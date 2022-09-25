using Core.Entities;

namespace GenericObjectMapper.Entities.DTOs
{
    public class CategoryDTO : IDTO
    {
        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}
