using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public static class MyUtils
    {
        // cài đặt hàm tính tổng từ 1-n
        // vào kiểu int Microsoft
        public static int Tongtu1toiN (this int n)
        {
            int sum = 0;
            for (int i = 0; i<= n; i++)
            {
                sum += 1;
            }
            return sum;
        }

        public static void SapxepTangdan(this int[] ar)
        {
            for (int i = 0; i <= ar.Length; i++)
            {
                for (int j = i; j < ar.Length; j++)
                {
                    if (ar[i] >= ar[j])
                    {
                        int temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;
                    }
                    
                }
            }
        }
        public static void TaoMangNgauNhien(this int[] ar)
        {
            Random rd = new Random();
            for (int i = 0; i <= ar.Length; i++)
            {
                ar[i] = rd.Next(100);
            }
        }
        public static void XuatMang(this int[] ar)
        {
            foreach (int i in ar)
            {
                Console.WriteLine(i + "\t");
            }
            Console.WriteLine();
        }
    }
}
