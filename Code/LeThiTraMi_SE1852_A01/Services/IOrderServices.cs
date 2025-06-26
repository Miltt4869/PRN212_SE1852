using System.Collections.Generic;
using BusinessObjects;

namespace Services
{
    public interface IOrderServices
    {

        List<Order> GetAllOrders();


        Order? GetOrderById(int id);

    
        List<OrderDetail> GetOrderDetails(int orderId);

        void AddOrder(Order order, List<OrderDetail> details);
    }
}