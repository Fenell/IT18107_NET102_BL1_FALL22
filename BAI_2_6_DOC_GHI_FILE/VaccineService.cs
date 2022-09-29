using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_6_DOC_GHI_FILE
{
    internal class VaccineService
    {
        private FileStream _fileStream;
        private BinaryFormatter _binaryFormatter;

        public void writeToFile(string path, List<Vaccine> vaccine)
        {
            _fileStream = new FileStream(path, FileMode.Open);
            _binaryFormatter = new BinaryFormatter();
            _binaryFormatter.Serialize(_fileStream, vaccine);
            //Serilsiza là phương thức chuyển hoá dạng dối tượng sang dạng text hoặc mảng,... có thể lưu vào file
            _fileStream.Close();
        }

        public void addVaccine()
        {
            Console.WriteLine("");
        }

        public List<Vaccine> readFromFile(string path)
        {
            _fileStream = new FileStream(path, FileMode.Open);
            _binaryFormatter = new BinaryFormatter();
            var data = _binaryFormatter.Deserialize(_fileStream) as List<Vaccine>;
            //var result = (List<Vaccine>) data;
            _fileStream.Close();
            return data;
        }

    }
}
