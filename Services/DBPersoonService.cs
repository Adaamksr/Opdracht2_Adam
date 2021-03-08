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
        public List<Persoon> GetPersonen()
        {
            using (var db = new OpdrachtDBContext())
            {
                return db.Personen.ToList();
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


        public Persoon UpDatePersoonById(string persoonmail, string persoonpassword, string NewPassword, Persoon persoonEditValues)
        {
            using (var db = new OpdrachtDBContext())
            {
                var persoonToEdit = db.Personen.First(x => x.Email == persoonmail && x.Password == persoonpassword);
                persoonToEdit.Password = NewPassword;
                db.Personen.Update(persoonToEdit);
                db.SaveChanges();
                return persoonToEdit;
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
                PersoonToEdit.PetId = PersoonEditValues.PetId;
                PersoonToEdit.Geboortedatum = PersoonEditValues.Geboortedatum;
                PersoonToEdit.HasHouse = PersoonEditValues.HasHouse;
                db.Personen.Update(PersoonToEdit);
                db.SaveChanges();
                return PersoonToEdit;
            }
        }

        public Persoon PersoonLogIn(string persoonmail, string persoonpassword)
        {
            using (var db = new OpdrachtDBContext())
            {
                var persoon = db.Personen.FirstOrDefault(x => x.Email == persoonmail && x.Password == persoonpassword);
                return persoon;
            }
        }
        public Persoon GetMyPets(int persoonId)
        {
            using (var db = new OpdrachtDBContext())
            {
                var GetPets = db.Personen.FirstOrDefault(persoon => persoon.Id == persoonId);
                return GetPets;
            }
        }

    }
}
