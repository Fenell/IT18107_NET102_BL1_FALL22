using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_1
{
    internal class HangHoaService
    {
        private HangThucPham _hangThucPham;
        private List<HangThucPham> _lstHangThucPhams;
        private FileStream _fs;
        private BinaryFormatter _bn;
        private string _path = @"D:\CODE\C#\C#2\IT18107_NET102_BL1_FAL22\Assigment_1\data.bin";
        private string _input;
        public HangHoaService()
        {
            _lstHangThucPhams = new List<HangThucPham>()
            {
                new HangThucPham("TP4958", "Thịt lợn", 40, 20000, new DateTime(2022, 9, 26), new DateTime(2022, 10, 03), "Vinh Group"),
                new HangThucPham("TP3948", "Tôm hùm", 100, 400000, new DateTime(2022, 9, 15), new DateTime(2022, 11, 1) ,"Thế giới hải sản"),
                new HangThucPham("TP4958", "Thịt bò khô", 20, 50000,new DateTime(2022, 9, 26), new DateTime(2022, 08, 03),  "Tuấn Long"),
                new HangThucPham("TP8583", "Cá hồi", 160, 100000, new DateTime(2022, 9, 25), new DateTime(2022, 11, 25) ,"Thế giới hải sản"),
                new HangThucPham("TP7943", "Thịt gà", 240, 30000, new DateTime(2022, 9, 28), new DateTime(2022, 10, 10) ,"Thành Vinh")
            };
        }


        #region Chức năng thêm thực phẩm
        public string addThucPham(HangThucPham hangThucPham)
        {
            if (hangThucPham != null)
            {
                _lstHangThucPhams.Add(hangThucPham);
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public HangThucPham inputThucPham()
        {
            _hangThucPham = new HangThucPham();
            //Sử dụng hàm Random để tạo ngẫu nhiên mã thực phẩm từ 1000-9999
            _hangThucPham.MaHang = "PH" + Convert.ToSingle(new Random().Next(1000, 9999));
            do
            {
                _hangThucPham.TenHang = getInputHH("tên hàng");
                if (_hangThucPham.TenHang == "")
                {
                    Console.WriteLine("Dữ liệu không được để trống");
                }
            } while (_hangThucPham.TenHang == "");
            do
            {
                _hangThucPham.SoLuongTon = Convert.ToInt32(getInputHH("số lượng tồn kho"));
                if (_hangThucPham.SoLuongTon < 0)
                {
                    Console.WriteLine("Số lượng cần >= 0");
                }
            } while (_hangThucPham.SoLuongTon < 0);
            do
            {
                _hangThucPham.DonGia = Int32.Parse(getInputHH("đơn giá"));
                if (_hangThucPham.DonGia <= 0)
                {
                    Console.WriteLine("Đơn gia phải > 0");
                }
            } while (_hangThucPham.DonGia <= 0);
            _hangThucPham.NgaySX = DateTime.Parse(getInputHH("ngày sản xuất (năm, tháng, ngày)"));
            do
            {
                _hangThucPham.NgayHH = DateTime.Parse(getInputHH("ngày hết hạn (năm, tháng, ngày)"));
                if (_hangThucPham.NgayHH < _hangThucPham.NgaySX)
                {
                    Console.WriteLine("Ngày hết hạn không hợp lệ");
                }
            } while (_hangThucPham.NgayHH < _hangThucPham.NgaySX);
            _hangThucPham.NhaCungCap = getInputHH("nhà cung cấp");
            return _hangThucPham;
        }
        #endregion

        //Xuất danh sách mặt hàng
        public void Display()
        {
            _lstHangThucPhams.ForEach(x => x.InRaManHinh());
            Console.ReadLine();
        }

        public void deleteHH()
        {
            _input = getInputHH("mã sản phẩm");
            for (int i = 0; i < _lstHangThucPhams.Count; i++)
            {
                if (_input == _lstHangThucPhams[i].MaHang)
                {
                    _lstHangThucPhams.RemoveAt(i);
                    Console.WriteLine("xoá thành công");
                }
            }
        }

        //Sửa thông tin mặt hàng
        public string editThucPham(HangThucPham hangThucPham)
        {
            for (int i = 0; i < _lstHangThucPhams.Count; i++)
            {
                if (hangThucPham.MaHang == _lstHangThucPhams[i].MaHang)
                {
                    _lstHangThucPhams[i] = hangThucPham; // gán lại đối tượng ở tham số vào list
                    return "Sửa thành công";
                }
            }
            return "Sửa không thành công";
        }

        //Lọc các mặt hàng hết hạn  sửa dụng
        public void filterThucPham()
        {
            DateTime now = DateTime.Now;
            titleColumm();
            foreach (var x in _lstHangThucPhams)
            {
                if (x.NgayHH < now)
                {
                    x.InRaManHinh();
                }
            }
            Console.ReadKey();
        }

        //Lưu file
        public void saveFile()
        {
            _fs = new FileStream(_path, FileMode.OpenOrCreate);
            _bn = new BinaryFormatter();
            _bn.Serialize(_fs, _lstHangThucPhams);
            Console.WriteLine("Lưu thành công");
            _fs.Close();
        }

        //Đọc file
        public void readFile()
        {
            _fs = new FileStream(_path, FileMode.Open);
            _bn = new BinaryFormatter();
            var data = _bn.Deserialize(_fs);
            _lstHangThucPhams = (List<HangThucPham>)data;
            _fs.Close();
        }

        public string getInputHH(string msg)
        {
            Console.Write($"Mời bạn nhập {msg}: ");
            return Console.ReadLine();
        }
        public List<HangThucPham> listThucPhams()
        {
            return _lstHangThucPhams;
        }
        public void titleColumm()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|================================================================================================================|");
            Console.WriteLine(String.Format("{0, -17}{1, -20}{2, -6}{3, -14}{4, -13}{5, -13}{6, -24}{7}", "| Mã thực phẩm   ", "| Tên thực phẩm    ", "| Tồn kho   ", "|  Đơn giá", "| Ngày SX", "| Ngày HH", "|  Nhà cung cấp", "|"));
            Console.WriteLine("|================================================================================================================|");
            Console.ResetColor();
        }
    }
}
