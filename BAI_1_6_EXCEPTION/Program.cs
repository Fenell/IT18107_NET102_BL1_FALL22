using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_6_EXCEPTION
{

    public class ConCho
    {
        public MauLong mau;
        public int? soLan;
        public void sua()
        {
            Console.WriteLine($"...... sủa {soLan} lần");
        }
    }

    public class MauLong
    {
        public string mau;
    }
    internal class Program
    {
        public static void vidu1()
        {
            int a = 6, b = 0, c;
            c = a / b;
            Console.WriteLine($"c = {c}");
        }

        //xử lý exception

        public static void vidu2()
        {
            int a = 6, b = 0, c;
            try
            {
                c = a / b;
                Console.WriteLine("something");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                c = -1;
            }
            finally
            {
                Console.WriteLine("Kết thúc chương trình");
            }
            //Console.WriteLine($"c = {c}");
        }

        //ví dụ về Null exception

        public static void inMauLong (MauLong m)
        {
            Console.WriteLine($"Màu lông là : {m.mau}");
        }
        public static void vidu3(ConCho c)
        {
            c.sua();
            Console.WriteLine($"Con chó đã sủa {c.soLan} lần");
            try
            {
                inMauLong(c.mau);
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //vidu1();
            //vidu2();
            ConCho c = new ConCho();
            vidu3(c);
        }

    }
}
