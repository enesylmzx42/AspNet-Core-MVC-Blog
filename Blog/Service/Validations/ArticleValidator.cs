using Entity.Entities;
using FluentValidation;
using System;


namespace Service.Validations
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Blog Başlığını Boş Bırakmayınız!");
            RuleFor(x => x.Title).MaximumLength(30).WithMessage("Lütfen 30 Karakterden Daha Az Veri Girişi Yapınız!");
            RuleFor(x => x.Title).MinimumLength(2).WithMessage("Lütfen {MinLength} Karakterden Daha Fazla Veri Girişi Yapınız!");
            


            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen Dosya Yolunu Boş Bırakmayınız!");


            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen Blog İçeriğini Boş Bırakmayınız!");
            RuleFor(x => x.Content).MaximumLength(200).WithMessage("Lütfen 200 Karakterden Daha Az Veri Girişi Yapınız!");
            RuleFor(x => x.Content).MinimumLength(10).WithMessage("Lütfen {MinLength} Karakterden Daha Fazla Veri Girişi Yapınız!");
            
        }
    }
}