using System;

namespace buoi3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Random random = new Random();
            n = random.Next(1, 10);
            Console.WriteLine("so phan tu cua mang la " +n);

            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(1, 10);
            }

            Console.WriteLine("cac phan tu cua mang la ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i].ToString());
            }         
           
            
            int x = random.Next(1, 10);
            Console.WriteLine("phan tu x la " + x);            

            DaThuc daThuc = new DaThuc(n,x,a);


            Console.WriteLine("tong cua da thuc la "+daThuc.GiaTriCuaDaThuc().ToString());

            Console.ReadKey();
        }
    }
}
