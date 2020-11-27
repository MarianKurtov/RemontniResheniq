using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dim.Models;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using dim.Services;

namespace dim.Controllers
{
    public class HomeController : Controller
    {
        private readonly Cloudinary cloudinary;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,Cloudinary cloudinary)
        {
            this.cloudinary = cloudinary;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            var privacyModel = new PrivacyViewModel
            {
                Email = "marian11@abv.bg"
            };
            return this.View(privacyModel);
        }
        public IActionResult Appointment()
        {
            return View();
        }
        public IActionResult AboutUs()
        {

            return this.View();
        }
        public IActionResult Contact()
        {
            return this.View();
        }
        public IActionResult Gallery()
        {
            return this.View();
        }
        public IActionResult Repair()
        {
            return this.View();
        }
        public IActionResult Services()
        {
            return this.View();
        }
        
       
        [HttpPost]
        public async Task<IActionResult> Upload(ICollection<IFormFile> files)
        {
            
           var result = await CloudinaryService.UploadAsync(files, this.cloudinary);

            return Redirect("/Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
