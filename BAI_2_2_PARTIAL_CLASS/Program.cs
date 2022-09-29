using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_2_PARTIAL_CLASS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Partial Class
            //DemoParrtialClass demoParrtialClass = new DemoParrtialClass();
            //demoParrtialClass.A = 1;
            //demoParrtialClass.B = 2;
            //demoParrtialClass.C = 3;
            //demoParrtialClass.PhuongThuc1();
            //demoParrtialClass.method2();

            #endregion

            #region Nester class
            //Nester class hay Nester type là chỉ việc khai báo 1 class bên trong thân cả 1 class khác
            // Để truy cập vào Nester class ta gọi Container.Nester
            Container.Nester demo = new Container.Nester(5);
            demo.inA();
            #endregion
        }
    }
}
