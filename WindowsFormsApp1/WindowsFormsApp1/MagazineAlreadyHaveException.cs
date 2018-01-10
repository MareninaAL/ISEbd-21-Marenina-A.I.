using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MagazineAlreadyHaveException : Exception
    {
        public MagazineAlreadyHaveException() : base("уже есть такой объект") { }
    }
}
