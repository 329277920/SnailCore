using Microsoft.AspNetCore.Mvc;
using SnailCore.Log;
using SnailCore.Tester.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnailCore.Tester.Web.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {

        private ILogger _logger;
        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="logger"></param>
        public UserController(ILogger logger)
        {
            _logger = logger;
        }

        [HttpGet("{userId}")]
        public UserInfo Get(int userId)
        {
            _logger.Info(string.Format("request user/get:{0}", userId));
            return new UserInfo() { Name = "cnf", UserId = userId };
        }
    }
}
