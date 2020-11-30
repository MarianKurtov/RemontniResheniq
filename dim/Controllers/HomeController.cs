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
using dim.Data;

namespace dim.Controllers
{
    public class HomeController : Controller
    {
        private readonly Cloudinary cloudinary;
        private readonly ApplicationDbContext dbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,Cloudinary cloudinary,ApplicationDbContext dbContext)
        {
            this.cloudinary = cloudinary;
            this.dbContext = dbContext;
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
            PhotoPathServices addToDatabase = new PhotoPathServices(dbContext);
            addToDatabase.WriteInDatabase(result);

            return Redirect("/Home");
        }


        public IActionResult Gallery()
        {
            return this.View();
        }
        // Gallerys
        public IActionResult GalleryIztok()
        {
            return this.View();
        }
        public IActionResult GalleryCenter1()
        {
            return this.View();
        }
        public IActionResult GalleryCenter2()
        {
            return this.View();
        }
        public IActionResult GallerySlatina()
        {
            return this.View();
        }
        public IActionResult GalleryLozenec()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
