using FluentValidation.Results;
using NTierArchitecture.Business.Validator;
using NTierArchitecture.DataAccess.Abstractions;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Services
{
    public class SupplierService : IManager<Supplier>
    {
        private readonly SupplierRepository _supplierRepository;
        public SupplierService(SupplierRepository sRepo)
        {
            _supplierRepository = sRepo;
        }
        public void Create(Supplier entity)
        {
            SupplierValidator sval = new SupplierValidator();
            ValidationResult result = sval.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join(",", result.Errors));
            }
            _supplierRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var sp = _supplierRepository.GetByID(id);
            if (sp != null)
                _supplierRepository.Delete(id);
        }

        public IEnumerable<Supplier> GetAll()
        {
            return _supplierRepository.GetAll();
        }

        public Supplier GetByID(Guid id)
        {
            var sp = _supplierRepository.GetByID(id);
            if (sp == null)
            {
                throw new Exception("Supplier bulunamadı.");
            }
            return sp;

        }

        public bool IfEntityExists(Supplier entity)
        {
            return _supplierRepository.IfEntityExists(s => s.CompanyName == entity.CompanyName);
        }

        public void Update(Supplier entity)
        {
            _supplierRepository.Update(entity);
        }
    }
}
