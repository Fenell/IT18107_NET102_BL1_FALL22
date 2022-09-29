//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Text;
//using System.Threading.Tasks;

//namespace LAB
//{
//    internal class StudentService
//    {
//        private List<Student> _lstStudents;
//        private Student _student;
//        private string _input;
//        private FileStream _QlStudent;
//        private BinaryFormatter binaryFormatter;

//        public StudentService()
//        {
//            _lstStudents = new List<Student>()
//            {
//                new Student()
//                //new Student("Phạm", "Chiến", "Văn", "PH20349", 2000, 8, 0, "Hà Nội"),
//                //new Student("Đặng", "Sơn", "Thái", "PH2583", 1999, 8.6, 0, "Thái Bình"),
//                //new Student("Nguyễn", "Anh", "Phương", "PH9532", 2001, 6.7, 1, "Nam Định"),
//                //new Student("Phạm", "Hương", "Thị", "PH5269", 2002, 9.6, 1, "Hải Phòng"),
//                //new Student("Mai", "Đạt", "Tuấn", "PH20349", 1998, 10, 0, "Thái Bình"),
//            };
//        }

//        //public void writeStudent(string path, List<Student> students )
//        //{
//        //    BinaryFormatter binaryFormatter = new BinaryFormatter();
//        //    _QlStudent = new FileStream(path, FileMode.Create);
//        //    binaryFormatter.Serialize(_QlStudent, students);
//        //}

//        //public List<Student> readStudent(string path)
//        //{
//        //    _QlStudent = new FileStream(path, FileMode.Create);
//        //    BinaryFormatter binaryFormatter = new BinaryFormatter();
//        //    var data = binaryFormatter.Deserialize(_QlStudent) as List<Student>;
//        //    return data;
//        //}

//        public string GetInput(string msg)
//        {
//            Console.Write($"Mời bạn nhập {msg}: ");
//            return Console.ReadLine();
//        }


//        public void addStudent()
//        {
//            do
//            {
//                _student = new Student();
//                _student.Ten = GetInput("Tên");
//                _student.Ho = GetInput("Họ");
//                _student.TenDem = GetInput("tên đệm");
//                _student.MaSv = GetInput("mã sinh viên");
//                _student.NamSinh = Convert.ToInt32(GetInput("năm sinh"));
//                _student.DiemCSharp = Convert.ToDouble(GetInput("điểm C Sharp"));
//                _student.GioiTinh = Convert.ToInt32(GetInput("giới tính (0-- nam || 1- nữ): "));
//                _student.QueQuan = GetInput("quê quán");
//                _lstStudents.Add(_student);
//                Console.WriteLine("Bạn có muốn nhập tiếp không (y - có || n -- không)");
//                _input = Console.ReadLine();
//            } while (_input == "y");
//        }

//        public void EditStudent()
//        {
//            _input = GetInput("mã sinh viên");
//            for (int i = 0; i < _lstStudents.Count; i++)
//            {
//                if (_lstStudents[i].MaSv.ToLower() == _input.ToLower())
//                {
//                    _lstStudents[i].Ho = GetInput("họ mới");
//                    _lstStudents[i].Ten = GetInput("tên mới");
//                    _lstStudents[i].TenDem = GetInput("tên đệm mới");
//                    Console.WriteLine("Sửa thành công");
//                    return;
//                }
//            }
//            Console.WriteLine("Không tìm thấy.");
//        }

//        public void DisplayStudent()
//        {
//            _lstStudents.ForEach(x => x.InRaManHinh());
//        }
//    }
//}
