using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer; 

namespace Repositories
{
    
    public class CustomerRepositories : ICustomerRepositories
    {
        
        private static CustomerRepositories? instance = null;
        private static readonly object instanceLock = new object();

        public static CustomerRepositories Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerRepositories();
                    }
                }
                return instance;
            }
        }
       

      
        private CustomerRepositories() { }

        public List<Customer> SearchCustomers(string keyword)
        {
            return CustomerDAO.SearchCustomers(keyword);
        }


        public Customer? CheckLogin(string phone)
        {
            return CustomerDAO.CheckLogin(phone);
        }
        public List<Customer> GetAllCustomers()
        {
       
            return CustomerDAO.GetAllCustomers();
        }

        public Customer? GetCustomerById(int id)
        {
       
            return CustomerDAO.GetCustomerById(id);
        }

        public void AddCustomer(Customer customer)
        {
          
            CustomerDAO.AddCustomer(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
           
            CustomerDAO.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            
            CustomerDAO.DeleteCustomer(id);
        }
    }
}