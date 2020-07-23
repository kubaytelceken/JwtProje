using FluentValidation;
using KT.JwtProje.Entities.DTOs.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace KT.JwtProje.Business.ValidationRules
{
    public class AppUserAddDtoValidator : AbstractValidator<AppUserAddDto>
    {
        public AppUserAddDtoValidator()
        {
            RuleFor(I => I.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez.");
            RuleFor(I => I.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
            RuleFor(I => I.FullName).NotEmpty().WithMessage("Ad-soyad alanı boş geçilemez.");
        }
    }
}
