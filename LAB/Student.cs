using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Student
    {
        private string ho;
        private string ten;
        private string tenDem;
        private string maSv;
        private int namSinh;
        private double diemCSharp;
        private int gioiTinh;
        private string queQuan;

        public Student()
        {

        }

        public Student(string ho, string ten, string tenDem, string maSv, int namSinh, double diemCSharp, int gioiTinh, string queQuan)
        {
            this.Ho = ho;
            this.Ten = ten;
            this.TenDem = tenDem;
            this.MaSv = maSv;
            this.NamSinh = namSinh;
            this.DiemCSharp = diemCSharp;
            this.GioiTinh = gioiTinh;
            this.QueQuan = queQuan;
        }

        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string TenDem { get => tenDem; set => tenDem = value; }
        public string MaSv { get => maSv; set => maSv = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double DiemCSharp { get => diemCSharp; set => diemCSharp = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }

        public void InRaManHinh()
        {
            Console.WriteLine($"{Ho} -- {Ten} -- {TenDem} -- {MaSv} -- {NamSinh} -- {DiemCSharp} -- {(GioiTinh == 0? "Nam": "Nữ" )}, {QueQuan} ");
        }
    }
}
