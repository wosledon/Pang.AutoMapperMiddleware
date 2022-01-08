using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Pang.AutoMapperMiddleware
{
    public static class AutoMapperMiddleware
    {
        /// <summary>
        /// 配置AutoMapper中间件
        /// </summary>
        /// <param name="app"> </param>
        /// <returns> </returns>
        public static IApplicationBuilder UseAutoMapperMiddleware(this IApplicationBuilder app)
        {
            var mapper = app.ApplicationServices.GetService<IMapper>();

            AutoMapperExtension.Configure(mapper);

            return app;
        }
    }
}
