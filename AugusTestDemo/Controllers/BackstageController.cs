using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AugusTestDemo.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using AugusTestDemo.Models.Base;

namespace AugusTestDemo.Controllers
{
    public class BackstageController : Controller
    {
        private readonly ILogger<BackstageController> _logger;
        private IConfiguration _config;

        public BackstageController(ILogger<BackstageController> logger, IConfiguration config)
        {
            _logger = logger;
            this._config = config;
        }

        public IActionResult Index()
        {
            //取得設定內容
            var appSetting = new AppSetting();
            _config.Bind(appSetting);
            Console.WriteLine("config {0}.", _config.GetConnectionString("MyDbConnection"));
            return View();
        }
       
    }
}
