using FluentValidation;
using KT.JwtProje.Entities.DTOs.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace KT.JwtProje.Business.ValidationRules
{
    public class AppUserLoginDtoValidator : AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginDtoValidator()
        {
            RuleFor(I => I.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(I => I.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
        }
    }
}
