using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlaOdev.Models
{
    public class Hayvan
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        [DataType(DataType.Date)]
        public DateTime DogumTarihi { get; set; }

        [DataType(DataType.Date)]
        public DateTime IlanTarihi { get; set; }

        public Cinsiyet Cinsiyet { get; set; }

        public int TelNo { get; set; }

        public string Il { get; set; }

        public string Ilce { get; set; }
    }

    public enum Cinsiyet
    {
        Erkek = 1,
        Disi = 2
    }
}
