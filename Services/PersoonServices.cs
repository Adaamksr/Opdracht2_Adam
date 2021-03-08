/*using Opdracht2_Adam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opdracht2_Adam.Services
{
    public class PersoonServices : IPersoonService
    {
        List<Persoon> personen = new List<Persoon>();

        public PersoonServices()
        {
            if (personen.Count == 0)
            {
                var persoon1 = new Persoon();
                persoon1.Firstname = "Adam";
                persoon1.Lastname = "Kasri";
                persoon1.Password = "123";
                persoon1.Email = "adamkasri@gmail.com";
                persoon1.Geboortedatum = "3 Juni 1998";
                persoon1.PetId = 5;
                persoon1.HasHouse = 1;
            }
        }
        public List<Persoon> GetPersonen()
        {
            return personen;
        }
        public void AddPersoon(Persoon persoon)
        {
            personen.Add(persoon);
        }
        public void DeletePersoonById(int persoonId)
        {
            throw new NotImplementedException();
        }
        public Persoon UpDatePersoonById(string persoonmail, string persoonpassword, string NewPassword, Persoon persoonEditValues)
        {
            var persoon = personen.FirstOrDefault(x => x.Email == persoonmail && x.Password == persoonpassword);
            return persoon;
        }

        public Persoon PersoonLogIn(string persoonmail, string persoonpassword)
        {
            var persoon = personen.FirstOrDefault(x => x.Email == persoonmail && x.Password == persoonpassword);
            return persoon;
        }
    }
}
*/