using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        //Property - özellik
        public int Id { get; set; } //eşsiz değer demek Id

        public string Adi { get; set; }

        public double Fiyati { get; set; }

        public string Aciklama { get; set; }
        public string stokAdedi { get; set; }

    }
}
