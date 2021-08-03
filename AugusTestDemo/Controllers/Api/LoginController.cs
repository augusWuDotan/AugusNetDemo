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
        //// GET: api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        /// <summary>
        /// test
        /// </summary>
        /// <param name="phoneLogin"></param>
        /// <returns></returns>
        // POST api/values
        [HttpPost]
        public BaseResponce UsePhoneLogin([FromBody] PhoneLogin phoneLogin)
        {
            return new BaseResponce() { Code = 200 };
        }

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
