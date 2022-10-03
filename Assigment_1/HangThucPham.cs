using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_1
{
    [Serializable]
    internal class HangThucPham: HangHoa
    {
        private DateTime ngaySX;
        private DateTime ngayHH;
        private string nhaCungCap;

        public HangThucPham()
        {

        }

        public HangThucPham(string maHang, string tenHang, int soLuongTon, int donGia, DateTime ngaySX, DateTime ngayHH, string nhaCungCap) : base(maHang, tenHang, soLuongTon, donGia)
        {
            this.NgaySX = ngaySX;
            this.NgayHH = ngayHH;
            this.NhaCungCap = nhaCungCap;
        }

        public DateTime NgaySX { get => ngaySX; set => ngaySX = value; }
        public DateTime NgayHH { get => ngayHH; set => ngayHH = value; }
        public string NhaCungCap { get => nhaCungCap; set => nhaCungCap = value; }

        public override void InRaManHinh()
        {
            Console.WriteLine($"|   {MaHang, -12} |   {TenHang, -15} |   {SoLuongTon, -7} |   {DonGia, -9} | {NgaySX:dd/MM/yyyy} | {NgayHH:dd/MM/yyyy} |   {NhaCungCap, -20}|");
            Console.WriteLine("|----------------|-------------------|-----------|-------------|------------|------------|-----------------------|");
        }
    }
}
