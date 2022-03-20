using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DaySo daySo = new DaySo();
            daySo.inputfraction();                  
            PhanSo phanso = new PhanSo(daySo.SumFraction());
            Console.WriteLine(" tong cua cac phan so la "+phanso.GetTuso() + "/" + phanso.GetMauso());
            Console.ReadKey();


        }
    }
}
