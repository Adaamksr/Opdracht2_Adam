using System;
using System.Collections.Generic;

namespace Opdracht2_Adam.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Geboortedatum { get; set; }
        //public PetTypes PetType { get; set; }
        public int PersonId { get; set; } //Automatisch aangemaakt moet en niet bij
        public Persoon Persoon { get; set; }
    }
}
