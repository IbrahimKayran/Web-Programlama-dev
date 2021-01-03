using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebProgramlaOdev.Models
{
    public class Yorum
    {
        public int Id { get; set; }

        public string Yorumlar { get; set; }

        [DataType(DataType.Date)]
        public DateTime YorumTarihi { get; set; }

        public int UrunId { get; set; }

        public Urun Urun { get; set; }

        public int UyeId { get; set; }

        public Uye Uye { get; set; }
    }
}
