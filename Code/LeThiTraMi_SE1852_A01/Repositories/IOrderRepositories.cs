using System.Collections.Generic;
using BusinessObjects;

namespace Repositories
{
    public interface IOrderRepositories
    {
   
        List<Order> GetAllOrders();


        Order? GetOrderById(int id);

      
        List<OrderDetail> GetOrderDetails(int orderId);

        void AddOrder(Order order, List<OrderDetail> details);
    }
}