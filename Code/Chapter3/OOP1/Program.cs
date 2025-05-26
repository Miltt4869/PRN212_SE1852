// See https://aka.ms/new-console-template for more information
using System.Text;
using OOP1;

Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nước nắm";
Console.OutputEncoding = Encoding.UTF8;
c1.PrintInfer();

Employee employee = new Employee();
/*employee._id = 1;
 * 
employee._name = "tèo "; */
// đề thay đoỏi giá trị của thuộc tính
employee.Id = 1;
employee.Name = "Tèo";
employee.Phone = "225";
employee.Email = "123@gmail.com";
// tự lấy gti thuộc tính
// tuẹ gọi prototype id
Console.WriteLine($"Employee ID = {employee.Id}");
// tự gọi ---- Name
Console.WriteLine($"Employee Name = {employee.Name}");
Console.WriteLine($"Employee Email = {employee.Email}");
Console.WriteLine($"Employee Phone = {employee.Phone}");
employee.PrintInfer();

// ngoài ra mọi lớp đối tượng có hàm toString() giống java
// để tuẹ động triệu gọi hàm 

Console.WriteLine("--------------------------------------------------");
Console.WriteLine(employee);

//vừa tạo đối tượng khởi tạo giá trị cho thuộc tính:
Employee employee2 = new Employee(2, "Tý Đại Bàng", "ty@yahoo.com", "0987654321");
//xuất thông tin của emp2
Console.WriteLine(employee2);
//hoặc ta có thể coding như sau:
Employee emp3 = new Employee()
{
    Id = 3,
    Name = "Tủn",
    Email = "tun@hotmail.com",
    Phone = "0897654321"
};
//xuất thông tin của emp3
Console.WriteLine(emp3);

