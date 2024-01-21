using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.Exceptions
{
    internal class InvalidStringPointException: ApplicationException
    {
        public InvalidStringPointException(String text): base(text) { }
    }
}
