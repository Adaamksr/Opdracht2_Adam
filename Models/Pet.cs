using System.Collections.Generic;

namespace Opdracht2_Adam.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Geboortedatum { get; set; }
        public string Types { get; set; }
        public List<Persoon> Persoonsen { get; set; }
    }
}
