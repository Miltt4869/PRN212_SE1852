using OOP4_Distionary;

Category laptop = new Category();
laptop.Id = 1;
laptop.Name = "Danh muc laptop";

Product dell = new Product()
{
    Id = 1,
    Name = "Dell1",
    Price = 15000000,
    Quantity = 30
};
laptop.AddProduct(dell);

Product dell2 = new Product()
{
    Id = 2,
    Name = "Dell2",
    Price = 12000000,
    Quantity = 10
};
laptop.AddProduct(dell2);
Product HP1 = new Product()
{
    Id = 3,
    Name = "HP1",
    Price = 17000000,
    Quantity = 5
};
laptop.AddProduct(HP1);

Product HP2 = new Product()
{
    Id = 4,
    Name = "HP2",
    Price = 17000000,
    Quantity = 7
};
laptop.AddProduct(HP2);

Console.WriteLine("Danh sach san pham cua danh muc Laptop: ");
laptop.PrintsAllProduct();

Console.WriteLine("Moi banj nhap cai ma san pham muon tim: ");
int pid = int.Parse(Console.ReadLine());
Product p = laptop.GetProduct(pid);
if (p != null)
{
    Console.WriteLine("Khong tim thay san pham..." + pid);
}
else
{
    Console.WriteLine("Da tim thay san pham co ma = " + pid);
    Console.WriteLine(p);
}
Console.WriteLine("Danh sach chua sap xep: ");
laptop.PrintsAllProduct();

Dictionary<int, Product> sort = laptop.SortProduct();
Console.WriteLine("Danh sach sau khi sap xep: ");
foreach (KeyValuePair<int, Product> item in sort)
{
    Product x = item.Value;
    Console.WriteLine(x);
}

// sap xep gia tang, cung gia thi quantity giam
Dictionary<int, Product> sort2 = laptop.Complexsort();
Console.WriteLine("Danh sach sau khi sap xep: ");
foreach (KeyValuePair<int, Product> item in sort2)
{
    Product x = item.Value;
    Console.WriteLine(x);
}

// sua
Product px = new Product();
px.Id = 1;
px.Name = "Macbook 100";
px.Quantity = 80;
px.Price = 5000;
laptop.EditProduct(px);
Console.WriteLine(" Danh sach sau khi sua: ");
laptop.PrintsAllProduct();

// xoa
int pid_remove = 1;
laptop.Removeproduct(pid_remove);
Console.WriteLine("Danh sach sau khi xoa: ");
laptop.PrintsAllProduct();