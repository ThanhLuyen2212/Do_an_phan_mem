using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3_2
{
    class DaThuc
    {        
        private int n = 10;
        private double x = 2;
        private double[] a = new double[11];

        public DaThuc()
        {
            for (int i = 0; i<=n; i++)
            {
                a[i] = i+1;
            }
        }
        public DaThuc(int n)
        {
            this.n = n;
            this.a = new double[n];
            for(int i= 0; i<= n; i++)
            {
                a[i] = i + 1;
            }
        }

        public DaThuc(double x)
        {
            this.x = x;
            for (int i = 0; i <= n; i++)
            {
                a[i] = i + 1;
            }
        }

        public DaThuc(double[] a)
        {
            this.a = a;
            this.n = a.Length;
        }

        public DaThuc(int n, double x)
        {
            this.n = n;
            this.x = x;
            this.a = new double[n];
            for (int i = 0; i <= n; i++)
            {
                a[i] = i + 1;
            }
        }

        public DaThuc(int n, double[] a)
        {
            this.n = n;
            this.a = a;            
        }

        public DaThuc(double x, double[] a)
        {
            this.n = a.Length;
            this.x = x;
            this.a = a;
        }

        public DaThuc(int n, double x, double[] a)
        {
            this.n = n;
            this.x = x;
            this.a = a;
        }

        public double this[int indexer]
        {
            get 
            {
                if(indexer >= 0 && indexer <= n)
                {
                    return indexer * Math.Pow(x, indexer);
                }
                return -1;
            }
            set
            {
                if (indexer >= 0 && indexer <= n)
                {
                    a[indexer] = value;
                }
            }
        }

        public double GiaTriCuaDaThuc()
        {
            double tmp = 0;
            for(int i = 0; i < n; i++)
            {
                tmp += this[i];
            }
            return tmp;
        }
    }
}
