using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_8_CLASS_EXCEPTION
{
    internal class CheckTuoiException : Exception
    {
        public CheckTuoiException(string message) : base(message)
        {

        }
        public void ThongBaoLoi()
        {
            Console.WriteLine("Bạn chưa đủ tuổi để học Fpoly");
        }
    }
}
