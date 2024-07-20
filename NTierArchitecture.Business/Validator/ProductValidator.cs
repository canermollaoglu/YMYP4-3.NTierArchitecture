using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Validator
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName)
                .NotEmpty()
                .WithMessage("Ürün adı boş geçilemez.");

            RuleFor(p=>p.UnitPrice)
                .NotEmpty()
                .WithMessage("Ürün fiyatı boş geçilemez.")
                .GreaterThan(0)
                .WithMessage("Ürün fiyatı sıfırdan büyük olmalıdır.");

            RuleFor(p=>p.Category)
                .NotNull()
                .WithMessage("Ürün kategorisi boş olamaz.");

            RuleFor(p=>p.Supplier)
                .NotNull()
                .WithMessage("Ürün tedarikçisi boş olamaz.");
        }
    }
}
