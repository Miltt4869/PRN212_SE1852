// See https://aka.ms/new-console-template for more information
void doicho(ref int a,ref int b)
{
    int temp = a;
    a = b;
    b = temp;
    Console.WriteLine("a trong ham = " + a);
    Console.WriteLine("b trong ham = " + b);

}
int a = 5;
int b = 7;
Console.WriteLine(" a truoc khi vao ham bang a " + a);
Console.WriteLine(" b truoc khi vao ham bang b " + b);
doicho(ref a,ref b);
Console.WriteLine("a sau khi vao ham "+a);
Console.WriteLine("b sau khi vao ham " + b);


/* muoons dung "out" khi vao phai gan giatri, truongwf hopwj nay khong the dung out,
 *  neu khong doi cho thi dung out
 *  khong co gtri truoc nh trong ham phai gan gtri cho no, "ref" ngupc lai
 */