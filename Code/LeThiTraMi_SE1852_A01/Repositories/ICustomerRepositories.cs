using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public interface ICustomerRepositories
    {
        List<Customer> SearchCustomers(string keyword);

        Customer? CheckLogin(string phone);
      
        List<Customer> GetAllCustomers();

     
        Customer? GetCustomerById(int id);


        void AddCustomer(Customer customer);

        void UpdateCustomer(Customer customer);

 
        void DeleteCustomer(int id);
       

    }
}
