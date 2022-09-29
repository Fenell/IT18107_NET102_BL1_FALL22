using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_3_IMPLICIT_VA_DYNAMIC_TYPE
{
    internal class Program
    {
        #region Implicitly
        public static void ViDu1()
        {
            //Không gán giá trị khi khai báo kiểu ngầm định IDE sẽ báo lỗi
            //var aString;

            var aString = "something";
            var aInt = 1;
            
            //Biến tường minh có thể gán gt cho null
            string nullString = null;
            //Kiểu ngầm định thì không
            //var nullVar = null;

            //Không thể gán giá trị kiểu ngầm định sau khi khai báo
        }
        //Khi khai báo kiểu ngầm định bên ngoài 1 phương thức sẽ báo lỗi
        //var a = 1;

        #endregion

        #region Dynamic
        public static void DynamicEx()
        {
            // KHai báo tương tự var nhưng với từ khoá dunamic không cần gán giá trị
            dynamic testDynamic;
            //KHai báo 1 biến nặc danh
            var student = new
            {
                Ten = "Mai Tuấn Đạt",
                Tuoi = 19,
                NganhHoc = "Phát triển phần mềm"
            };
            //sử dụng dynamic để gọi phương thức
            inStudentInfo(student.Ten, student.Tuoi, student.NganhHoc);
        }

        private static void inStudentInfo(dynamic ten, dynamic tuoi, dynamic nganhHoc)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"{ten} - {tuoi} tuổi");
            Console.WriteLine($"Học nghành: {nganhHoc}");
            Console.WriteLine("-------------------------------");
        }
        //Khác với var, dynamic có thể khai báo bên ngoài phương thức
        private dynamic BienPrivate;
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DynamicEx();
        }
    }
}
