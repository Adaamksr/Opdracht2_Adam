using AutoMapper;
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
        private readonly IMapper _mapper;
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
            var PersoonToInsertInDB = _mapper.Map<Persoon>(CreatePersoonDTO);
            _persoonService.AddPersoon(PersoonToInsertInDB);
            return Ok();
        }
        [HttpGet("LOGIN")]
        public ActionResult<bool> PersoonLogIn(string persoonmail, string persoonpassword)
        {
            return Ok(_persoonService.PersoonLogIn(persoonmail, persoonpassword));
        }
        [HttpPut("CHANGE PASSWORD")]
        public ActionResult ChangePasswordById(string persoonmail, string persoonpassword, string NewPassword)
        {
            try
            {
                _persoonService.ChangePasswordById(persoonmail, persoonpassword, NewPassword);
            }
            catch
            {
                return Unauthorized();
            }
            return Ok();
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
            return Ok(persoon);

            

        }
    }
}