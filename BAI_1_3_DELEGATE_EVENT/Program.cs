using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_3_DELEGATE_EVENT
{
    //Bước 1: TẠO 1 delegate
    delegate void UpdateName(string name);
    //Bước 2: Tạo class
    class SinhVien
    {
        public event UpdateName nameChange;
        private string name;

        public string Name
        {
            get => name;
            set
            {
                name = value;   //Kiểm tra sự kiện mong muốn khi tên bị tác động
                if (nameChange != null)
                {
                    nameChange(name);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SinhVien sv = new SinhVien();
            sv.nameChange += Sv_nameChange;
            sv.Name = "dat";
            Console.WriteLine("Tên mới :" + sv.Name);
            sv.Name = "C#2";
            Console.WriteLine("Tên mới :" + sv.Name);
        }

        private static void Sv_nameChange(string name)
        {
            Console.WriteLine("THông báo giá trị mới của name: " + name);
        }
    }
}
