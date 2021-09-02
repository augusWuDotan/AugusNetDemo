using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AugusTestDemo.Models.Bean;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AugusTestDemo.Controllers
{
    public class BackstageLoginController : Controller
    {

        private readonly ILogger<BackstageLoginController> _logger;
        private IConfiguration _config;

        public BackstageLoginController(ILogger<BackstageLoginController> logger, IConfiguration config)
        {
            _logger = logger;
            this._config = config;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LoginWithAdmin([Bind("Account,Password")] AdminLogin adminLogin)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Account: {0} Password:{1}", adminLogin.Account, adminLogin.Password);
                return RedirectToAction(nameof(Index), "BackstageLogin");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
