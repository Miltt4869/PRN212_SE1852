using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{
   
    public static class CustomerDAO
    {
        private static readonly List<Customer> Customers = new List<Customer>();

      
        static CustomerDAO()
        {
            InitializeDataset();
        }

        private static void InitializeDataset()
        {
            if (!Customers.Any())
            {
                Customers.AddRange(new List<Customer>
        {
            new Customer { CustomerID = 1, CompanyName = "Công ty Dịch vụ Vệ sinh An Khang", ContactName = "Lê Văn Anh",      Phone = "0935123456" },
            new Customer { CustomerID = 2, CompanyName = "Nhà sách Văn Quỳnh",              ContactName = "Trương Thị Mai",    Phone = "0912345678" },
            new Customer { CustomerID = 3, CompanyName = "Quán Cơm Bình Dân 24H",          ContactName = "Đỗ Thị Lan",        Phone = "0976123987" },
            new Customer { CustomerID = 4, CompanyName = "Garage Ôtô An Phú",              ContactName = "Phạm Văn Hùng",     Phone = "0987234561" },
            new Customer { CustomerID = 5, CompanyName = "Shop Thời Trang Nắng Mai",       ContactName = "Lê Thị Trà Mi",    Phone = "0388278354" }

        });
            }
        }


      
        public static Customer? CheckLogin(string phone )
        {
            return Customers.FirstOrDefault(c => c.Phone == phone  );
        }

       
        public static List<Customer> GetAllCustomers()
        {
            return Customers;
        }

        public static Customer? GetCustomerById(int id)
        {
            return Customers.FirstOrDefault(c => c.CustomerID == id);
        }

        public static void AddCustomer(Customer customer)
        {
         
            customer.CustomerID = Customers.Max(c => c.CustomerID) + 1;
            Customers.Add(customer);
        }

        public static void UpdateCustomer(Customer customer)
        {
            Customer? existingCustomer = Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            if (existingCustomer != null)
            {
         
                existingCustomer.CompanyName = customer.CompanyName;
                existingCustomer.ContactName = customer.ContactName;
                existingCustomer.ContactTitle = customer.ContactTitle;
                existingCustomer.Address = customer.Address;
                existingCustomer.Phone = customer.Phone;
            }
        }

        public static void DeleteCustomer(int id)
        {
            Customer? customerToRemove = Customers.FirstOrDefault(c => c.CustomerID == id);
            if (customerToRemove != null)
            {
                Customers.Remove(customerToRemove);
            }
        }
        public static List<Customer> SearchCustomers(string keyword)
        {
            return Customers
                .Where(c => c.CompanyName.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                            || c.ContactName.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                            || c.Phone.Contains(keyword))
                .ToList();
        }

    }
}