using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SnailCore.Web.Middleware
{
    /// <summary>
    /// 抽象处理类
    /// </summary>
    public abstract class BaseMiddleware
    {
        /// <summary>
        /// 获取或设置一下个处理对象
        /// </summary>
        protected RequestDelegate Next { get; set; }

        public BaseMiddleware(RequestDelegate next)
        {
            this.Next = next;
        }

        /// <summary>
        /// 该中间件执行方法
        /// </summary>
        /// <param name="context">HttpContext</param>
        /// <returns></returns>
        public virtual Task Invoke(HttpContext context)
        {
            return this.Next(context);
        }
    }
}
