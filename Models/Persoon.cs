using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opdracht2_Adam.Models
{
    public class Persoon
    {
        public Persoon()
        {
            HouseId = null;
        }
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Geboortedatum { get; set; }
        public List<Pet> Pets { get; set; } 
        public int? HouseId { get; set; } // 0 nee - 1 Ja
        public House House { get; set; } // 0 nee - 1 Ja
    }
}
