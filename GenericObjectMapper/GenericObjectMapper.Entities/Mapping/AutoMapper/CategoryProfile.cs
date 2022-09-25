using AutoMapper;
using GenericObjectMapper.Entities.Concrete;
using GenericObjectMapper.Entities.DTOs;

namespace GenericObjectMapper.Entities.Mapping.AutoMapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();
        }
    }
}
