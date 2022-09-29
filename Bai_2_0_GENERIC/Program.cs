using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2_0_GENERIC
{
    internal class Program
    {
        //Vd truyền tham trị tham chiếu
        public static void ThamTri(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a={a}, b={b}");
        }
        //Tryền tham chiếu
        public static void ThamChieu(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a={a}, b={b}");
        }

        //Truyền tham chiếu Generic
        public static void truyenThamChieuGeneric<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a = {a}, b = {b}");
        }
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            //ThamTri(a, b);
            //Console.WriteLine("Sau khi truyền tham trị:");
            //Console.WriteLine($"a={a}, b={b}");
            //ThamChieu(ref a, ref b);

            truyenThamChieuGeneric<int>(ref  a, ref  b);
            Console.WriteLine("Sau khi truyền tham chiếu:");
            Console.WriteLine($"a = {a}, b = {b}");

        }
    }
}
