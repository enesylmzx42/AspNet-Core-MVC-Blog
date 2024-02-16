using Entity.DTO.Category;
using Entity.DTO.Photo;
using Entity.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entity.DTO.Article
{
    public class ArticleUpdateDto
    {
        public ImageDto Image { get; set; }
        public IFormFile? Photo { get; set; }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }      
        public IList<CategoryDto> Categories { get; set; }
    }
}
