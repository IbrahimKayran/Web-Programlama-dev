using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlaOdev.Models
{
    public class Urun
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        public string Acıklama { get; set; }

        public bool Ucret { get; set; }

        public int UKategoriId { get; set; }

        public UKategori UKategori { get; set; }

    }
}
