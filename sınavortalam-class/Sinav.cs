using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınavortalam_class
{
    internal class Sinav
    {
        public double yazili1;
        public double yazili2;
        
        public double OrtalamaHesapla()
        {
            return (yazili1 + yazili2) / 2;
        }

    }
}
