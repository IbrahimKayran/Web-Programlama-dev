using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlaOdev.Models
{
    public class Kedi
    {
        public int Id { get; set; }

        public string Cins { get; set; }

        public int HayvanId { get; set; }

        public Hayvan Hayvan { get; set; }
    }
}
