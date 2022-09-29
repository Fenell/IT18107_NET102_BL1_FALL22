using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_6_DOC_GHI_FILE
{
    [Serializable]
    internal class Vaccine
    {
        private string _maVaccine;
        private string _tenVaccine;
        private bool _status;

        public Vaccine()
        {
        }

        public Vaccine(string maVaccine, string tenVaccine, bool status)
        {
            MaVaccine = maVaccine;
            TenVaccine = tenVaccine;
            Status = status;
        }

        public string MaVaccine { get => _maVaccine; set => _maVaccine = value; }
        public string TenVaccine { get => _tenVaccine; set => _tenVaccine = value; }
        public bool Status { get => _status; set => _status = value; }
        
        public void InRaManHinh()
        {
            Console.WriteLine($"Mã Vaccine: {MaVaccine} --- Tên Vaccine: {TenVaccine} ---- Trạng thái: {(Status?"Hoạt động": "Không hoạt động")}");
        }

    }
}
