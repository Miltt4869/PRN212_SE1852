// See https://aka.ms/new-console-template for more information
using System.Text;

string do_math(double a, double b, string op)
{
    string result = "";
    switch (op)
    {
        case "+":
            result = a +"+"+ b + "=" + (a+b); 
            break;
        case "-":
            result = a + "-" + b + "=" + (a - b);
            break;
        case "*":
            result = a + "*" + b + "=" + (a * b);
            break;
        case "/":
            if (b == 0)
            {
                result = "Mẫu số không hợp lệ";
            }
            else {
                result = a + "/" + b + "=" + (a / b);
            }
            break;  
        default:
            result = "Xin vui lòng nhập đúng";
            break;

    }
    return result;
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Nhap a: ");
double a =Double.Parse(Console.ReadLine());
Console.WriteLine("Nhap b: ");
double b =Double.Parse(Console.ReadLine());
Console.WriteLine("Nhap pheps toans(+,-,*,/): ");
string op = Console.ReadLine();
string result = do_math(a, b, op);
Console.WriteLine(result);

Console.ReadLine();
