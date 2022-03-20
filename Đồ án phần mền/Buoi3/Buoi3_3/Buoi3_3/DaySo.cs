using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_3
{
    class DaySo
    {
        public int n = 10;
        public PhanSo[] phanSo = new PhanSo[10];
        
        public DaySo() { }


        public void inputfraction()
        {
            Random r = new Random();
            n = r.Next(3,10);
            Console.WriteLine("so phan tu phan so n: "+n);
            for (int i = 0; i < n; i++)
            {
                phanSo[i] = new PhanSo(r.Next(5,10),r.Next(5,10));
                Console.WriteLine(phanSo[i].GetTuso()+"/"+ phanSo[i].GetMauso());
            }
            
        }       


        public DaySo(int n)
        {
            this.n = n;
            phanSo = new PhanSo[n];
            for (int i = 0; i < n; i++)
                phanSo[i] = new PhanSo(i+3,i+6);
        }

        public DaySo(PhanSo[] phanSo)
        {
            n = phanSo.Length;  
            this.phanSo = phanSo;
        }

        public DaySo(int n, PhanSo[] phanSo)
        {
            this.n=n;
            this.phanSo = phanSo;
        }

        public PhanSo this[int indexer]
        {
            get 
            {
                if(indexer >= 0 && indexer < phanSo.Length)
                    return phanSo[indexer];
                return null;
            }

            set
            {
                if (indexer >= 0 && indexer < phanSo.Length)
                    phanSo[indexer] = value;                
            }

        }

        private double UCLN(double a, double b)
        {
            double r = 1;
            while (r != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        private PhanSo AddFraction(PhanSo ps1, PhanSo ps2)
        {
            PhanSo phanSo = new PhanSo();
            phanSo.SetTuso(ps1.GetTuso() * ps2.GetMauso() + ps2.GetTuso() * ps1.GetMauso());
            phanSo.SetMauSo(ps1.GetMauso() * ps2.GetMauso());

            double ucln = UCLN(phanSo.GetTuso(), phanSo.GetMauso());
            phanSo.SetTuso(phanSo.GetTuso() / ucln);
            phanSo.SetMauSo(phanSo.GetMauso() / ucln);
            return phanSo;
        }

        public PhanSo SumFraction()
        {
            PhanSo tong = new PhanSo(0,1);            
            for (int i = 0; i < n-1; i++)
            {
                tong = AddFraction(tong, this.phanSo[i]);
            }
            return tong;
        }
    }
}
