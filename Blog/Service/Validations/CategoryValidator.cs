using Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validations
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen kategori İsmini Boş Bırakmayınız!");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Lütfen 20 Karakterden Daha Az Veri Girişi Yapınız!");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen {MinLength} Karakterden Daha Fazla Veri Girişi Yapınız!");

        }

      
    }
}