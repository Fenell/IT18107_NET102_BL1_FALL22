using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_5_SYSTEM_IO
{
    internal class Program
    {
        public static void DiskPartition()
        {
            do
            {
                DriveInfo[] driveInfos = DriveInfo.GetDrives();
                Console.WriteLine("Tất cả phân vùng trên máy tính");
                foreach (var item in driveInfos)
                {
                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("Lựa chọn phân vùng: ");
                string ch = Console.ReadLine();
                var driverInfo = new DriveInfo(ch);
                Console.WriteLine($"\nDriver name: {driverInfo.Name}");
                Console.WriteLine($"\nDriver Size: {driverInfo.TotalSize}");
                Console.WriteLine($"\nDriver Freespace: {driverInfo.TotalFreeSpace}");
                Console.WriteLine($"\nDriver type: {driverInfo.DriveType}");

            } while (true);
        }

        public static void directoryInfo()
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\CODE\fpoly");
            di.Create();
            DirectoryInfo di2 = new DirectoryInfo(@"D:\CODE\fpoly");
            di2.CreateSubdirectory(@"txt");    //Tạo thư mục con trong thư mục cha
            Directory.Delete(@"D:\CODE\", true);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //DiskPartition();
            directoryInfo();

        }
    }
}
