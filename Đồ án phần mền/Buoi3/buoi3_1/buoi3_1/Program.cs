using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Random random = new Random();
            n = random.Next(1, 10);
            Console.WriteLine(n);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(1, 10);
            }
            PMang mang = new PMang(a);
            Console.WriteLine("so phan tu la " + n);
            Console.WriteLine(mang.ToString());
            
            mang.xuatmang();
            mang.cacphantuchan();  
            Console.ReadKey();
        }
    }
}
