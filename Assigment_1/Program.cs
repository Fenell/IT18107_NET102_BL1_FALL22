using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            HangHoaService hangHoaService = new HangHoaService();
            string input;
            //kiểm tra file đã tồn tại hay chưa 
            if (File.Exists(@"D:\CODE\C#\C#2\IT18107_NET102_BL1_FAL22\Assigment_1\data.bin") == false)
            {
                hangHoaService.saveFile();
            }
            else hangHoaService.readFile();
            do
            {
                Console.WriteLine("Chương trình quản lý thực phẩm");
                Console.WriteLine("|=============MEMU============|");
                Console.WriteLine("|1. Thêm thực phẩm            |");
                Console.WriteLine("|2. Hiển thị danh sách        |");
                Console.WriteLine("|3. Sửa thông tin             |");
                Console.WriteLine("|4. Lọc mặt hàng hết hạn      |");
                Console.WriteLine("|5. Lưu file                  |");
                Console.WriteLine("|6. Đọc file                  |");
                Console.WriteLine("|0. Thoát                     |");
                Console.WriteLine("|=============================|");
                Console.Write("Mời bạn chọn chức năng: ");
                input = Console.ReadLine();
                Console.WriteLine();
                switch (input)
                {
                    case "1":
                        HangThucPham hangThucPham = hangHoaService.inputThucPham();
                        hangHoaService.addThucPham(hangThucPham);
                        Console.Write("Bạn muốn nhập nữa không (y -- có || n -- không)");
                        input = Console.ReadLine();
                        if (input == "y")
                        {
                            goto case "1";
                        }
                        break;
                    case "2":
                        hangHoaService.titleColumm();
                        hangHoaService.Display();
                        break;
                    case "3":
                        hangHoaService.saveFile();
                        break;
                    case "4":
                        Console.Write("Mời bạn nhập mã thực phẩm: ");
                        input = Console.ReadLine();
                        HangThucPham thucPhamEdit = new HangThucPham();
                        foreach (var x in hangHoaService.listThucPhams()) //Kiểm tra mã thực phẩm nhập vào
                        {
                            if (x.MaHang.ToLower() == input.ToLower())
                            {
                                Console.WriteLine("Tìm thấy mã thực phẩm");
                                thucPhamEdit = hangHoaService.inputThucPham(); //Nhập data vào 1 đối tượng tạm
                                break;
                            }
                        }
                        thucPhamEdit.MaHang = input.ToUpper(); //Gán lại mã thực phẩm của đối tượng cần sửa vào đối tượng tạm
                        Console.WriteLine(hangHoaService.editThucPham(thucPhamEdit)); //gán lại đối tượng tạm vào danh sách
                        hangHoaService.Display();
                        break;
                    case "5":
                        hangHoaService.filterThucPham();
                        break;
                    case "0":
                        Console.Write("Bạn có muốn lưu lại dữ liệu không(y -- có || n -- không):");
                        string choose = Console.ReadLine();
                        if (choose == "y")
                        {
                            hangHoaService.saveFile();
                        }
                        break;
                    default:
                        Console.WriteLine("Chức năng không tồn tại");
                        break;
                }
            } while (input != "0");


        }
    }
}
