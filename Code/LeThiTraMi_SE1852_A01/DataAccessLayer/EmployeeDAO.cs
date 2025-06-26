using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{

    public static class EmployeeDAO
    {
      
        private static readonly List<Employee> Employees = new List<Employee>();

        //  Sử dụng 'static constructor' (hàm dựng tĩnh)
        // Hàm này sẽ tự động chạy một lần duy nhất khi lớp được gọi lần đầu tiên.
        // Đây là nơi hoàn hảo để khởi tạo dữ liệu.
        static EmployeeDAO()
        {
            InitializeDataset();
        }

       
        private static void InitializeDataset()
        {
           
            if (!Employees.Any())
            {
                Employees.Add(new Employee() { EmployeeID = 1, Name = "Admin", UserName = "admin", Password = "1234", JobTitle = "Manager" });
                Employees.Add(new Employee() { EmployeeID = 2, Name = "John Doe", UserName = "john", Password = "abcd", JobTitle = "Staff" });
                Employees.Add(new Employee() { EmployeeID = 3, Name = "Trà Mi", UserName = "mi", Password = "123", JobTitle = "Manager" });
            }
        }

    
        public static Employee? CheckLogin(string username, string password) 
        {
            return Employees.FirstOrDefault(e => e.UserName == username && e.Password == password);
        }

        public static List<Employee> GetAll() => Employees;
    }
}