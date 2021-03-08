using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opdracht2_Adam.Models
{
    public class Persoon
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Geboortedatum { get; set; }
        public int PetId { get; set; } 
        public List<Pet> Pet { get; set; } 
        public int HasHouse { get; set; } // 0 nee - 1 Ja
    }
}
