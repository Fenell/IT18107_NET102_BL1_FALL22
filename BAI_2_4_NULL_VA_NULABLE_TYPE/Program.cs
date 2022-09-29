using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_4_NULL_VA_NULABLE_TYPE
{
    internal class Program
    {
        public static void Vidu1()
        {
            List<string> strings = null;

            int a = null;
        }

        #region NULLABLE_TYPE
        public static void vidu2()
        {
            //Khai báo nullable
            Nullable<int> diem = null; //Kiểu 1
            long? chieuCao = null; //Kiểu 2
            int diemThuc = -1;
            //Dùng [Nullable var].HashValue để kiểm tra xem biến đó có đang chứa giá trị không 
            //Nó có đang null hay không
            //diemThuc = diem.Value; //Nếu điểm null sẽ lỗi
            diem = 8;
            if (diem.HasValue)
            {
                diemThuc = diem.Value;
            }
            Console.WriteLine($"Điểm = " + diemThuc);
            diem = null;
            //Toán tử ?? dùng để kiểm tra nếu điểm != null diemThuc = diem
            //Nếu điểm = null  diemThuc = 9
            diemThuc = diem ?? 9;
            Console.WriteLine($"Điểm = " + diemThuc);
        }
        #endregion
        static void Main(string[] args)
        {
        }

        ConVat meo = new ConVat("Mèo", 1);
        ConVat cho = new ConVat("Chó", 1);
        int tuoiMeo, tuoiCho;

        
    }
}
