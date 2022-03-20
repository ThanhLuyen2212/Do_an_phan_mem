using System;

namespace buoi3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhongBan phongBan = new PhongBan();
            phongBan.InpuStaff();
            int tongluong = phongBan.SumSalary();
            Console.WriteLine("tong luong nhan vien " + tongluong);
            Console.ReadKey();
        }
    }
}
