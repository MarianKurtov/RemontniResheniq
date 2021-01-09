using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dim.Models;
using CloudinaryDotNet;
using Microsoft.AspNetCore.Http;
using dim.Services;
using dim.Data;
using Microsoft.Extensions.Configuration;

namespace dim.Controllers
{
    public class HomeController : Controller
    {
        private readonly Cloudinary cloudinary;
        private readonly ApplicationDbContext dbContext;
        private readonly IMailServices mailServices;
        private readonly IConfiguration configuration;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IConfiguration configuration, ILogger<HomeController> logger,Cloudinary cloudinary,ApplicationDbContext dbContext,IMailServices mailServices)
        {
            this.cloudinary = cloudinary;
            this.dbContext = dbContext;
            this.mailServices = mailServices;
            this.configuration = configuration;
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
        public IActionResult Error()
        {
            return this.View();
        }

        
        public IActionResult Gallery()
        {
            return this.View();
        }
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
        public IActionResult GalleryStuklar()
        {
            return this.View();
        }
        public IActionResult GallerySifoni()
        {
            return this.View();
        }
        public IActionResult GalleryDurvodelec()
        {
            return this.View();
        }
        public IActionResult SuccessfullySendEmail()
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

        [HttpPost]
        public async Task<IActionResult> Contact(ContactFormViewModel model) // Подаваме ViewModel-a като параметър(списъка от параметрите, които имаме в класа)
        {
            ; 
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var email = new SendGridServices(configuration);
            await email.SendMailAsync(model.Email,model.Name,model.Content.Substring(0,10), "remontniresheniq@gmail.com","Marian",model.Content,$"<h1>{model.Content}<h1>",model.Phone);

            return this.Redirect("/Home/SuccessfullySendEmail");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult ErrorDev()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
