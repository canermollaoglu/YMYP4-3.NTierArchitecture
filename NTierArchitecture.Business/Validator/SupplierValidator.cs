using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Validator
{
    public class SupplierValidator : AbstractValidator<Supplier>
    {
        public SupplierValidator()
        {
            RuleFor(s => s.CompanyName)
                .NotEmpty()
                .WithMessage("Tedarikçi adı boş geçilemez.");

            RuleFor(s => s.ContactTitle)
                .NotEmpty()
                .WithMessage("İlgili kişi adı boş geçilemez.");

            RuleFor(s => s.Phone)
                .NotEmpty()
                .WithMessage("Telefon alanı boş geçilemez.")
                .Matches("[0-9]")
                .WithMessage("Lütfen uygun bir telefon numarası giriniz.")
                .MinimumLength(11)
                .MaximumLength(11)
                .WithMessage("Telefon no 11 karakter olmalıdır");


        }
    }
}
