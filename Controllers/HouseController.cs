using Microsoft.AspNetCore.Mvc;
using Opdracht2_Adam.Models;
using Opdracht2_Adam.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opdracht2_Adam.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HouseController : Controller
    {
        private readonly IHouseService _houseService;
        public HouseController(IHouseService houseService)
        {
            _houseService = houseService;
        }
        [HttpGet("SHOW ALL HOUSES")]
        public ActionResult<List<House>> GetAllHouses()
        {
            var houses = _houseService.GetHouses();
            return Ok(houses);
        }
        [HttpPost("CREATE")]
        public ActionResult CreateNewHouse(House newHouse)
        {
            _houseService.AddHouse(newHouse);
            return Ok();
        }
        [HttpDelete("DELETE")]
        public ActionResult DeleteHouseById(int houseId)
        {
            _houseService.DeleteHouseById(houseId);
            return Ok();
        }

        [HttpPut("UPDATE")]
        public ActionResult<House> UpdateHouseById(int houseIdToEdit, House houseEditValues)
        {
            var updatedHouse = _houseService.UpDateHouseById(houseIdToEdit, houseEditValues);
            return Ok(updatedHouse);


        }
    }
}
