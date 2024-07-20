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
    public class ProductService : IManager<Product>
    {
        private readonly ProductRepository _repository;
        public ProductService(ProductRepository pRepo)
        {
            _repository = pRepo;
        }

        public void Create(Product entity)
        {
            ProductValidator pval = new ProductValidator();
            ValidationResult result = pval.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();

                result.Errors.ForEach(x => sb.AppendLine(x.ErrorMessage));

                throw new Exception(sb.ToString());
            }

            _repository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var prd = _repository.GetByID(id);

            if (prd != null)
                _repository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public Product GetByID(Guid id)
        {
            var prd = _repository.GetByID(id);
            if (prd is null)
            {
                throw new Exception("Ürün bulunamadı.");
            }
            return prd;
        }

        public bool IfEntityExists(Product entity)
        {
            return _repository.IfEntityExists(p => p.ProductName == entity.ProductName);
        }

        public void Update(Product entity)
        {
            _repository.Update(entity);
        }
    }
}
