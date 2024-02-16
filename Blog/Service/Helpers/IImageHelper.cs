using Entity.DTO.Photo;
using Entity.ImageOfType;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Helpers
{
    public interface IImageHelper
    {
        Task<ImageUploadedDto> Upload(string name, IFormFile imageFile, ImageType imageType, string folderName = null);
        void Delete(string imageName);
    }
}