using dim.Data;
using dim.Models;
using System.Collections.Generic;

namespace dim.Services
{
    public class PhotoPathServices
    {
        private readonly ApplicationDbContext dbContext;

        public PhotoPathServices(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void WriteInDatabase(Dictionary<string,string> photos)
        {
            foreach (var (key,value) in photos)
            {
                var currentPhoto = new Photo
                {
                    Name = key,
                    DefoultPath = value
                };
                //dbContext.Photos.Add(currentPhoto); Запаметяване на снимката в базата
                //dbContext.SaveChanges();
            }
        }
    }
}
