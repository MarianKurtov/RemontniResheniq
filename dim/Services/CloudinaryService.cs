using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using dim.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Web;

namespace dim.Services
{
    public class CloudinaryService
    {
        private readonly ApplicationDbContext dbContext;

        public CloudinaryService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public static async Task<List<string>> UploadAsync(ICollection<IFormFile> formFile, Cloudinary cloudinary)
        {
            List<string> paths = new List<string>();

            foreach (var file in formFile)
            {
                byte[] imageInByteArray;

                using (var memoryStream = new MemoryStream())
                {
                    await file.CopyToAsync(memoryStream);//копира съдържанието в фийла, който му подаваме
                    imageInByteArray = memoryStream.ToArray(); //байт масива взима съдържанието от стриима
                }

                using (var memory = new MemoryStream(imageInByteArray))
                {
                    var uploadParams = new ImageUploadParams()
                    {
                        File = new FileDescription(file.FileName, memory) //изисква името на файла и файла като стриим, за това отваряме using 
                    };
                    var result = await cloudinary.UploadAsync(uploadParams);
                    var name = (result.PublicId).ToString() +"."+ (result.Format).ToString(); 
                    paths.Add(result.Uri.AbsoluteUri); //Взимаме абсолютния път на качените файлове(пътя до Cloudinary)
                    ;
                };
            }
            return paths;
        }
    }
}
