using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_7_LAMBDA
{
    internal class Program
    {
        #region LAMBDA
        //BIểu thức Lambda hay biểu thức Anonymous nó là 1 phương thức nhưng không có tên
        // cú pháp khai báo sử dụng toán tử =>
        // CÚ pháp 1:       (THam số)=> Biểu thức;
        //Cú pháp 2: (tham số)=> { 
        //  các biểu thức hoặc return  }
        #endregion

        //sử dụng delegate với biểu thức lambda

        public delegate int TinhHieu(int x, int y);

        public static void Vidu1()
        {
            int x = 10, y = 5;
            TinhHieu tinhHieu = (int a, int b) => { return x - y; };
            TinhHieu tinhHieu2 = (int a, int b) => x - y;
            Console.WriteLine($"{x} - {y} = {tinhHieu2(x, y)}");
        }

        //Ví dụ 2: Khai báo phương thức bàng biểu thức lambda
        static double tinhThuong (int a, int b) => a / b;

        //Ví dụ 3: sử dung biểu thức lambda
        static void Vidu3()
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };

            //Cách 1: dùng DELEGATE
            Array.ForEach(a, delegate (int x)
            {
                Console.WriteLine(x);
            });
            //Cách 2: 
            Array.ForEach(a, x => Console.WriteLine(x));

            //Cách3:
            foreach (var x in a)
            {
                Console.WriteLine(x);
            }
        }

        #region Một số nguyên tắc sử dụng Lambda
        delegate void ChaoBan(string a);
        delegate void ChaoBan2();
        delegate void ChaoBan3(string a, string b);

        static void Vidu4()
        {
            //Không quan tâm kiểu dữ liệu đầu vào
            ChaoBan chaoBan1 = (string a) => { Console.WriteLine(a); };
            //Nếu chỉ có 1 câu lệnh thì bỏ {}
            ChaoBan chaoBan2 = (a) => Console.WriteLine(a);
            //Nếu không có tham số thì để trống ()
            ChaoBan2 chao = () = Console.WriteLine("something");
            //Nếu có nhiều tham số thì ngăn cách bằng ,
            ChaoBan3 chao1 = (x, y) => Console.WriteLine("something");

            //Nếu chỉ có 1 tham số thì bỏ ()
            ChaoBan chaoBan = temp => Console.WriteLine(temp);
            //return

        }
        #endregion
        static void Main(string[] args)
        {
            Vidu1();
        }
    }
}
