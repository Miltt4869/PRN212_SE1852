// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Hello, World!");
string ho = "Nguyễn";
string tenlot = "Thị";
string ten = "Tèo";
string tenfull = ho + " "+tenlot + " "+ten;
Console.WriteLine(tenfull);
StringBuilder sb = new StringBuilder();  // cọng chỗi sẽ chậm, nên dùng string builder sẽ nhanh hơn
sb.Append(ho);
sb.Append(" ");
sb.Append(tenlot);
sb.Append(" ");
sb.Append(ten);
