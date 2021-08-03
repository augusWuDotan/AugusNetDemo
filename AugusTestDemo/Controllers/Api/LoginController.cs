using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AugusTestDemo.Models.Bean;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AugusTestDemo.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    public class LoginController : Controller
    {
       
        /// <summary>
        /// 電話登入
        /// </summary>
        /// <param name="phoneLogin"></param>
        /// <returns></returns>
        // POST api/Login/UsePhoneLogin
        [HttpPost]
        public BaseResponce<object> UsePhoneLogin([FromBody] PhoneLogin phoneLogin)
        {
            return new BaseResponce<object>() { Code = 200, DateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") };
        }

        /// <summary>
        /// FB登入
        /// </summary>
        /// <param name="fbLogin"></param>
        /// <returns></returns>
        // POST api/Login/UseFbLogin
        [HttpPost]
        public BaseResponce<object> UseFbLogin([FromBody] FbLogin fbLogin)
        {
            return new BaseResponce<object>() { Code = 200, DateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") };
        }
    }
}
