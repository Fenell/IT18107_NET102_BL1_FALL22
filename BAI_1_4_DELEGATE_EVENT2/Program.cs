using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_4_DELEGATE_EVENT2
{
    internal class Program
    {
        public delegate void SuKienNhap2So(int x, int y);
        class NguoiDUng
        {
            public event SuKienNhap2So sukienNhapSo;
            public void NhapSo()
            {
                Console.WriteLine("Mời bạn nhập a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                sukienNhapSo.Invoke(a, b);
            }
        }

        class TinhToan
        {
            public void ThiHanh(NguoiDUng nd)
            {
                nd.sukienNhapSo += TinhTong;
            }

            private void TinhTong(int x, int y)
            {
                Console.WriteLine($"{x} + {y} = {x + y}");
            }
        }
        static void Main(string[] args)
        {
            //Phát sự kiện
            NguoiDUng nd = new NguoiDUng();
            //Nhận sự kiện
            TinhToan tt = new TinhToan();
            tt.ThiHanh(nd);
            //Thực thi
            nd.NhapSo();
        }
    }
}
