using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;    
using Repositories;       

namespace Services
{
  
    public class EmployeeServices : IEmployeeServices
    {
       
        // Dùng readonly  gán một lần duy nhất trong constructor
        private readonly IEmployeeRepositories iEmployeeRepositories;

   
        public EmployeeServices()
        {
           
            iEmployeeRepositories = EmployeeRepositories.Instance;
        }

        public Employee? Login(string username, string password)
        {
                // kiem tra ronng
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null; 
            }

           
            return iEmployeeRepositories.CheckLogin(username, password);
        }
    }
}