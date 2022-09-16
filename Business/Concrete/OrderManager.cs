using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal=orderDal;
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public List<Order> GetAllById(int id)
        {
            return _orderDal.GetAll(o=>o.OrderId==id);
        }
    }
}
