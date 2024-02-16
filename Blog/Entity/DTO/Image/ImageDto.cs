using Entity.DTO.Article;
using Entity.DTO.Category;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO.Photo
{
    public class ImageDto
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public ICollection<ArticleDto> Articles { get; set; }
        public ICollection<AppUser> Users { get; set; }
        public DateTime CreatedDate { get; set; }  
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        
    }
}