using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace Core.DependencyResolvers
{
    public class CoreModule:ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddSingleton<Stopwatch>();
        }
    }
}
