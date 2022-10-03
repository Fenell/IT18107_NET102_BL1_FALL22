using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_1
{
    [Serializable]
    internal class HangHoa
    {
        private string maHang;
        private string tenHang;
        private int soLuongTon;
        private int donGia;

        public HangHoa()
        {

        }

        public HangHoa(string maHang, string tenHang, int soLuongTon, int donGia)
        {
            this.MaHang = maHang;
            this.TenHang = tenHang;
            this.SoLuongTon = soLuongTon;
            this.DonGia = donGia;
        }

        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
        public int DonGia { get => donGia; set => donGia = value; }

        public virtual void InRaManHinh()
        {
        }   
    }
}
