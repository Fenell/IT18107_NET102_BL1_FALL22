using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_4_NULL_VA_NULABLE_TYPE
{
    internal class ConVat
    {
        public string Name;
        public int? tuoi;

        public ConVat(string name, int? tuoi)
        {
            Name = name;
            this.tuoi = tuoi;
        }
    }
}
