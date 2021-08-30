using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AugusTestDemo.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    public class FileUploadController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly string _uploadImagePath;

        public FileUploadController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            _uploadImagePath = _webHostEnvironment.WebRootPath + "/Image";
        }

        [HttpPost]
        public async Task<IActionResult> Post(IFormFile file)
        {
            var size = file.Length;
            // 要存放的位置
            var savePath = $"{_uploadImagePath}/{file.FileName}";
            if (file.Length > 0)
            {
                using (var stream = new FileStream(savePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }

            return Ok(new { count = 1 , size , path = $"~/Image/{file.FileName}" });
        }

    }
}
