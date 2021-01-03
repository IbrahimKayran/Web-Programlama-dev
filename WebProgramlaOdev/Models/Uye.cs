using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlaOdev.Models
{
    public class Uye
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        [DataType(DataType.Date)]
        public DateTime DogumTarihi { get; set; }

        public string AdSoyad
        {
            get { return Ad + " " + Soyad; }
        }
    }
}
