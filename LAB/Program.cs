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
            Console.OutputEncoding = Encoding.UTF8;
            StudentService studentService = new StudentService();
            do
            {
                Console.WriteLine("============Meunu=========");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Sửa thông tin sinh viên");
                Console.WriteLine("3. Xoá thông tin sinh viên");
                Console.WriteLine("4. Xuất thông tin sinh viên");
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
                        break;
                    case "4":
                        studentService.DisplayStudent();
                        break;
                    default:
                        Console.WriteLine("Tạm biệt");
                        break;
                }
            } while (input != "0");
        }
    }
}
