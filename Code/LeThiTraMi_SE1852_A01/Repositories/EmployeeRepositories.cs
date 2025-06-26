using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class EmployeeRepositories : IEmployeeRepositories
    {
        private static EmployeeRepositories? instance = null;
        private static readonly object instanceLock = new object();

        public static EmployeeRepositories Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new EmployeeRepositories();
                    }
                }
                return instance;
            }
        }
        

        // Constructor private không tạo mới tưf ngoài
        private EmployeeRepositories() { }

     
        public Employee? CheckLogin(string username, string password)
        {
            
            return EmployeeDAO.CheckLogin(username, password);
        }
    }
}
