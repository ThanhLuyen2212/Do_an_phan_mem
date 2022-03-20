using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3_1
{
    class PMang
    {
        private int n = 10;
        private int[] mang = new int[10];

        private PMang() 
        {
            for(int i = 0; i < mang.Length; i++)
            {
                mang[i] = i;
            }
        }
        public PMang(int n)
        {
            this.n = n;
            for(int i = 0; i < this.n; i++)
            {
                mang[i] = i;
            }
        }

        public PMang(int[] mang)
        {
            this.mang = mang;
            this.n = this.mang.Length;
        }

        public int this[int indexer]
        {
            get 
            {
                int tmp = -999;
                if(indexer >= 0 && indexer < n)
                {
                    tmp = mang[indexer];
                }
                return tmp;
            }
            set 
            {
                if (indexer >= 0 && indexer < n)
                {
                    mang[indexer] = value;
                }
                
            }
        }

        public void xuatmang()
        {
            Console.WriteLine("cac phan tu cua mang la");
            for(int i =0; i < this.n; i++)
            {
                Console.WriteLine(this.mang[i]);                
            }
        }

        public void cacphantuchan()
        {
            Console.WriteLine("cac phan tu chan cua mang la ");
            for(int i =0; i < this.n; i++)
            {
                if(this.mang[i] % 2 == 0)
                Console.WriteLine(this.mang[i]);
            }
        }
    }
}
