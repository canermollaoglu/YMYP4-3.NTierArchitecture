using FluentValidation.Results;
using NTierArchitecture.Business.Validator;
using NTierArchitecture.DataAccess.Abstractions;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Services
{
    public class CategoryService : IManager<Category>
    {
        //readonly
        //readonly anahtar kelimesi, bir sınıf üyesinin yalnızca oluşturulduğu zaman ve yapıcı metodda değer atanabileceği anlamına gelir. Bu nedenle, _categoryRepository alanını readonly olarak işaretlemek, alanın yalnızca sınıfın kurucu metodunda atanabileceğini ve daha sonra başka bir yerde değiştirilemeyeceğini belirtir.

        private readonly CategoryRepository _categoryRepository;

        public CategoryService(CategoryRepository catRepo)
        {
            _categoryRepository = catRepo;
        }
        public void Create(Category entity)
        {
            CategoryValidator cval = new();
            ValidationResult result = cval.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join(",", result.Errors));
            }

            _categoryRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            //isActive=true olan Kategori silinemez.

            var cat = _categoryRepository.GetByID(id);

            if (cat.IsActive)
            {
                throw new Exception("Aktif olan bir kategori silinemez.");
            }
            _categoryRepository.Delete(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetByID(Guid id)
        {
            return _categoryRepository.GetByID(id);
        }

        public void Update(Category entity)
        {
            if (entity != null)
            {
                _categoryRepository.Update(entity);
            }
        }

        public bool IfEntityExists(string name)
        {
            return _categoryRepository.IfEntityExists(c => c.CategoryName == name);
        }

        public bool IfEntityExists(Category entity)
        {
            return _categoryRepository.IfEntityExists(c => c.CategoryName == entity.CategoryName);
        }
    }
}
