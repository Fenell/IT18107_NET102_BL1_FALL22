using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_6_DOC_GHI_FILE
{
    internal class Program
    {
        private static string _path = @"D:\CODEl";
        static void Main(string[] args)
        {
            VaccineService service = new VaccineService();
            var data = new List<Vaccine>
            {
                new Vaccine("1", "Mordena", true),
                new Vaccine("2", "Astra Zeneca", true),
                new Vaccine("3", "Ffizer", true)
            };
            service.writeToFile(_path, data);
            var readData = service.readFromFile(_path);
            Console.WriteLine("------------------------");
            readData.ForEach(x => x.InRaManHinh());

        }
    }
}
