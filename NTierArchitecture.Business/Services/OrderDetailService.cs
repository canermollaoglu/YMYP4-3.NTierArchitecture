using FluentValidation.Results;
using NTierArchitecture.Business.Validator;
using NTierArchitecture.DataAccess.Abstractions;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System.Text;

namespace NTierArchitecture.Business.Services
{
    public class OrderDetailService : IManager<OrderDetail>
    {
        private readonly OrderDetailRepository _orderDetailRepository;
        public OrderDetailService(OrderDetailRepository orderRepo)
        {
            _orderDetailRepository = orderRepo;
        }

        public void Create(OrderDetail entity)
        {
            OrderDetailValidator oVal = new OrderDetailValidator();
            ValidationResult result = oVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(x => sb.AppendLine(x.ErrorMessage));
                throw new Exception(sb.ToString());
            }
            _orderDetailRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var od = _orderDetailRepository.GetByID(id);
            if (od != null)
            {
                _orderDetailRepository.Delete(id);
            }
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return _orderDetailRepository.GetAll();
        }

        public OrderDetail GetByID(Guid id)
        {
            var od = _orderDetailRepository.GetByID(id);
            if (od == null)
            {
                throw new Exception("Sipariş Bulunamadı.");
            }
            return od;
        }

        public void Update(OrderDetail entity)
        {
            _orderDetailRepository.Update(entity);
        }

        //Bu metoda alternatif olarak productID ve orderID olarak kontrol sağalayacak bir yapı oluşturulacak.
        public bool IfEntityExists(string name)
        {
            return _orderDetailRepository.IfEntityExists(c => c.Id == Guid.Parse(name));
        }

        public bool IfEntityExists(OrderDetail entity)
        {
            return _orderDetailRepository.IfEntityExists(c => c.ProductID==entity.ProductID && c.OrderID==entity.OrderID);
        }
    }
}
