using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            StudentService studentService = new StudentService();
            do
            {
                Console.WriteLine("============Meunu===========");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Sửa thông tin sinh viên");
                Console.WriteLine("3. Xoá thông tin sinh viên");
                Console.WriteLine("4. Tìm kiếm sinh viên");
                Console.WriteLine("5. Xuất thông tin sinh viên");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("---------------------------");
                Console.Write("Mời bạn chọn chức năng: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        studentService.addStudent();
                        break;
                    case "2":
                        studentService.EditStudent();
                        break;
                    case "3":
                        studentService.deleteStudent();
                        break;
                    case "4":
                        studentService.FindStudent();
                        break;
                    case "5":
                        studentService.DisplayStudent();
                        break;
                    case "0":
                        Console.WriteLine("Tạm biệt");
                        break;
                    default:
                        Console.WriteLine("Chức năng không tồn tại");
                        break;
                }
            } while (input != "0");
        }
    }
}
