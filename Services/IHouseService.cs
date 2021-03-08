using Opdracht2_Adam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opdracht2_Adam.Services
{
    public interface IHouseService
    {
        List<House> GetHouses();
        void AddHouse(House house);
        void DeleteHouseById(int houseId);
        House UpDateHouseById(int houseIdToEdit, House houseEditValues);
    }
}
