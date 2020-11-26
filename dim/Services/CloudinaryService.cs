using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace dim.Services
{
    public class CloudinaryService
    {
        public static async Task UploadAsync(ICollection<IFormFile> formFile, Cloudinary cloudinary)
        {
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
                    await cloudinary.UploadAsync(uploadParams);
                };
            }
        }
    }
}
