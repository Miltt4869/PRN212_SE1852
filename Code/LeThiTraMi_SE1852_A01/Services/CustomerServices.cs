using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;    
using Repositories;     

namespace Services
{
  
    public class CustomerServices : ICustomerServices
    {
        
        private readonly ICustomerRepositories iCustomerRepositories;

      
        public CustomerServices()
        {
          
            iCustomerRepositories = CustomerRepositories.Instance;
        }
        public Customer? Login(string phone)
        {
          
            if (string.IsNullOrEmpty(phone))
            {
                return null;
            }

          
            return iCustomerRepositories.CheckLogin(phone);
        }

        public List<Customer> GetAllCustomers()
        {
            return iCustomerRepositories.GetAllCustomers();
        }

        public void AddCustomer(Customer customer)
        {
            iCustomerRepositories.AddCustomer(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            iCustomerRepositories.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            iCustomerRepositories.DeleteCustomer(id);
        }

        public List<Customer> SearchCustomers(string keyword)
        {
            return iCustomerRepositories.SearchCustomers(keyword);
        }

    }
}