using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3_4
{
    class NhanVien
    {
        private string hoten;
        private int luong;
        private int songayvang;

        public NhanVien() { }

        public NhanVien(string hoten, int luong, int songayvang)
        {
            this.hoten = hoten;
            this.luong = luong;
            this.songayvang = songayvang;
        }

        public string GetHoten()
        {
            return hoten;
        }

        public int GetLuong()
        {
            return luong;

        }

        public int GetSongayvang()
        {
            return songayvang;
        }

        public void SetHoten(string hoten)
        {
            this.hoten= hoten;
        }

        public void SetLuong(int luong)
        {
            this.luong= luong;
        }

        public void SetSongayvang(int songayvang) 
        {
            this.songayvang= songayvang;    
        }
    }
}
