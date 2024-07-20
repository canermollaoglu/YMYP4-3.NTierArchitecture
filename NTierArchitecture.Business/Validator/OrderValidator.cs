using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Validator
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(o => o.IsActive)
                .NotEmpty()
                .WithMessage("Aktif pasif alanı boş olamaz.");

            RuleFor(o => o.CustomerID)
                .NotEmpty()
                .WithMessage("Müşteri no boş geçilemez.");

            RuleFor(o => o.EmployeeID)
               .NotEmpty()
               .WithMessage("Çalışan no boş geçilemez.");
        }
    }
}
