using Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validations
{
    public class UserValidator : AbstractValidator<AppUser>
    {
        public UserValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Lütfen İsim Kısmını Boş Bırakmayınız!");
            RuleFor(x => x.FirstName).MinimumLength(2).WithMessage("Lütfen {MinLength} Karakterden Daha Fazla Veri Girişi Yapınız!");
            RuleFor(x => x.FirstName).MaximumLength(20).WithMessage("Lütfen 20 Karakterden Daha Az Veri Girişi Yapınız!");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Lütfen Soy İsim Kısmını Boş Bırakmayınız!");
            RuleFor(x => x.LastName).MinimumLength(1).WithMessage("Lütfen {MinLength} Karakterden Daha Fazla Veri Girişi Yapınız!");
            RuleFor(x => x.LastName).MaximumLength(20).WithMessage("Lütfen 20 Karakterden Daha Az Veri Girişi Yapınız!");

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Lütfen Numara Kısmını Boş Bırakmayınız!");
            RuleFor(x => x.PhoneNumber).MinimumLength(11).WithMessage("Lütfen Geçerli Bir Numara Giriniz!");
            RuleFor(x => x.PhoneNumber).MaximumLength(11).WithMessage("Lütfen Geçerli Bir Numara Giriniz!");
        }
    }
}