using Microsoft.AspNetCore.Mvc;
using Opdracht2_Adam.Models;
using Opdracht2_Adam.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Opdracht2_Adam.Controllers.PetController;

namespace Opdracht2_Adam.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public partial class PersoonController : ControllerBase
    {
        private readonly IPersoonService _persoonService;
        public PersoonController(IPersoonService persoonService)
        {
            _persoonService = persoonService;
        }
        [HttpGet("SHOW ALL PERSONS")]
        public ActionResult<List<Persoon>> GetAllPersonen()
        {
            var personen = _persoonService.GetPersonen();
            return Ok(personen);
        }
        [HttpPost("CREATE")]
        public ActionResult CreateNewPersoon(CreatePersoonDTO CreatePersoonDTO)
        {
            var PersoonToInsertInDB = new Persoon();
            PersoonToInsertInDB.Firstname = CreatePersoonDTO.Firstname;
            PersoonToInsertInDB.Lastname = CreatePersoonDTO.Lastname;
            PersoonToInsertInDB.Password = CreatePersoonDTO.Password;
            PersoonToInsertInDB.Email = CreatePersoonDTO.Email;
            PersoonToInsertInDB.Geboortedatum = CreatePersoonDTO.Geboortedatum;
            PersoonToInsertInDB.PetId = CreatePersoonDTO.PetId;
            PersoonToInsertInDB.HasHouse = CreatePersoonDTO.HasHouse;
            _persoonService.AddPersoon(PersoonToInsertInDB);
            return Ok();
        }
        [HttpGet("LOGIN")]
        public ActionResult<Persoon> PersoonLogIn(string persoonmail, string persoonpassword)
        {
            var persoon = _persoonService.PersoonLogIn(persoonmail, persoonpassword);
            if (persoon == null)
            {
                return NotFound();

            }
            return Ok(persoon);
        }
        [HttpPut("CHANGE PASSWORD")]
        public ActionResult<Persoon> UpDatePersoonById(string persoonmail, string persoonpassword, string NewPassword, Persoon persoonEditValues)
        {
            var updatedPersoon = _persoonService.UpDatePersoonById(persoonmail, persoonpassword, NewPassword, persoonEditValues);
            return Ok(updatedPersoon);
        }

        [HttpDelete("DELETE")]
        public ActionResult DeletePersoonById(int persoonId)
        {
            _persoonService.DeletePersoonById(persoonId);
            return Ok();
        }

        [HttpGet("GET MY PETS")]
        public ActionResult<ResponsePetDTO> GetMyPets(int persoonId)
        {
            var persoon = _persoonService.GetMyPets(persoonId);
            var listOfResponsePetDTO = new List<ResponsePetDTO>();
            if (persoon == null)
            {
                return NotFound();

            }
            return Ok(persoon.PetId);

            

        }
    }
}