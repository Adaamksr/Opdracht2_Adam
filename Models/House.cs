using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opdracht2_Adam.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Straat { get; set; }
        public string Huisnr { get; set; }
        public string Postcode { get; set; }
        public string Gemeente { get; set; }
        public string Persoon { get; set; }
    }
}
