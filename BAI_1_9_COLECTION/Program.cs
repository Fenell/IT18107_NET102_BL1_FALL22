using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_9_COLECTION
{
    internal class Program
    {
        public static void vidu1()
        {
            //Khai báo Collection loại List
            List<string> conVat;
            //Khởi tạo 1 collection rỗng
            conVat = new List<string>();
            //Dùng Add để thêm phần tử vào colection
            conVat.Add("Mèo");
            conVat.Add("Chó");
            conVat.Add("Gà");

            //Khởi tạo với 1 vài phần tử ban đầu
            conVat = new List<string>()
            {
                "Gà",
                "Chó"
            };

            //Duyệt colection
            conVat.Remove("Gà");
            foreach (string x in conVat)
            {
                Console.WriteLine(x);
            }

        }


        //VÍ dụ 2 stack và queue
        public static void vidu2()
        {
            Stack<string> monHoc = new Stack<string>();
            //push thêm phần từ vào stack
            monHoc.Push("Toán");
            monHoc.Push("Ngữ Văn");
            monHoc.Push("Lịch sử");
            Console.WriteLine("Các phần tử của stack sau khi push");
            foreach (var x in monHoc)
            {
                Console.WriteLine(x);
            }
            //pop phần tử ra khỏi stack
            monHoc.Pop();
            Console.WriteLine("Danh sách phần tử stack sau khi pop");
            foreach (var x in monHoc)
            {
                Console.WriteLine(x);
            }
        }


        //Vidu3 HashTable
        public static void vidu3()
        {
            //KHai báo và khởi tạo HashTable
            Hashtable diemThi = new Hashtable();
            diemThi.Add("Tùng", 8);
            diemThi.Add("Linh", 7);
            diemThi.Add("Dung", 8);
            //Truy cập phần tử của  HashTable thông qua key
            Console.WriteLine($"Điểm thi của Tùng là:{diemThi["Tùng"]} ");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            vidu3();
        }
    }
}
