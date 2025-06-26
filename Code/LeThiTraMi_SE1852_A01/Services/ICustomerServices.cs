using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Services
{
    public interface ICustomerServices
    {
        Customer? Login(string phone);
        List<Customer> GetAllCustomers();

    
        void AddCustomer(Customer customer);

      
        void UpdateCustomer(Customer customer);


        void DeleteCustomer(int id);

        List<Customer> SearchCustomers(string keyword);

    }
}
