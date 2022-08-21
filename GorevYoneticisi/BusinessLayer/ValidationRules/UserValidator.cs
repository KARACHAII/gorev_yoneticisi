using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {

            RuleFor(x => x.FirstName).NotEmpty().WithMessage("İsim boş geçilemez");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyisim boş geçilemez");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(x => x.UserPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez");
            RuleFor(x => x.UserPassword).MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalıdır");
            RuleFor(x => x.UserName).MinimumLength(5).WithMessage("Şifre en az 5 karakter olmalıdır");
            RuleFor(x => x.LastName).MinimumLength(2).WithMessage("en az 2 karakter olmalıdır");
            RuleFor(x => x.LastName).MinimumLength(2).WithMessage("en az 2 karakter olmalıdır");
        }
    }
}
