using System.Collections.Generic;
using Opdracht2_Adam.Models;

namespace Opdracht2_Adam.Services
{
    public interface IPersoonService
    {
        List<Persoon> GetPersonen();
        void AddPersoon(Persoon persoon);
        Persoon PersoonLogIn(string persoonmail, string persoonpassword);
        Persoon UpDatePersoonById(string persoonmail, string persoonpassword, string NewPassword, Persoon persoonEditValues);
        Persoon UpDatePersoonById2(int PersoonIdToEdit, Persoon PersoonEditValues);
        void DeletePersoonById(int persoonId);
        Persoon GetMyPets(int persoonId);

    }
}
