using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_3
{
    class PhanSo
    {
        private double tuso;
        private double mauso;

        public PhanSo(){ }

        public PhanSo(double tuso, double mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        
        public PhanSo(PhanSo phanso)
        {
            tuso = phanso.tuso;
            mauso = phanso.mauso;   
        }
        
        public double GetTuso()
        {
            return tuso;
        }

        public double GetMauso()
        {
            return mauso;   
        }

        public void SetTuso(double tuso)
        {
            this.tuso = tuso;
        }

        public void SetMauSo(double mauso)
        {
            this.mauso = mauso;
        }
    }
}
