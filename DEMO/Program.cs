using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Tạo một stream và lưu vào đó một số byte
            //Stream stream = new MemoryStream();
            //for (int i = 0; i < 122; i++)
            //{
            //    stream.WriteByte((byte)i);
            //}
            //// Thiết lập vị trí là điểm bắt đầu
            //stream.Position = 0;


            //byte[] buffer = new byte[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // mảng chứa 10 byte để làm bộ nhớ lưu byte đọc được
            //int offset = 0; // vị trí (index) trong buffer - nơi ghi byte đầu tiên đọc được
            //int count = 5; // đọc 5 byte
            //int numberbyte = stream.Read(buffer, 0, 2); // bắt đầu đọc
            //Console.WriteLine($"{numberbyte}");
            //while (numberbyte != 0)
            //{
            //    Console.Write($"{numberbyte} bytes: ");
            //    for (int i = 1; i <= numberbyte; i++)
            //    {
            //        byte b = buffer[i - 1];
            //        Console.Write(string.Format("{0, 5}", b));

            //    }
            //    numberbyte = stream.Read(buffer, offset, count); // đọc 5 byte tiếp theo
            //    Console.WriteLine();

            //    int abc = 1;
            //    var byte_abc = BitConverter.GetBytes(abc);
            //    Console.WriteLine($"{byte_abc}");
            //}

            //int[] IntArray = { 11, 22, 33, 44, 55 };
            ////Using Method Syntax
            //var IsExistsMS = IntArray.Contains(33);
            ////Using Query Syntax
            ////var IsExistsQS = (from num in IntArray
            ////                  select num).Contains(33);
            //Console.WriteLine(IsExistsMS);
            //Console.ReadKey();
            Console.WriteLine(String.Format("{0, -5}{1, -8}{2, -6}{3, -9}{4, -6}{5, -6}{6, -20}", "|  t", "|r", "|e"));

        }
    }
}
