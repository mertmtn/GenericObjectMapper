using Autofac;
using Autofac.Extras.DynamicProxy; 
using Castle.DynamicProxy;
using Core.Utilities.Interceptors; 
using GenericObjectMapper.Business.Abstract;
using GenericObjectMapper.Business.Concrete;
using GenericObjectMapper.DataAccess.Abstract;
using GenericObjectMapper.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http; 

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        //Business katmanını ilgilendiren kısımlar

        protected override void Load(ContainerBuilder builder)
        {
            //ICarService isterse CarService tek bir instance/newle ver

            //Single instance: data tutmuyoruz.
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance(); 
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();
            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }


    }
}
