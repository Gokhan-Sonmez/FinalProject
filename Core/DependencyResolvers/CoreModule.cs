using Core.CrossCuttingConcerns.Cashing;
using Core.CrossCuttingConcerns.Cashing.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection servicecollection)
        {
            servicecollection.AddMemoryCache();
            servicecollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            servicecollection.AddSingleton<ICacheManager, MemoryCashManager>();
            servicecollection.AddSingleton<Stopwatch>();
        }
    }
}
