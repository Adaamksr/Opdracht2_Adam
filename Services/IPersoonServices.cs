using System.Collections.Generic;
using Opdracht2_Adam.Models;

namespace Opdracht2_Adam.Services
{
    public interface IPersoonService
    {
        List<Persoon> GetPersonen();
        void AddPersoon(Persoon persoon);
        bool PersoonLogIn(string persoonmail, string persoonpassword);
        void ChangePasswordById(string persoonmail, string persoonpassword, string NewPassword);
        Persoon UpDatePersoonById2(int PersoonIdToEdit, Persoon PersoonEditValues);
        void DeletePersoonById(int persoonId);
        List<Pet> GetMyPets(int persoonId);

    }
}
