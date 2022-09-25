using Autofac;
using Autofac.Extras.DynamicProxy; 
using Castle.DynamicProxy;
using Core.Utilities.Interceptors; 
using GenericObjectMapper.Business.Abstract;
using GenericObjectMapper.Business.Concrete;
using GenericObjectMapper.DataAccess.Abstract;
using GenericObjectMapper.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using Northwind.Core.Entities.Mapping.Tinymapper;
using GenericObjectMapper.Core.Entities;
using Northwind.Core.Entities.Mapping.Mapster;
using Northwind.Core.Entities.Mapping.AutoMapper;
using GenericObjectMapper.Entities.Mapping.AutoMapper;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    { 
        protected override void Load(ContainerBuilder builder)
        { 
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance(); 
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>(); 
            
            //AutoMapper
            //builder.RegisterType<AutoMapperMapping<CategoryProfile>>().As<IMapper>().SingleInstance();

            //Mapster
            builder.RegisterType<MapsterMapping>().As<IMapper>().SingleInstance();

            //TinyMapper
            //builder.RegisterType<TinyMapperMapping>().As<IMapper>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
