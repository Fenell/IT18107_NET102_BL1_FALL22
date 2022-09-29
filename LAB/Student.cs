using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Student: Person
    {
        private string maSv;
        private double diemCSharp;

        public Student()
        {

        }

        public Student(string ho, string ten, string tenDem, int namSinh, int gioiTinh, string queQuan, string maSv, double diemCSharp) : base(ho, ten, tenDem, namSinh, gioiTinh, queQuan)
        {
            this.maSv = maSv;
            this.diemCSharp = diemCSharp;
        }

        public string MaSv { get => maSv; set => maSv = value; }
        public double DiemCSharp { get => diemCSharp; set => diemCSharp = value; }

        public override void InRaManHinh()
        {
            Console.WriteLine($"{Ho} -- {TenDem}-- {Ten} -- {MaSv} -- {NamSinh} -- {DiemCSharp} -- {(GioiTinh == 0 ? "Nam" : "Nữ")}, {QueQuan} ");
        }
    }
}
