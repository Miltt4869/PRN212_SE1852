// See https://aka.ms/new-console-template for more information
using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;
FulltimeEmployess teo = new FulltimeEmployess();
teo.ID = 1;
teo.Name = "Teo";
Console.WriteLine(teo.calSalary());

PartimeEmployess ty = new PartimeEmployess();
ty.WorkingHour = 2;
ty.Name = "Tý khôn lỏ ";
ty.ID = 2;
Console.WriteLine("Lương của Tý= "+ ty.calSalary());


FulltimeEmployess obama = new FulltimeEmployess()
{
    ID = 100,
    Name = "Barac Obama",
    Birthday = new DateTime(1960, 1, 25),
    IdCard = "123"
};
PartimeEmployess Trump = new PartimeEmployess()
{
    ID = 200,
    IdCard = "456",
    Name = "Donal Trump",
    Birthday = new DateTime(1940, 12, 26),
    WorkingHour = 3
};
Console.WriteLine("-------------Thông tin của Trump-------------");
Console.WriteLine(Trump);