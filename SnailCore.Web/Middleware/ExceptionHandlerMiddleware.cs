using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using SnailCore.Log;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SnailCore.Web.Middleware
{
    /// <summary>
    /// 处理未知异常
    /// </summary>
    public class ExceptionHandlerMiddleware : BaseMiddleware
    {
        private ILogger _logger;

        public ExceptionHandlerMiddleware(RequestDelegate next, ILogger logger = null) : base(next)
        {
            _logger = logger;
        }

        public override async Task Invoke(HttpContext context)
        {
            try
            {
                await base.Invoke(context);
            }
            catch (Exception ex)
            {
                _logger?.Error("unknow error.", ex);
            }
        }
    }    

    public static class ExceptionHandleMiddlewareExtends
    {
        /// <summary>
        /// 启用异常捕获组件，该组件依赖于SnailCore.Log.ILogger
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseEx(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
