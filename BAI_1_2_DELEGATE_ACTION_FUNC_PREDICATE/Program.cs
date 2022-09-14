using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_2_DELEGATE_ACTION_FUNC_PREDICATE
{
    internal class Program
    {
        public static void ThongTin1(string noidung)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ThôngTin1: " + noidung);
            Console.ResetColor();
        }
        public static void ThongTin2(string noidung)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ThôngTin1: " + noidung);
            Console.ResetColor();
        }
        public static void ThongTin3(string noidung, int a)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ThôngTin1: " + noidung);
            Console.ResetColor();
        }
        public static void ThongTin4()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ThôngTin1: ");
            Console.ResetColor();
        }
        public static double PhepChia(int a, int b)
        {
            return a / b;
        }
        public static bool CheckVietHoa(string name) //dat
        {
            return name.Equals(name.ToUpper()); //dat== DAT
        }

        public static int ViDu1(double a, double b, string msg)
        {
            return 0;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Phần 1:Action - Chỉ đi với void
            Action action; //Tương đương delegate void tenDelegate();
            Action<string> action2; //Tương đương delegate void tenDelegate(string a);
            Action<string, int> action3;//Tương đương delegate void tenDelegate(string a, int b);
            Action<string, string, int, int> action4; //Tương đương delegate void tenDelegate(string a, string b, int c, int d);
            action = ThongTin4;
            action3 = ThongTin3;
            action3("action", 2022);
            action3?.Invoke("action", 2022);
            #endregion

            #region Phần 2: Predicate - CHỉ đi với phương thức trả về kiểu bool
            Predicate<string> predicate; //Tương đương cới Delegate bool tendelegate(string a);
            predicate = CheckVietHoa;
            Console.WriteLine("Chữ dat truyền vào có viết hoa:"+ predicate?.Invoke("dat")); //False
            #endregion

            #region Phần 3: Func - Chỉ đi với tất cả các phương thức trả về
            Func<int, int, double> func1; //Tương đương với Delegate  Double tendelegate(int a, int b);
            func1 = PhepChia;
            Func<int, int, string, double, double> func2; //Tương đương với  double tendelegate(int a, int b, sting c, double d);
            #endregion

            //Ví dụ:

            Func<double, double, string, int> functb1;
            //Predicate<string, string, int> predtb2; Predicate chỉ được phép 1 tham số
        }
    }
}
