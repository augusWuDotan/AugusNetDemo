using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AugusTestDemo.Data;
using AugusTestDemo.Models.Bean;
using AugusTestDemo.Models.FeatherBean;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AugusTestDemo.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    public class TestDbController : Controller
    {
        private readonly MyDatabaseContext _context;

        public TestDbController(MyDatabaseContext context)
        {
            _context = context;
        }


        /// <summary>
        /// 取出一筆產品(測試)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // POST api/TestDb/GetProductWithId
        [HttpPost]
        public async Task<BaseResponce<Product>> GetProductWithId(int id)
        {
            var product = await _context.Products
                 .Include(s => s.FeatherImages)
                  .AsNoTracking()
                 .FirstOrDefaultAsync(m => m.ID == id);
            
            return new BaseResponce<Product>()
            {
                Code = 200,
                Data = product,
                DateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };
        }
    }
}
