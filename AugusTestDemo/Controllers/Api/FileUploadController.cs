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
            _uploadImagePath = _webHostEnvironment.WebRootPath + "/TestImage";
        }

        [HttpPost]
        public async Task<IActionResult> Post(IFormFile file)
        {
            var size = file.Length;
            try
            {
                if (!Directory.Exists(_uploadImagePath))
                {
                    //建立資料夾
                    DirectoryInfo di =  Directory.CreateDirectory(_uploadImagePath);
                    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(_uploadImagePath));
                }

                // 要存放的位置
                var savePath = $"{_uploadImagePath}/{file.FileName}";
                if (file.Length > 0)
                {
                    using (var stream = new FileStream(savePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            
            return Ok(new { count = 1 , size , path = $"/TestImage/{file.FileName}" });
        }

    }
}
