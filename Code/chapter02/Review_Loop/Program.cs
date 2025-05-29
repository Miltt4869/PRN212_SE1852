// cau 1: vẽ hình N
void hinh1(int n)
{
    for (int i = 0; i <n; i++)
    {
        for (int j = 0; j <n; j++)
        {
            if (j==0 || j == n-1 || i == j)
            {
                Console.Write("*");
            }
            else {  Console.Write(" "); }
        }
        Console.WriteLine();
    }
   
}
//hinh1(10);
// cau 2: sap xep man tang dan, dung do-while long nhau

void swap (ref int a, ref int b)
{
    int temp = a; a = b; b = temp;
}
void mysort(int[] arr)
{
    int i = 0;
    int j = i+1;
    do 
    {
        do 
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        }while (j < arr.Length-1);
        i++;
        j = i+1;
    }while (i< arr.Length -1); 
}

int[] arr = { 10, 3, 7, 2, 9 };
Console.WriteLine("Mang truoc khi sap xep: ");
foreach (int x in arr)
    { Console.WriteLine($"{x}\t"); }
Console.WriteLine("Sau khi sap xep ");
mysort(arr);
foreach (int x in arr)
{ Console.WriteLine($"{x}\t"); }
