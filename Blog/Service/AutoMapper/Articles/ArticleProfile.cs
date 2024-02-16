using AutoMapper;
using Entity.DTO.Article;
using Entity.DTO.Photo;
using Entity.DTO.User;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AutoMapper.Articles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleDto, Article>().ReverseMap();
            CreateMap<ArticleUpdateDto, Article>().ReverseMap();
            CreateMap<ArticleUpdateDto, ArticleDto>().ReverseMap();
            CreateMap<ArticleAddDto, Article>().ReverseMap();

            // CreateMap<ArticleListDto, Article>().ReverseMap();
            //CreateMap<ArticleListDto, ArticleDto>().ReverseMap();

            CreateMap<Image, ImageDto>();
            CreateMap<Entity.Entities.Image, Entity.DTO.Photo.ImageDto>();

            CreateMap<AppUser, UserProfileDto>();
            CreateMap<Entity.Entities.AppUser, Entity.DTO.User.UserProfileDto>();



        }

    }
}
