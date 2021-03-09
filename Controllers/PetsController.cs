using Microsoft.AspNetCore.Mvc;
using Opdracht2_Adam.Models;
using Opdracht2_Adam.Services.Interfaces;
using Opdracht2_Adam.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opdracht2_Adam.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public partial class PetController : ControllerBase
    {
        private readonly IPetServices _petService;

        public PetController(IPetServices petService)
        {
            this._petService = petService;
        }/*
        [HttpPost("CREATE")]
        public ActionResult<Pet> CreatePet(CreatePetDTO createPetDTO)
        {
            var newPet = new Pet();
            newPet.Name = createPetDTO.Name;
            newPet.Geboortedatum = createPetDTO.Geboortedatum;
            newPet.Types = createPetDTO.Types;
            var PetFromDB = _petService.AddPet(newPet);
            return Ok(PetFromDB);
        }*/
        [HttpGet("SHOW ALL PETS")]
        public ActionResult<List<ResponsePetDTO>> GetAllPets()
        {
            var pets = _petService.GetPets();
            var listOfResponsePetDTO = new List<ResponsePetDTO>();
            foreach (var p in pets)
            {
                var responsePetDTO = new ResponsePetDTO();
                responsePetDTO.Id = p.Id;
                responsePetDTO.Name = p.Name;
                //responsePetDTO.Geboortedatum = p.Geboortedatum;
                //responsePetDTO.Types = p.Types;
                //responsePetDTO.Persoon = p.Persoonsen;
                listOfResponsePetDTO.Add(responsePetDTO);
            }

            return Ok(listOfResponsePetDTO);
        }
        [HttpPut("UPDATE")]
        public ActionResult<Pet> UpdatePetByID(int petIdToEdit, Pet petEditValues)
        {
            var updatedPet = _petService.UpdatePetByID(petIdToEdit, petEditValues);
            return Ok(updatedPet);
        }
        [HttpDelete("DELETE")]
        public ActionResult DeletePetByID(int petjeid)
        {
            _petService.DeletePetByID(petjeid);
            return Ok();

        }

        [HttpGet("manywithproducts")]
        public ActionResult<List<ResponsePetWithPersoonsDTO>> GetAllPetsWithPersoons()
        {
            var pets = _petService.GetPetsWithPersoons();
            var listOfResponsePetDTO = new List<ResponsePetWithPersoonsDTO>();
            foreach (Pet p in pets)
            {
                var responsePetDTO = new ResponsePetWithPersoonsDTO();
                responsePetDTO.Id = p.Id;
                responsePetDTO.Name = p.Name;
                responsePetDTO.Geboortedatum = p.Geboortedatum;
                responsePetDTO.Types = p.Types;
                responsePetDTO.Persoon = new List<ResponsePersoonDTO>();

                foreach (Persoon persoon in p.Persoonsen)
                {
                    var responsePersoonDTO = new ResponsePersoonDTO();
                    responsePersoonDTO.Id = persoon.Id;
                    responsePersoonDTO.Firstname = persoon.Firstname;
                    responsePersoonDTO.Lastname = persoon.Lastname;
                    responsePersoonDTO.Password = persoon.Password;
                    responsePersoonDTO.Email = persoon.Email;
                    responsePersoonDTO.Geboortedatum = persoon.Geboortedatum;
                    responsePersoonDTO.HasHouse = persoon.HasHouse;
                    responsePetDTO.Persoon.Add(responsePersoonDTO);
                }
                listOfResponsePetDTO.Add(responsePetDTO);
            }

            return Ok(listOfResponsePetDTO);
        }
        [HttpGet("manywithproductsthatcrashes")]
        public ActionResult<List<Pet>> GetAllPetWithPersoonsWITHOUTDTO()
        {
            var pets = _petService.GetPetsWithPersoons();
            return Ok(pets);
        }

    }
}
