using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_1_GENERIC_CLASS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Khai báo class kiểu Int
            ClassGeneric<string> stringGeneric = new ClassGeneric<string>(5);
            stringGeneric.addItemElement(2, "Mèo");
            stringGeneric.addItemElement(1, "Chim");
            Console.WriteLine($"Phần tử thứ 0 = {stringGeneric.getItemElement(0)}");
            Console.WriteLine($"Phần tử thứ 1 = {stringGeneric.getItemElement(1)}");
        }
    }
}
