using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using dim.Data;
using dim.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Web;

namespace dim.Services
{
    public class CloudinaryService
    {
        public static async Task<Dictionary<string,string>> UploadAsync(ICollection<IFormFile> formFile, Cloudinary cloudinary)
        {
           var paths = new Dictionary<string,string>();

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
                    var name = result.OriginalFilename.ToString();
                    paths.Add(name,result.Uri.AbsoluteUri.ToString()); //Взимаме абсолютния път на качените файлове(пътя до Cloudinary)
                    ;
                };
            }
            return paths;
        }
    }
}
