using Opdracht2_Adam.Models;
using System.Collections.Generic;

namespace Opdracht2_Adam.Controllers
{
    public partial class PetController
    {
        public class CreatePetDTO
        {
            public string Name { get; set; }
            public string Geboortedatum { get; set; }
            public string Types { get; set; }
        }
    }
}
