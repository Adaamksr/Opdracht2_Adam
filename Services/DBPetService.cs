using Microsoft.EntityFrameworkCore;
using Opdracht2_Adam.db;
using Opdracht2_Adam.Models;
using Opdracht2_Adam.Services;
using Opdracht2_Adam.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opdracht2_Adam.Services
{
    public class DBPetService : IPetServices
    {
        public Pet AddPet(Pet pet)
        {
            using (var db = new OpdrachtDBContext())
            {
                db.Pets.Add(pet);
                db.SaveChanges();
                return pet;
            }
        }

        public Pet UpdatePetByID(int petIdToEdit, Pet petEditValues)
        {
            using (var db = new OpdrachtDBContext())
            {
                var petToEdit = db.Pets.First(pet => pet.Id == petIdToEdit);
                petToEdit.Name = petEditValues.Name;
                petToEdit.Geboortedatum = petEditValues.Geboortedatum;
                petToEdit.Types = petEditValues.Types;
                db.Pets.Update(petToEdit);
                db.SaveChanges();
                return petToEdit;
            }
        }

        public void DeletePetByID(int petjeid)
        {
            using (var db = new OpdrachtDBContext())
            {
                var petToDelete = db.Pets.FirstOrDefault(pet => pet.Id == petjeid);
                db.Pets.Remove(petToDelete);
                db.SaveChanges();
            }
        }

        public List<Pet> GetPets()
        {
            using (var db = new OpdrachtDBContext())
            {
                var listOfPets = db.Pets.ToList();
                return listOfPets;
            }
        }
        public List<Pet> GetPetsWithPersoons()
        {
            using (var db = new OpdrachtDBContext())
            {
                var listOfPets = db.Pets.Include(x => x.Persoonsen).ToList();
                return listOfPets;
            }
        }

    }
}
