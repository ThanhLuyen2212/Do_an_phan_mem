using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3_4
{
    class PhongBan
    {
        public NhanVien[] nhanViens = new NhanVien[2];
        public int n = 2;

        public PhongBan() { }

        public PhongBan(int n)
        {
            this.n = n;
            nhanViens = new NhanVien[n]; 
        }

        public PhongBan(int n, NhanVien[] nhanVien)
        {
            this.n=n;
            this.nhanViens = nhanVien;
        }

        public PhongBan(NhanVien[] nhanViens)
        {
            this.n = nhanViens.Length;
            this.nhanViens = nhanViens;
        } 

        public void InpuStaff()
        {
            Random r = new Random();
            n = r.Next(5,10);
            Console.WriteLine("so nhan vien la: "+n);
            nhanViens = new NhanVien[n];
            char letter;


            for (int i = 0; i < n; i++)
            {
                String str = "";
                Random random = new Random();
                for (int j = 0; j < 5; j++)
                {
                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    letter = Convert.ToChar(shift + 65);
                    str += letter.ToString();
                }

                nhanViens[i] = new NhanVien();
                nhanViens[i].SetHoten(str);
                nhanViens[i].SetLuong(r.Next(10000, 100000));
                nhanViens[i].SetSongayvang(r.Next(1, 5));

                Console.WriteLine(nhanViens[i].GetHoten()+" / "+nhanViens[i].GetLuong()+" / "+nhanViens[i].GetSongayvang());
            }
        }

        public int SumSalary()
        {
            int sum = 0;
            int tien = 0;
            for(int i = 0; i < nhanViens.Length; i++)
            {
                sum += nhanViens[i].GetLuong() - nhanViens[i].GetSongayvang()*100;
                tien += nhanViens[i].GetSongayvang() * 100;
            }
            Console.WriteLine("so tien bi tru vi ngay vang "+tien);

            return sum;
        }
    }
}
