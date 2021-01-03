using dim.Data;
using System.Collections.Generic;
using System.Linq;

namespace dim.Services
{
    public class ListPhotoServices
    {
        private readonly ApplicationDbContext db;
        private readonly Dictionary<string, string> currentGallery;

        public ListPhotoServices(ApplicationDbContext db)
        {
            this.db = db;
        }
        public Dictionary<string,string> Photos(string nameOfGallery)
        {
            foreach (var photo in db.Photos.Where(x=>x.Name.Contains(nameOfGallery)))
            {
                currentGallery.Add(photo.Name, photo.DefoultPath); // имената и снимките по име на галерията 
            }
            return currentGallery;
        }
    }
}
