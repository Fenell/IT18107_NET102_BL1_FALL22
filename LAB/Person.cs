using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Person
    {
        private string ho;
        private string ten;
        private string tenDem;
        private int namSinh;
        private int gioiTinh;
        private string queQuan;

        public Person()
        {

        }

        public Person(string ho, string ten, string tenDem, int namSinh, int gioiTinh, string queQuan)
        {
            this.Ho = ho;
            this.Ten = ten;
            this.TenDem = tenDem;
            this.NamSinh = namSinh;
            this.GioiTinh = gioiTinh;
            this.QueQuan = queQuan;
        }

        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string TenDem { get => tenDem; set => tenDem = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }

        public virtual void InRaManHinh()
        {
            Console.WriteLine($"{Ho} -- {Ten} -- {TenDem} -- {NamSinh} -- {(GioiTinh == 0 ? "Nam" : "Nữ")}, {QueQuan} ");
        }
    }
}
