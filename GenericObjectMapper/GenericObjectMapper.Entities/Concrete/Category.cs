﻿
using Core.Entities;

namespace GenericObjectMapper.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
