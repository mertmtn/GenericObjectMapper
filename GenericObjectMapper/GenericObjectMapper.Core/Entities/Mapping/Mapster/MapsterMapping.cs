using GenericObjectMapper.Core.Entities;
using Mapster; 

namespace Northwind.Core.Entities.Mapping.Mapster
{
    public class MapsterMapping : IMapper
    {
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return source.Adapt<TDestination>();
        }
    }
}
