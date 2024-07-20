using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Validator
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage("Kategori alanı boş geçilemez.").MinimumLength(5).WithMessage("Kategori adı en az 5 karakter olmalıdır.").Matches("^[a-zA-ZğüşıöçĞÜŞİÖÇ\\s]+$").WithMessage("Lütfen sadece harf girişi yapınız.").MaximumLength(40).WithMessage("Kategori adı maximum 40 karakter olabilir.");

            RuleFor(c => c.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
        }
    }
}
