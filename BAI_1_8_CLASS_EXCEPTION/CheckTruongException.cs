using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_8_CLASS_EXCEPTION
{
    internal class CheckTruongException : Exception
    {
        public CheckTruongException(string message) : base(message)
        {

        }
    }
}
