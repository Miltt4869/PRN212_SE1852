// See https://aka.ms/new-console-template for more information
using System.Text;
using OOP3;

Console.OutputEncoding = Encoding.UTF8;

int n1 = 5;
int n2 = 10;
Console.WriteLine("Tổng n1 = " + n1.Tongtu1toiN());
Console.WriteLine("Tổng n2 = " + n2.Tongtu1toiN());

int[] M = new int[10];
M.TaoMangNgauNhien();
Console.WriteLine("Mảng trước khi sắp xếp: ");
M.XuatMang();
M.SapxepTangdan();
Console.WriteLine("Mảng sau khi sắp xếp:");
M.XuatMang();