
using OOP2;
using OOP2_Reuse_asLibrary;
FulltimeEmployess e1 = new FulltimeEmployess()

{
    ID = 1,
    Name = "Tèo",
    Birthday = new DateTime(1960, 1, 1)
};
Console.WriteLine("----Thông tin E1----");
Console.WriteLine(e1);
Console.WriteLine("AGE===> " + e1.TinhTuoi());

