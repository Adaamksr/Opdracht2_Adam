using Opdracht2_Adam.db;
using Opdracht2_Adam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opdracht2_Adam.Services
{
    public class DBHouseService : IHouseService
    {
        public void AddHouse(House house)
        {
            using (var db = new OpdrachtDBContext())
            {
                db.Houses.Add(house);
                db.SaveChanges();
            }
        }

        public List<House> GetHouses()
        {
            using (var db = new OpdrachtDBContext())
            {
                return db.Houses.ToList();
            }
        }
        public void DeleteHouseById(int houseId)
        {
            using (var db = new OpdrachtDBContext())
            {
                var houseToDelete = db.Houses.FirstOrDefault(house => house.Id == houseId);
                db.Houses.Remove(houseToDelete);
                db.SaveChanges();
            }
        }

        public House UpDateHouseById(int houseIdToEdit, House houseEditValues)
        {
            using (var db = new OpdrachtDBContext())
            {
                var houseToEdit = db.Houses.First(house => house.Id == houseIdToEdit);
                houseToEdit.Straat = houseEditValues.Straat;
                houseToEdit.Huisnr = houseEditValues.Huisnr;
                houseToEdit.Postcode = houseEditValues.Postcode;
                houseToEdit.Gemeente = houseEditValues.Gemeente;
                houseToEdit.Persoon = houseEditValues.Persoon;
                db.Houses.Update(houseToEdit);
                db.SaveChanges();
                return houseToEdit;
            }
        }
    }
}
