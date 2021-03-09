using Opdracht2_Adam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Opdracht2_Adam.Controllers.PersoonController;

namespace Opdracht2_Adam.Profiles
{
    public class Persoonprofile : AutoMapper.Profile
    {
        public Persoonprofile()
        {
            CreateMap<CreatePersoonDTO, Persoon>()
                .ReverseMap();
        }
    }
}
