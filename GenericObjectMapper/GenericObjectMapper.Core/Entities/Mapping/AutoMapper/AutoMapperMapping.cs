﻿using AutoMapper;

namespace Northwind.Core.Entities.Mapping.AutoMapper
{
    public class AutoMapperMapping<TProfile> : GenericObjectMapper.Core.Entities.IMapper where TProfile : Profile, new()
    {
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            var mapper = new MapperConfiguration(config =>
            {
                config.AddProfile(new TProfile());
            }).CreateMapper();

            return mapper.Map<TDestination>(source);
        }
    }
}
