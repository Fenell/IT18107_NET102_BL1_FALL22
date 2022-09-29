using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_8_CLASS_EXCEPTION
{
    internal class Program
    {
        public static void checkTruong (string name)
        {
            if (name!="Fpoly")
            {
                throw new CheckTruongException("Bạn đã không đăng ký học");
            }
        }
        public static void checkTuoi(int tuoi)
        {
            if (tuoi < 18)
            {
                throw new CheckTuoiException("");
            }
            Console.WriteLine("Chúc mừng bạn đã đủ tuổi ");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int tuoi = 17;
            string tenTruong = "Haui";
            try
            {
                checkTruong(tenTruong);
                checkTuoi(tuoi);
            }
            catch (CheckTruongException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (CheckTuoiException ex)
            {
                ex.ThongBaoLoi();
            }
        }
    }
}
