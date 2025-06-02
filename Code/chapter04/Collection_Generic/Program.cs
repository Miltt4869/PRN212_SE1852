/*
 *  ứng dụng generic để quản lý nhân viên, thực hiện thao tác CRUD
 *  xem, thêm,sửa xóa
 */

// Câu 1: Tạo 5 vn trong có 4 fulltime 1 partime
using System.Text;
using OOP2;

List<Employess> employess = new List<Employess>();

#region dữ liệu fulltime

FulltimeEmployess fel = new FulltimeEmployess()
{
    ID = 1,
    Name = "Lê Văn C",
    IdCard = "768",
    Birthday = new DateTime(1966, 5, 15)
};
employess.Add(fel);
FulltimeEmployess fel1 = new FulltimeEmployess()
{
    ID = 2,
    Name = "Trần Văn B",
    IdCard = "456",
    Birthday = new DateTime(1986, 6, 15)
};
employess.Add(fel1);
FulltimeEmployess fel2 = new FulltimeEmployess()
{
    ID = 3,
    Name = "Nguyễn Thị N",
    IdCard = "169",
    Birthday = new DateTime(1996, 5, 14)
};
employess.Add(fel2);
FulltimeEmployess fel3 = new FulltimeEmployess()
{
    ID = 4,
    Name = "Võ Thị T",
    IdCard = "153",
    Birthday = new DateTime(1996, 5, 18)
};
employess.Add(fel3);

#endregion dữ liệu fulltime

#region

PartimeEmployess partime = new PartimeEmployess()
{
    ID = 5,
    Name = "Nguyễn Chi L",
    Birthday = new DateTime(2004, 10, 18),
    IdCard = "334",
    WorkingHour = 5
};
employess.Add(partime);

#endregion

// Câu 2: Xuất toàn bộ thông tin nhân sự
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Thong tin toàn bộ nhân sự");
// cách 1: Dùng expresstion body (landra exp)
employess.ForEach(e => Console.WriteLine(e));

// Cachs 2: dùn for thông thường
Console.WriteLine("Cách thông thường");
foreach (var e in employess)
{
    Console.WriteLine(e);
}
// Câu 3: Sắp xếp nhân viên theo năm sinh tằng dần
// cũng là R-Read/Retrive
for (int i = 0; i < employess.Count; i++)
{
    for (int j = i + 1; j < employess.Count; j++)
    {
        Employess ei = employess[i];
        Employess ej = employess[j];
        if (ei.Birthday < ej.Birthday)
        {
            employess[i] = ei;
            employess[j] = ej;
        }
    }
}
Console.WriteLine("--------------Employess sau khi sắp xếp----------------\t");
employess.ForEach(e => Console.WriteLine(e));

//  Câu 4: sửa nhân viên
/*Console.WriteLine("Nhập ID cần sửa: ");
int id = int.Parse(Console.ReadLine());
foreach (Employess e in employess)
{
    if (id == e.ID)
    {
        Console.WriteLine("Nhập new Name: ");
        e.Name = Console.ReadLine();
        Console.WriteLine("Nhập new IDcard:");
        e.IdCard = Console.ReadLine();
        Console.WriteLine("Nhập new Birthday (mm/DD/YYYY):");
        e.Birthday = DateTime.Parse(Console.ReadLine());

        break;
    }
    else
    {
        Console.WriteLine("kHÔNG TÌM THẤY ID ĐÃ NHẬP....");
    }
}
employess.ForEach(e => Console.WriteLine(e));

*/
// Câu 5: xóa
Console.WriteLine("Nhập ID cần xóa: ");
int Id = int.Parse(Console.ReadLine());
bool found = false;
foreach (Employess e in employess)
{
    if (Id.Equals(e.ID))
    {

        employess.Remove(e);
        Console.WriteLine("Đã xóa thành công"); 
        found = true;
        break;
       
    }
}
if (found==false)
{
    Console.WriteLine("không tìm thấy ID...");
}

employess.ForEach(e => Console.WriteLine(e));