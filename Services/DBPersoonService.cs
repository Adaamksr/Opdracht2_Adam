using Microsoft.EntityFrameworkCore;
using Opdracht2_Adam.db;
using Opdracht2_Adam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opdracht2_Adam.Services
{
    public class DbPersoonService : IPersoonService
    {
        public void AddPersoon(Persoon persoon)
        {
            using (var db = new OpdrachtDBContext())
            {
                db.Personen.Add(persoon);
                db.SaveChanges();
            }
        }
        public bool PersoonLogIn(string persoonmail, string persoonpassword)
        {
            using (var db = new OpdrachtDBContext())
            {
                var persoon = db.Personen.FirstOrDefault(x => x.Email == persoonmail && x.Password == persoonpassword);
                if(persoon == null)
                {
                    return true;
                }
                return false;
            }
        }
        public void ChangePasswordById(string persoonmail, string persoonpassword, string NewPassword)
        {
            using (var db = new OpdrachtDBContext())
            {
                var persoonToEdit = db.Personen.First(x => x.Email == persoonmail && x.Password == persoonpassword);
                if(persoonpassword != null)
                { 
                    persoonToEdit.Password = NewPassword;
                    db.Personen.Update(persoonToEdit);
                    db.SaveChanges();
                }
                else
                {
                throw new UnauthorizedAccessException("Invalid email and/or currentpassword");
                }
            }
        }
        public void DeletePersoonById(int persoonId)
        {
            using (var db = new OpdrachtDBContext())
            {
                var persoonToDelete = db.Personen.FirstOrDefault(persoon => persoon.Id == persoonId);
                db.Personen.Remove(persoonToDelete);
                db.SaveChanges();
            }
        }
        public List<Persoon> GetPersonen()
        {
            using (var db = new OpdrachtDBContext())
            {
                return db.Personen.ToList();
            }
        }

        public Persoon UpDatePersoonById2(int PersoonIdToEdit, Persoon PersoonEditValues)
        {
            using (var db = new OpdrachtDBContext())
            {
                var PersoonToEdit = db.Personen.First(Persoon => Persoon.Id == PersoonIdToEdit);
                PersoonToEdit.Firstname = PersoonEditValues.Firstname;
                PersoonToEdit.Lastname = PersoonEditValues.Lastname;
                PersoonToEdit.Password = PersoonEditValues.Password;
                PersoonToEdit.Email = PersoonEditValues.Email;
                PersoonToEdit.Pets = PersoonEditValues.Pets;
                PersoonToEdit.Geboortedatum = PersoonEditValues.Geboortedatum;
                PersoonToEdit.HouseId = PersoonEditValues.HouseId;
                db.Personen.Update(PersoonToEdit);
                db.SaveChanges();
                return PersoonToEdit;
            }
        }

        public List<Pet> GetMyPets(int persoonId)
        {
            using (var db = new OpdrachtDBContext())
            {
                //var GetPets = db.Personen.Include(pet=> pet.Pets).FirstOrDefault(persoon => persoon.Id == persoonId);
                //return GetPets.Pets;

                var listOfPets = db.Pets.Where(x => x.PersonId == persoonId).ToList();
                return listOfPets;
            }
        }

    }
}
