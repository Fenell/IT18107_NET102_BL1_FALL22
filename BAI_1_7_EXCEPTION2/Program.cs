using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_7_EXCEPTION2
{
    internal class Program
    {
        // VÍ dụ về Throw
        public static void checkTuoi(int tuoi)
        {
            if (tuoi <18)
            {
                throw new Exception("Bạn chưa đủ tuổi kết hôn");
            }
            Console.WriteLine("Chúc mừng bạn đã đủ tuổi đi tù");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int tuoi = 10;
            try
            {
                checkTuoi(tuoi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
