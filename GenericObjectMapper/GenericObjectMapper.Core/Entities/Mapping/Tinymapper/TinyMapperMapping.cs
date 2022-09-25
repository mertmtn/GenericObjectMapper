
using Nelibur.ObjectMapper; 
using GenericObjectMapper.Core.Entities;
namespace Northwind.Core.Entities.Mapping.Tinymapper
{
    public class TinyMapperMapping : IMapper
    {
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            TinyMapper.Bind<TSource, TDestination>();
            return TinyMapper.Map<TDestination>(source);
        }
    }
}
