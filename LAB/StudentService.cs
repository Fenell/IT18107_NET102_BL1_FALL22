using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class StudentService
    {
        private List<Student> _lstStudents;
        private Student _student;
        private string _input;
        private int _index;
        private delegate string _delegate(string msg);
        //private FileStream _QlStudent;
        //private BinaryFormatter binaryFormatter;

        public StudentService()
        {
            _lstStudents = new List<Student>()
            {
                new Student("Pạm", "Chiến", "Văn", 2000, 0, "Hà Nội", "PH20349", 8),
                new Student("Đặng", "Sơn", "Thái", 2000, 0, "Thái Bình",  "PH29485", 7.6),
                new Student("Nguyễn", "Anh", "Phương", 1999, 1, "Hà Nam", "PH8503", 5.6),
                new Student("Phạm", "Hương", "Thị", 2003, 1, "Hải Phòng", "PH4957", 6.4),
                new Student("Mai", "Đạt", "Tuấn", 1999, 0, "Thái Bình", "PH9472", 9.9),
            };
        }

        //public void writeStudent(string filepath)
        //{
        //    BinaryFormatter binaryFormatter = new BinaryFormatter();
        //    _QlStudent = new FileStream(filepath, FileMode.Append);
        //    binaryFormatter.Serialize(_QlStudent, _lstStudents);
        //    _QlStudent.Close();
        //}

        //public List<Student> readStudent(string filepath)
        //{
        //    _QlStudent = new FileStream(filepath, FileMode.Open);
        //    BinaryFormatter binaryFormatter = new BinaryFormatter();
        //    var data = binaryFormatter.Deserialize(_QlStudent) as List<Student>;
        //    _QlStudent.Close();
        //    return data;
        //}

        public string GetInput(string msg)
        {
            Console.Write($"Mời bạn nhập {msg}: ");
            return Console.ReadLine();
        }

        public int GetIndexValue()
        {
            _input = GetInput("mã sinh viên");
            for (int i = 0; i < _lstStudents.Count; i++)
            {
                if (_lstStudents[i].MaSv.ToLower() == _input.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }
        //Thêm sinh viên vào danh sách
        public void addStudent()
        {
            do
            {
                _student = new Student();
                _student.Ten = GetInput("Tên");
                _student.TenDem = GetInput("tên đệm");
                _student.Ho = GetInput("Họ");
                _student.MaSv = GetInput("mã sinh viên");
                _student.NamSinh = Convert.ToInt32(GetInput("năm sinh"));
                do
                {
                    _student.DiemCSharp = Convert.ToDouble(GetInput("điểm C Sharp"));
                    if (_student.DiemCSharp < 0 || _student.DiemCSharp > 10)
                    {
                        Console.WriteLine("Điểm số phải trong khoảng 0 - 10");
                    }
                } while (_student.DiemCSharp < 0 || _student.DiemCSharp > 10);
                _student.GioiTinh = Convert.ToInt32(GetInput("giới tính (0-- nam || 1- nữ): "));
                _student.QueQuan = GetInput("quê quán");
                _lstStudents.Add(_student);
                Console.WriteLine("Bạn có muốn nhập tiếp không (y - có || n -- không)");
                _input = Console.ReadLine();
            } while (_input == "y");
        }
        //Sửa thông tin sinh viên
        public void EditStudent()
        {
            Func<int> delegateGetIndex = GetIndexValue;
            _index = delegateGetIndex();
            if (_index != -1)
            {
                Console.WriteLine("1. Sửa họ tên");
                Console.WriteLine("2. Sửa điểm");
                Console.WriteLine("0. Quay lại menu");
                Console.Write("Mời bạn nhập: ");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        _lstStudents[_index].Ho = GetInput("họ mới");
                        _lstStudents[_index].TenDem = GetInput("tên đệm mới");
                        _lstStudents[_index].Ten = GetInput("tên mới");
                        Console.WriteLine("Sửa thành công");
                        break;
                    case "2":
                        _lstStudents[_index].DiemCSharp = Convert.ToDouble(GetInput("điểm mới"));
                        Console.WriteLine("Sửa thành công");
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Chức năng không tồn tại");
                        break;
                }
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Không tìm thấy sinh viên");
            Console.ReadKey();
        }
        //Xoá sinh viên
        public void deleteStudent()
        {
            _index = GetIndexValue();
            if (_index != -1)
            {
                _lstStudents.RemoveAt(_index);
                Console.WriteLine("Xoá thành công");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Không tìm thấy sinh viên");
            Console.ReadKey();
        }
        //Tìm kiếm nâng cao
        public void FindStudent()
        {
            string choose;
            do
            {
                _delegate delegateInput = GetInput;
                Console.WriteLine("1. Tìm kiếm theo mã sinh viên");
                Console.WriteLine("2. Tìm kiếm gần đúng theo họ sinh viên");
                Console.WriteLine("3. Tìm kiếm gần đúng theo tên sinh viên");
                Console.WriteLine("0. Quay lại menu");
                Console.Write("Nhập lựa chọn của bạn: ");
                choose = Console.ReadLine();
                int count = 0;
                switch (choose)
                {
                    case "1":
                        int index = GetIndexValue();
                        if (index == -1)
                        {
                            Console.WriteLine("Không tìm thấy sinh viên");
                            Console.ReadKey();
                            return;
                        }
                        _lstStudents[index].InRaManHinh();
                        Console.ReadKey();
                        break;

                    case "2":

                        _input = delegateInput?.Invoke("họ sinh viên muốn tìm");
                        for (int i = 0; i < _lstStudents.Count; i++)
                        {
                            if (_lstStudents[i].Ho.ToLower().Contains(_input.ToLower()) == true)
                            {
                                _lstStudents[i].InRaManHinh();
                                count++;
                            }
                        }
                        Console.ReadKey();
                        if (count == 0)
                        {
                            Console.WriteLine("Không tìm thấy sinh viên");
                            Console.ReadKey();
                        }
                        break;

                    case "3":
                        _input = delegateInput?.Invoke("tên sinh viên muốn tìm");
                        for (int i = 0; i < _lstStudents.Count; i++)
                        {
                            if (_lstStudents[i].Ten.ToLower().Contains(_input.ToLower()) == true)
                            {
                                _lstStudents[i].InRaManHinh();
                                count++;
                            }

                        }
                        Console.ReadKey();
                        if (count == 0)
                        {
                            Console.WriteLine("Không tìm thấy sinh viên");
                            Console.ReadKey();
                        }
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Chức năng không tồn tại");
                        break;
                }
            } while (choose != "0");
        }
        //Xuất danh sách sinh viên
        public void DisplayStudent()
        {
            _lstStudents.ForEach(x => x.InRaManHinh());
        }
    }
}
