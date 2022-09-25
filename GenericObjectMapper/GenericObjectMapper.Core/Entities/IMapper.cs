
namespace GenericObjectMapper.Core.Entities
{
    public interface IMapper
    {
        TDestination Map<TSource, TDestination>(TSource source);
    }
}
