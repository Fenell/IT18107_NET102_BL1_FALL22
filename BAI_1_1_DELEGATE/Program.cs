using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_1_DELEGATE
{
    internal class Program
    {
        //Khai báo 1 delegate
        public delegate void ThongBao(string msg);

        public static void ThongTin1(string noidung)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ThôngTin1: " + noidung);
            Console.ResetColor();
        }
        public static void ThongTin2(string noidung)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ThôngTin2: " + noidung);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int? a = null;  //? để có thể gán thêm được dữ liệu null
            #region Phần 1:Khởi tạo delegate null
            Console.WriteLine("==PHần 1: Khởi tạo delegate null==");
            ThongBao thongbao = null; //Khai báo 1 cái delegate gán = null
            thongbao = ThongTin1; // Tham chiếu đến phương thức thì delegate sẽ trỏ đến phương thức đó
            thongbao("afser");
            thongbao?.Invoke("adf"); //Dấu hỏi để kiểm tra phương thức đó có null không và nếu không sẽ thực thi
            
            #endregion

            #region Phần 2: Khởi tạo 1 delegate
            Console.WriteLine("==PHần 2: Khởi tạo 1 delegate ==");
            ThongBao thongbao1 = new ThongBao(ThongTin2);
            thongbao1("Thông báo 2");
            #endregion

            #region Phần 3: Multicast Delegate
            Console.WriteLine("==PHần 3: Multicast Delegate ==");
            ThongBao thongbao2 = new ThongBao(ThongTin1);
            ThongBao thongbao3 = new ThongBao(ThongTin2);
            ThongBao multicast = thongbao2 + thongbao3;
            multicast -= thongbao3;
            multicast += thongbao2;
            multicast("multicast");
            #endregion

            #region Phần 4: Delegate Callback
            Console.WriteLine("==PHần 4: Delegate Callback ==");
            DelegateCallBack dcl = new DelegateCallBack(ThongTin3);
            CallBackFunc(dcl);
            #endregion

        }
        #region Phần 4: Delegate Callback
        public delegate void DelegateCallBack(int a);
        public static void ThongTin3(int temp)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ThôngTin2: " + temp);
            Console.ResetColor();
        }
        public static void CallBackFunc(DelegateCallBack delegatecallback)
        {
            Console.WriteLine("Mời bạn nhập số nguyên");
            int a = Convert.ToInt32(Console.ReadLine());
            delegatecallback(a);
        }
        #endregion
    }
}
