using FluentValidation;
using KT.JwtProje.Entities.Concrete;
using KT.JwtProje.Entities.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace KT.JwtProje.Business.ValidationRules
{
    public class ProductUpdateDtoValidator : AbstractValidator<ProductUpdateDto>
    {
        public ProductUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(0, int.MaxValue);
            RuleFor(I => I.Name).NotEmpty().WithMessage("Ad alanı boş bırakılamaz.");
        }
    }
}
