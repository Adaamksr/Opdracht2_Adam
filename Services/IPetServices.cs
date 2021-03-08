using Opdracht2_Adam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opdracht2_Adam.Services.Interfaces
{
    public interface IPetServices
    {
        Pet AddPet(Pet pet);
        void DeletePetByID(int petjeid);
        List<Pet> GetPets();
        List<Pet> GetPetsWithPersoons();
        Pet UpdatePetByID(int petIdToEdit, Pet petEditValues);
    }
}
