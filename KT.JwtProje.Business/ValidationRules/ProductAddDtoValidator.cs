using FluentValidation;
using KT.JwtProje.Entities.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace KT.JwtProje.Business.ValidationRules
{
    public class ProductAddDtoValidator : AbstractValidator<ProductAddDto>
    {
        public ProductAddDtoValidator()
        {
            RuleFor(I => I.Name).NotEmpty().WithMessage("İsim boş bırakılamaz");
        }
    }
}
