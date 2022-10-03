using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_1
{
    internal class HangDienMay :HangHoa
    {
        private DateTime timeBaoHanh;
        private int congSuat;

        public HangDienMay()
        {

        }

        public HangDienMay(string maHang, string tenHang, int soLuongTon, int donGia, DateTime timeBaoHanh, int congSuat) : base(maHang, tenHang, soLuongTon, donGia)
        {
            this.TimeBaoHanh = timeBaoHanh;
            this.CongSuat = congSuat;
        }

        public DateTime TimeBaoHanh { get => timeBaoHanh; set => timeBaoHanh = value; }
        public int CongSuat { get => congSuat; set => congSuat = value; }

        public override void InRaManHinh()
        {
            Console.WriteLine($"|   {MaHang,-12} |   {TenHang,-15} |   {SoLuongTon,-7} |   {DonGia,-9} | {TimeBaoHanh:dd/MM/yyyy} | {CongSuat}|");
        }
    }
}
